namespace App_Account
{
    partial class frmGlobalReplace
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlobalReplace));
            this.cltButton = new System.Windows.Forms.ToolTip(this.components);
            this.cmdBrowsePDF = new System.Windows.Forms.Button();
            this.cmdSelectFolder = new System.Windows.Forms.Button();
            this.openDataCab = new System.Windows.Forms.OpenFileDialog();
            this.fbdRootPath = new System.Windows.Forms.FolderBrowserDialog();
            this.tabFunctionSelect = new System.Windows.Forms.TabControl();
            this.tpKeywordReplace = new System.Windows.Forms.TabPage();
            this.txtElements = new System.Windows.Forms.TextBox();
            this.txt_new_text = new System.Windows.Forms.TextBox();
            this.txt_Selected_PDF_Path = new System.Windows.Forms.TextBox();
            this.lbl_PDF = new System.Windows.Forms.Label();
            this.cmdExcuse = new System.Windows.Forms.Button();
            this.lblNewText = new System.Windows.Forms.Label();
            this.lbl_policy_holder = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.tpGeneratePDFByImages = new System.Windows.Forms.TabPage();
            this.lblProcess = new System.Windows.Forms.Label();
            this.pgbOutput = new System.Windows.Forms.ProgressBar();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmdBatchConvert = new System.Windows.Forms.Button();
            this.backgroundWorkerUI = new System.ComponentModel.BackgroundWorker();
            this.tabFunctionSelect.SuspendLayout();
            this.tpKeywordReplace.SuspendLayout();
            this.tpGeneratePDFByImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdBrowsePDF
            // 
            this.cmdBrowsePDF.FlatAppearance.BorderSize = 0;
            this.cmdBrowsePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBrowsePDF.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdBrowsePDF.Image = ((System.Drawing.Image)(resources.GetObject("cmdBrowsePDF.Image")));
            this.cmdBrowsePDF.Location = new System.Drawing.Point(458, 21);
            this.cmdBrowsePDF.Name = "cmdBrowsePDF";
            this.cmdBrowsePDF.Size = new System.Drawing.Size(32, 32);
            this.cmdBrowsePDF.TabIndex = 13;
            this.cltButton.SetToolTip(this.cmdBrowsePDF, "选择PDf");
            this.cmdBrowsePDF.UseVisualStyleBackColor = true;
            this.cmdBrowsePDF.Click += new System.EventHandler(this.cmdBrowsePDF_Click);
            // 
            // cmdSelectFolder
            // 
            this.cmdSelectFolder.FlatAppearance.BorderSize = 0;
            this.cmdSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSelectFolder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdSelectFolder.Image = ((System.Drawing.Image)(resources.GetObject("cmdSelectFolder.Image")));
            this.cmdSelectFolder.Location = new System.Drawing.Point(457, 21);
            this.cmdSelectFolder.Name = "cmdSelectFolder";
            this.cmdSelectFolder.Size = new System.Drawing.Size(32, 32);
            this.cmdSelectFolder.TabIndex = 24;
            this.cltButton.SetToolTip(this.cmdSelectFolder, "选择图片所在根目录");
            this.cmdSelectFolder.UseVisualStyleBackColor = true;
            this.cmdSelectFolder.Click += new System.EventHandler(this.cmdSelectFolder_Click);
            // 
            // tabFunctionSelect
            // 
            this.tabFunctionSelect.Controls.Add(this.tpKeywordReplace);
            this.tabFunctionSelect.Controls.Add(this.tpGeneratePDFByImages);
            this.tabFunctionSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabFunctionSelect.Location = new System.Drawing.Point(0, 0);
            this.tabFunctionSelect.Name = "tabFunctionSelect";
            this.tabFunctionSelect.SelectedIndex = 0;
            this.tabFunctionSelect.Size = new System.Drawing.Size(513, 304);
            this.tabFunctionSelect.TabIndex = 11;
            // 
            // tpKeywordReplace
            // 
            this.tpKeywordReplace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpKeywordReplace.BackgroundImage")));
            this.tpKeywordReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpKeywordReplace.Controls.Add(this.txtElements);
            this.tpKeywordReplace.Controls.Add(this.txt_new_text);
            this.tpKeywordReplace.Controls.Add(this.txt_Selected_PDF_Path);
            this.tpKeywordReplace.Controls.Add(this.cmdBrowsePDF);
            this.tpKeywordReplace.Controls.Add(this.lbl_PDF);
            this.tpKeywordReplace.Controls.Add(this.cmdExcuse);
            this.tpKeywordReplace.Controls.Add(this.lblNewText);
            this.tpKeywordReplace.Controls.Add(this.lbl_policy_holder);
            this.tpKeywordReplace.Controls.Add(this.cmdClose);
            this.tpKeywordReplace.Location = new System.Drawing.Point(4, 26);
            this.tpKeywordReplace.Name = "tpKeywordReplace";
            this.tpKeywordReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tpKeywordReplace.Size = new System.Drawing.Size(505, 274);
            this.tpKeywordReplace.TabIndex = 0;
            this.tpKeywordReplace.Text = "PDF关键字替换";
            this.tpKeywordReplace.UseVisualStyleBackColor = true;
            // 
            // txtElements
            // 
            this.txtElements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtElements.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtElements.Location = new System.Drawing.Point(81, 70);
            this.txtElements.Multiline = true;
            this.txtElements.Name = "txtElements";
            this.txtElements.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtElements.Size = new System.Drawing.Size(371, 98);
            this.txtElements.TabIndex = 15;
            this.txtElements.TextChanged += new System.EventHandler(this.txtElements_TextChanged);
            // 
            // txt_new_text
            // 
            this.txt_new_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_new_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_new_text.Location = new System.Drawing.Point(81, 180);
            this.txt_new_text.Name = "txt_new_text";
            this.txt_new_text.Size = new System.Drawing.Size(204, 23);
            this.txt_new_text.TabIndex = 17;
            // 
            // txt_Selected_PDF_Path
            // 
            this.txt_Selected_PDF_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Selected_PDF_Path.Enabled = false;
            this.txt_Selected_PDF_Path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Selected_PDF_Path.Location = new System.Drawing.Point(81, 26);
            this.txt_Selected_PDF_Path.Name = "txt_Selected_PDF_Path";
            this.txt_Selected_PDF_Path.ReadOnly = true;
            this.txt_Selected_PDF_Path.Size = new System.Drawing.Size(371, 23);
            this.txt_Selected_PDF_Path.TabIndex = 12;
            // 
            // lbl_PDF
            // 
            this.lbl_PDF.AutoSize = true;
            this.lbl_PDF.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PDF.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PDF.ForeColor = System.Drawing.Color.White;
            this.lbl_PDF.Location = new System.Drawing.Point(15, 29);
            this.lbl_PDF.Name = "lbl_PDF";
            this.lbl_PDF.Size = new System.Drawing.Size(66, 17);
            this.lbl_PDF.TabIndex = 11;
            this.lbl_PDF.Text = "PDF文件：";
            // 
            // cmdExcuse
            // 
            this.cmdExcuse.Enabled = false;
            this.cmdExcuse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdExcuse.Location = new System.Drawing.Point(323, 228);
            this.cmdExcuse.Name = "cmdExcuse";
            this.cmdExcuse.Size = new System.Drawing.Size(76, 36);
            this.cmdExcuse.TabIndex = 18;
            this.cmdExcuse.Text = "替换";
            this.cmdExcuse.UseVisualStyleBackColor = true;
            this.cmdExcuse.Click += new System.EventHandler(this.cmdExcuse_Click);
            // 
            // lblNewText
            // 
            this.lblNewText.AutoSize = true;
            this.lblNewText.BackColor = System.Drawing.Color.Transparent;
            this.lblNewText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewText.ForeColor = System.Drawing.Color.White;
            this.lblNewText.Location = new System.Drawing.Point(15, 183);
            this.lblNewText.Name = "lblNewText";
            this.lblNewText.Size = new System.Drawing.Size(56, 17);
            this.lblNewText.TabIndex = 16;
            this.lblNewText.Text = "替换为：";
            // 
            // lbl_policy_holder
            // 
            this.lbl_policy_holder.AutoSize = true;
            this.lbl_policy_holder.BackColor = System.Drawing.Color.Transparent;
            this.lbl_policy_holder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_policy_holder.ForeColor = System.Drawing.Color.White;
            this.lbl_policy_holder.Location = new System.Drawing.Point(15, 74);
            this.lbl_policy_holder.Name = "lbl_policy_holder";
            this.lbl_policy_holder.Size = new System.Drawing.Size(68, 17);
            this.lbl_policy_holder.TabIndex = 14;
            this.lbl_policy_holder.Text = "替换要素：";
            // 
            // cmdClose
            // 
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdClose.Location = new System.Drawing.Point(414, 228);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(76, 36);
            this.cmdClose.TabIndex = 19;
            this.cmdClose.Text = "关闭";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // tpGeneratePDFByImages
            // 
            this.tpGeneratePDFByImages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpGeneratePDFByImages.BackgroundImage")));
            this.tpGeneratePDFByImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpGeneratePDFByImages.Controls.Add(this.lblProcess);
            this.tpGeneratePDFByImages.Controls.Add(this.pgbOutput);
            this.tpGeneratePDFByImages.Controls.Add(this.txtFolder);
            this.tpGeneratePDFByImages.Controls.Add(this.cmdSelectFolder);
            this.tpGeneratePDFByImages.Controls.Add(this.lblFolder);
            this.tpGeneratePDFByImages.Controls.Add(this.cmdBatchConvert);
            this.tpGeneratePDFByImages.Location = new System.Drawing.Point(4, 26);
            this.tpGeneratePDFByImages.Name = "tpGeneratePDFByImages";
            this.tpGeneratePDFByImages.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneratePDFByImages.Size = new System.Drawing.Size(505, 274);
            this.tpGeneratePDFByImages.TabIndex = 1;
            this.tpGeneratePDFByImages.Text = "图片生成PDF";
            this.tpGeneratePDFByImages.UseVisualStyleBackColor = true;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.BackColor = System.Drawing.Color.Transparent;
            this.lblProcess.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProcess.ForeColor = System.Drawing.Color.White;
            this.lblProcess.Location = new System.Drawing.Point(0, 234);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(68, 17);
            this.lblProcess.TabIndex = 17;
            this.lblProcess.Text = "正在处理：";
            this.lblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProcess.Visible = false;
            // 
            // pgbOutput
            // 
            this.pgbOutput.Location = new System.Drawing.Point(0, 254);
            this.pgbOutput.Name = "pgbOutput";
            this.pgbOutput.Size = new System.Drawing.Size(505, 20);
            this.pgbOutput.Step = 1;
            this.pgbOutput.TabIndex = 25;
            this.pgbOutput.Visible = false;
            // 
            // txtFolder
            // 
            this.txtFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolder.Enabled = false;
            this.txtFolder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFolder.Location = new System.Drawing.Point(88, 26);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(363, 23);
            this.txtFolder.TabIndex = 23;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.BackColor = System.Drawing.Color.Transparent;
            this.lblFolder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFolder.ForeColor = System.Drawing.Color.White;
            this.lblFolder.Location = new System.Drawing.Point(14, 29);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(80, 17);
            this.lblFolder.TabIndex = 22;
            this.lblFolder.Text = "图片文件夹：";
            // 
            // cmdBatchConvert
            // 
            this.cmdBatchConvert.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdBatchConvert.Location = new System.Drawing.Point(204, 119);
            this.cmdBatchConvert.Name = "cmdBatchConvert";
            this.cmdBatchConvert.Size = new System.Drawing.Size(96, 36);
            this.cmdBatchConvert.TabIndex = 21;
            this.cmdBatchConvert.Text = "批量生成";
            this.cmdBatchConvert.UseVisualStyleBackColor = true;
            this.cmdBatchConvert.Click += new System.EventHandler(this.cmdBatchConvert_Click);
            // 
            // backgroundWorkerUI
            // 
            this.backgroundWorkerUI.WorkerReportsProgress = true;
            this.backgroundWorkerUI.WorkerSupportsCancellation = true;
            this.backgroundWorkerUI.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUI_DoWork);
            this.backgroundWorkerUI.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUI_RunWorkerCompleted);
            // 
            // frmGlobalReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(513, 304);
            this.Controls.Add(this.tabFunctionSelect);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGlobalReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF处理小程序";
            this.tabFunctionSelect.ResumeLayout(false);
            this.tpKeywordReplace.ResumeLayout(false);
            this.tpKeywordReplace.PerformLayout();
            this.tpGeneratePDFByImages.ResumeLayout(false);
            this.tpGeneratePDFByImages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip cltButton;
        private System.Windows.Forms.OpenFileDialog openDataCab;
        private System.Windows.Forms.FolderBrowserDialog fbdRootPath;
        private System.Windows.Forms.TabControl tabFunctionSelect;
        private System.Windows.Forms.TabPage tpKeywordReplace;
        private System.Windows.Forms.TabPage tpGeneratePDFByImages;
        private System.Windows.Forms.TextBox txtElements;
        private System.Windows.Forms.TextBox txt_new_text;
        private System.Windows.Forms.TextBox txt_Selected_PDF_Path;
        private System.Windows.Forms.Button cmdBrowsePDF;
        private System.Windows.Forms.Label lbl_PDF;
        private System.Windows.Forms.Button cmdExcuse;
        private System.Windows.Forms.Label lblNewText;
        private System.Windows.Forms.Label lbl_policy_holder;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdBatchConvert;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button cmdSelectFolder;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.ProgressBar pgbOutput;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUI;
        private System.Windows.Forms.Label lblProcess;
    }
}