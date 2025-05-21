using Spire.Pdf;
using Spire.Pdf.Texts;
using Spire.Pdf.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            //����ҵ�������Ҫ����Ϣ
            StringBuilder sb = new StringBuilder();
            List<string> list = new List<string>();
            try
            {
                openDataCab.Filter = "PDF�ļ�(*.pdf)|*.pdf";
                openDataCab.FileName = txt_Selected_PDF_Path.Text;
                if (openDataCab.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                txt_Selected_PDF_Path.Text = openDataCab.FileName.Trim();

                SetButtonEnable(false);
                txtElements.Text = "";

                if (txt_Selected_PDF_Path.Text != "")
                {
                    using (PdfDocument pdfDocument = new PdfDocument(txt_Selected_PDF_Path.Text))
                    {
                        Boolean isTable = false;
                        XmlDocument xml = new XmlDocument();
                        xml.Load("Config.xml");

                        //ʵ����PdfTableExtractor��Ķ���
                        PdfTableExtractor extractor = new PdfTableExtractor(pdfDocument);
                        //����PdfTable��ı������
                        PdfTable[] tableLists;

                        //��ȡ�������
                        tableLists = extractor.ExtractTable(0);
                        if (tableLists != null)
                        {
                            list.Add(tableLists[0].GetText(0, 1));
                            list.Add(tableLists[0].GetText(0, 3));
                            list.Add(tableLists[0].GetText(0, 5));
                            list.Add(tableLists[0].GetText(1, 1));
                            list.Add(tableLists[0].GetText(2, 1));
                            list.Add(tableLists[0].GetText(2, 5));
                            list.Add(tableLists[0].GetText(3, 1));
                            list.Add(tableLists[0].GetText(3, 3));

                            XmlNodeList friendList = xml.SelectSingleNode("AppSetup/table").SelectNodes("R");
                            foreach (XmlNode item in friendList)
                            {
                                list.Add(GetMatchedText(tableLists[0].GetText(5, 1), item.SelectSingleNode("startKey").InnerText, item.SelectSingleNode("endKey").InnerText));
                            }
                            isTable = true;
                        }

                        if (!isTable)
                        {   //���û�б�����ݣ�����ȡ�ı�
                            string phonePattern = @"(\D1[3|4|5|6|7|8|9]\d{1}[- ]?\d{4}[- ]?\d{4})";
                            string idCardPattern = @"([1-9]\d{5}[12]\d{3}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])\d{3}[0-9xX])";
                            for (int i = 0; i < (pdfDocument.Pages.Count > 1 ? 2 : 1); i++)
                            {
                                //����һ�� PdfTextExtractot ����
                                PdfTextExtractor textExtractor = new PdfTextExtractor(pdfDocument.Pages[i]);

                                //����һ�� PdfTextExtractOptions ����
                                PdfTextExtractOptions extractOptions = new PdfTextExtractOptions
                                {
                                    IsExtractAllText = true
                                };

                                //�ӵ�ǰҳ������ȡ�ı�
                                string textPage = textExtractor.ExtractText(extractOptions);
                                list.AddRange(ExtractMatches(textPage, phonePattern, idCardPattern));

                                XmlNodeList friendList = xml.SelectSingleNode("AppSetup/table").SelectNodes("R");
                                foreach (XmlNode item in friendList)
                                {
                                    list.Add(GetMatchedText(textPage, item.SelectSingleNode("startKey").InnerText, item.SelectSingleNode("endKey").InnerText));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("����PDF�ļ�ʱ�������⣬ԭ��Ϊ��\r\n" + ex.Message, "PDF�滻", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                List<string> distinctNumbers = list.Distinct().ToList();
                foreach (var num in distinctNumbers)
                {
                    sb.Append(num + (string.IsNullOrEmpty(num) ? "" : ","));
                }
                if (sb.Length > 0)
                {
                    sb.Length -= 1; // �Ƴ����һ������
                    txtElements.Text = sb.ToString();
                }
                SetButtonEnable(true);
            }
        }

        private void cmdExcuse_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Selected_PDF_Path.Text))
                {
                    MessageBox.Show("����ѡ��PDF�ļ���", "PDF�滻", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                SetButtonEnable(false);

                char character = '*';
                string filePath = txt_Selected_PDF_Path.Text;
                string[] words = txtElements.Text.Replace("��", ",").Split(',');

                using (PdfDocument pdfDocument = new PdfDocument(filePath))
                {
                    foreach (PdfPageBase page in pdfDocument.Pages)
                    {
                        PdfTextReplacer ptr = new PdfTextReplacer(page);

                        foreach (var word in words)
                        {
                            ptr.ReplaceAllText(word, string.IsNullOrEmpty(txt_new_text.Text) ? new string(character, word.Length) : txt_new_text.Text);
                        }
                    }
                    filePath = GenerateUniqueFileName(filePath);
                    pdfDocument.SaveToFile(filePath);
                }
                MessageBox.Show("�����滻Ҫ�سɹ��滻��ϣ�", "PDF�滻", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("����PDF�ļ�ʱ�������⣬ԭ��Ϊ��\r\n" + ex.Message, "PDF�滻", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                SetButtonEnable(true);
            }
        }

        private List<string> ExtractMatches(string text, params string[] patterns)
        {
            List<string> matches = new List<string>();
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

        private void SetButtonEnable(Boolean state)
        {
            cmdBrowsePDF.Enabled = state;
            cmdClose.Enabled = state;
            txtElements.Enabled = state;
            cmdExcuse.Enabled = state ? !string.IsNullOrEmpty(txtElements.Text) : state;
        }

        private void PhotoMosaic(string filePath, int x, int y, int w, int h)
        {
            // ���ر���ͼƬ��Ҫ���ǵ�ͼƬ
            Image backgroundImage = Image.FromFile(filePath);

            // ����һ���µ�λͼ�����ڴ洢���ͼƬ
            using (Graphics g = Graphics.FromImage(new Bitmap(backgroundImage.Width, backgroundImage.Height)))
            {
                // ���Ʊ���ͼƬ
                g.DrawImage(backgroundImage, 0, 0, backgroundImage.Width, backgroundImage.Height);

                g.DrawRectangle(Pens.DarkGray, x, y, w, h);
            }

            // ������ͼƬ
            backgroundImage.Save("result.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private string GetMatchedText(string text, string startKey, string endKey)
        {
            int startIndex = text.IndexOf(startKey);
            return (startIndex == -1) ? string.Empty : text.Substring(startIndex + startKey.Length, text.IndexOf(endKey, startIndex) - startIndex - startKey.Length).Trim();
        }
    }
}