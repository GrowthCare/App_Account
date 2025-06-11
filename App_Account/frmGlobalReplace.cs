using Spire.Pdf;
using Spire.Pdf.Texts;
using Spire.Pdf.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace App_Account
{
    public partial class frmGlobalReplace : Form
    {
        public frmGlobalReplace()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void cmdBrowsePDF_Click(object sender, EventArgs e)
        {
            try
            {
                openDataCab.Filter = "PDF文件(*.pdf)|*.pdf";
                openDataCab.FileName = txt_Selected_PDF_Path.Text;
                if (openDataCab.ShowDialog() != DialogResult.OK)
                    return;

                txt_Selected_PDF_Path.Text = openDataCab.FileName.Trim();
                SetButtonEnable(false);
                txtElements.Text = "";

                if (!string.IsNullOrEmpty(txt_Selected_PDF_Path.Text))
                {
                    var elements = ExtractSensitiveElements(txt_Selected_PDF_Path.Text, "Config.xml");
                    txtElements.Text = string.Join(",", elements.Where(s => !string.IsNullOrEmpty(s)).Distinct());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("处理PDF文件时出现问题，原因为：\r\n" + ex.Message, "PDF替换", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                SetButtonEnable(true);
            }
        }

        private List<string> ExtractSensitiveElements(string pdfPath, string configPath)
        {
            var list = new List<string>();
            using (PdfDocument pdfDocument = new PdfDocument(pdfPath))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(configPath);

                PdfTableExtractor extractor = new PdfTableExtractor(pdfDocument);
                PdfTable[] tableLists = extractor.ExtractTable(0);

                if (tableLists != null && tableLists.Length > 0)
                {
                    list.AddRange(ExtractTableElements(tableLists[0], xml));
                }
                else
                {
                    list.AddRange(ExtractTextElements(pdfDocument, xml));
                }
            }
            return list;
        }

        private IEnumerable<string> ExtractTableElements(PdfTable table, XmlDocument xml)
        {
            var list = new List<string>();
            // 安全获取表格内容，避免越界
            string SafeGetText(int row, int col)
            {
                if (row < table.GetRowCount() && col < table.GetColumnCount())
                    return table.GetText(row, col);
                return string.Empty;
            }

            XmlNode root = xml.SelectSingleNode("AppSetup/table");
            if (root != null)
            {
                XmlNodeList friendList = root.SelectNodes("RC");
                foreach (XmlNode item in friendList)
                {
                    var iRow = item.SelectSingleNode("row")?.InnerText ?? "";
                    var iCol = item.SelectSingleNode("col")?.InnerText ?? "";
                    list.Add(SafeGetText(Convert.ToInt32(iRow), Convert.ToInt32(iCol)));
                }

                friendList = root.SelectNodes("R");
                foreach (XmlNode item in friendList)
                {
                    var startKey = item.SelectSingleNode("startKey")?.InnerText ?? "";
                    var endKey = item.SelectSingleNode("endKey")?.InnerText ?? "";
                    list.Add(GetMatchedText(SafeGetText(5, 1), startKey, endKey));
                }
            }
            return list;
        }

        private IEnumerable<string> ExtractTextElements(PdfDocument pdfDocument, XmlDocument xml)
        {
            var list = new List<string>();
            string phonePattern = @"(\D1[3|4|5|6|7|8|9]\d{1}[- ]?\d{4}[- ]?\d{4})";
            string idCardPattern = @"([1-9]\d{5}[12]\d{3}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])\d{3}[0-9xX])";
            int pageCount = Math.Min(pdfDocument.Pages.Count, 2);

            for (int i = 0; i < pageCount; i++)
            {
                PdfTextExtractor textExtractor = new PdfTextExtractor(pdfDocument.Pages[i]);
                PdfTextExtractOptions extractOptions = new PdfTextExtractOptions { IsExtractAllText = true };
                string textPage = textExtractor.ExtractText(extractOptions);

                list.AddRange(ExtractMatches(textPage, phonePattern, idCardPattern));

                XmlNode root = xml.SelectSingleNode("AppSetup/text");
                if (root != null)
                {
                    XmlNodeList friendList = root.SelectNodes("R");
                    foreach (XmlNode item in friendList)
                    {
                        var startKey = item.SelectSingleNode("startKey")?.InnerText ?? "";
                        var endKey = item.SelectSingleNode("endKey")?.InnerText ?? "";
                        list.Add(GetMatchedText(textPage, startKey, endKey));
                    }
                }
            }
            return list;
        }

        private void cmdExcuse_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Selected_PDF_Path.Text))
                {
                    MessageBox.Show("请先选择PDF文件！", "PDF替换", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                SetButtonEnable(false);

                char character = '*';
                string filePath = txt_Selected_PDF_Path.Text;
                string[] words = txtElements.Text.Replace("，", ",").Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                using (PdfDocument pdfDocument = new PdfDocument(filePath))
                {
                    foreach (PdfPageBase page in pdfDocument.Pages)
                    {
                        PdfTextReplacer ptr = new PdfTextReplacer(page);
                        foreach (var word in words)
                        {
                            if (!string.IsNullOrEmpty(word))
                            {
                                ptr.ReplaceAllText(word, string.IsNullOrEmpty(txt_new_text.Text) ? new string(character, word.Length) : txt_new_text.Text);
                            }
                        }
                    }
                    filePath = GenerateUniqueFileName(filePath);
                    pdfDocument.SaveToFile(filePath);
                }
                MessageBox.Show("所有替换要素成功替换完毕！", "PDF替换", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("处理PDF文件时出现问题，原因为：\r\n" + ex.Message, "PDF替换", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                SetButtonEnable(true);
            }
        }

        private List<string> ExtractMatches(string text, params string[] patterns)
        {
            var matches = new List<string>();
            foreach (var pattern in patterns)
            {
                foreach (Match match in Regex.Matches(text, pattern))
                {
                    matches.Add(match.Value.Trim());
                }
            }
            return matches;
        }

        private string GenerateUniqueFileName(string filePath)
        {
            string directory = Path.GetDirectoryName(filePath);
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);

            int i = 1;
            string newFilePath = filePath;
            while (File.Exists(newFilePath))
            {
                newFilePath = Path.Combine(directory, $"{fileNameWithoutExt}({i++}){extension}");
            }
            return newFilePath;
        }

        private void txtElements_TextChanged(object sender, EventArgs e)
        {
            cmdExcuse.Enabled = !string.IsNullOrEmpty(txtElements.Text);
        }

        private void SetButtonEnable(bool state)
        {
            cmdBrowsePDF.Enabled = state;
            cmdClose.Enabled = state;
            txtElements.Enabled = state;
            cmdExcuse.Enabled = state ? !string.IsNullOrEmpty(txtElements.Text) : state;
        }

        private void PhotoMosaic(string filePath, int x, int y, int w, int h)
        {
            using (Image backgroundImage = Image.FromFile(filePath))
            using (Bitmap resultBitmap = new Bitmap(backgroundImage.Width, backgroundImage.Height))
            using (Graphics g = Graphics.FromImage(resultBitmap))
            {
                g.DrawImage(backgroundImage, 0, 0, backgroundImage.Width, backgroundImage.Height);
                g.DrawRectangle(Pens.DarkGray, x, y, w, h);
                resultBitmap.Save("result.png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private string GetMatchedText(string text, string startKey, string endKey)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(startKey) || string.IsNullOrEmpty(endKey))
                return string.Empty;
            int startIndex = text.IndexOf(startKey, StringComparison.Ordinal);
            if (startIndex == -1) return string.Empty;
            int fromIndex = startIndex + startKey.Length;
            int endIndex = text.IndexOf(endKey, fromIndex, StringComparison.Ordinal);
            if (endIndex == -1) return string.Empty;
            return text.Substring(fromIndex, endIndex - fromIndex).Trim();
        }
    }
}