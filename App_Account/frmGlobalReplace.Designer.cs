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
            this.cmdExcuse = new System.Windows.Forms.Button();
            this.lbl_policy_holder = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cltButton = new System.Windows.Forms.ToolTip(this.components);
            this.cmdBrowsePDF = new System.Windows.Forms.Button();
            this.txt_new_text = new System.Windows.Forms.TextBox();
            this.lbl_PDF = new System.Windows.Forms.Label();
            this.txt_Selected_PDF_Path = new System.Windows.Forms.TextBox();
            this.openDataCab = new System.Windows.Forms.OpenFileDialog();
            this.txtElements = new System.Windows.Forms.TextBox();
            this.lblNewText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdExcuse
            // 
            this.cmdExcuse.Enabled = false;
            this.cmdExcuse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdExcuse.Location = new System.Drawing.Point(325, 253);
            this.cmdExcuse.Name = "cmdExcuse";
            this.cmdExcuse.Size = new System.Drawing.Size(76, 36);
            this.cmdExcuse.TabIndex = 8;
            this.cmdExcuse.Text = "替换";
            this.cmdExcuse.UseVisualStyleBackColor = true;
            this.cmdExcuse.Click += new System.EventHandler(this.cmdExcuse_Click);
            // 
            // lbl_policy_holder
            // 
            this.lbl_policy_holder.AutoSize = true;
            this.lbl_policy_holder.BackColor = System.Drawing.Color.Transparent;
            this.lbl_policy_holder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_policy_holder.ForeColor = System.Drawing.Color.White;
            this.lbl_policy_holder.Location = new System.Drawing.Point(17, 107);
            this.lbl_policy_holder.Name = "lbl_policy_holder";
            this.lbl_policy_holder.Size = new System.Drawing.Size(68, 17);
            this.lbl_policy_holder.TabIndex = 4;
            this.lbl_policy_holder.Text = "替换要素：";
            // 
            // cmdClose
            // 
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdClose.Location = new System.Drawing.Point(416, 253);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(76, 36);
            this.cmdClose.TabIndex = 9;
            this.cmdClose.Text = "关闭";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdBrowsePDF
            // 
            this.cmdBrowsePDF.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdBrowsePDF.Image = global::App_Account.Properties.Resources.document_type_pdf;
            this.cmdBrowsePDF.Location = new System.Drawing.Point(460, 64);
            this.cmdBrowsePDF.Name = "cmdBrowsePDF";
            this.cmdBrowsePDF.Size = new System.Drawing.Size(32, 32);
            this.cmdBrowsePDF.TabIndex = 3;
            this.cltButton.SetToolTip(this.cmdBrowsePDF, "选择PDf");
            this.cmdBrowsePDF.UseVisualStyleBackColor = true;
            this.cmdBrowsePDF.Click += new System.EventHandler(this.cmdBrowsePDF_Click);
            // 
            // txt_new_text
            // 
            this.txt_new_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_new_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_new_text.Location = new System.Drawing.Point(83, 212);
            this.txt_new_text.Name = "txt_new_text";
            this.txt_new_text.Size = new System.Drawing.Size(204, 23);
            this.txt_new_text.TabIndex = 7;
            // 
            // lbl_PDF
            // 
            this.lbl_PDF.AutoSize = true;
            this.lbl_PDF.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PDF.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PDF.ForeColor = System.Drawing.Color.White;
            this.lbl_PDF.Location = new System.Drawing.Point(17, 72);
            this.lbl_PDF.Name = "lbl_PDF";
            this.lbl_PDF.Size = new System.Drawing.Size(66, 17);
            this.lbl_PDF.TabIndex = 1;
            this.lbl_PDF.Text = "PDF文件：";
            // 
            // txt_Selected_PDF_Path
            // 
            this.txt_Selected_PDF_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Selected_PDF_Path.Enabled = false;
            this.txt_Selected_PDF_Path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Selected_PDF_Path.Location = new System.Drawing.Point(83, 69);
            this.txt_Selected_PDF_Path.Name = "txt_Selected_PDF_Path";
            this.txt_Selected_PDF_Path.ReadOnly = true;
            this.txt_Selected_PDF_Path.Size = new System.Drawing.Size(371, 23);
            this.txt_Selected_PDF_Path.TabIndex = 2;
            // 
            // txtElements
            // 
            this.txtElements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtElements.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtElements.Location = new System.Drawing.Point(83, 103);
            this.txtElements.Multiline = true;
            this.txtElements.Name = "txtElements";
            this.txtElements.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtElements.Size = new System.Drawing.Size(371, 98);
            this.txtElements.TabIndex = 5;
            this.txtElements.TextChanged += new System.EventHandler(this.txtElements_TextChanged);
            // 
            // lblNewText
            // 
            this.lblNewText.AutoSize = true;
            this.lblNewText.BackColor = System.Drawing.Color.Transparent;
            this.lblNewText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewText.ForeColor = System.Drawing.Color.White;
            this.lblNewText.Location = new System.Drawing.Point(17, 215);
            this.lblNewText.Name = "lblNewText";
            this.lblNewText.Size = new System.Drawing.Size(56, 17);
            this.lblNewText.TabIndex = 6;
            this.lblNewText.Text = "替换为：";
            // 
            // frmGlobalReplace
            // 
            this.AcceptButton = this.cmdExcuse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(513, 304);
            this.Controls.Add(this.txtElements);
            this.Controls.Add(this.txt_new_text);
            this.Controls.Add(this.txt_Selected_PDF_Path);
            this.Controls.Add(this.cmdBrowsePDF);
            this.Controls.Add(this.lbl_PDF);
            this.Controls.Add(this.cmdExcuse);
            this.Controls.Add(this.lblNewText);
            this.Controls.Add(this.lbl_policy_holder);
            this.Controls.Add(this.cmdClose);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGlobalReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF关键字替换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExcuse;
        private System.Windows.Forms.Label lbl_policy_holder;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.ToolTip cltButton;
        private System.Windows.Forms.TextBox txt_new_text;
        private System.Windows.Forms.Button cmdBrowsePDF;
        private System.Windows.Forms.Label lbl_PDF;
        private System.Windows.Forms.TextBox txt_Selected_PDF_Path;
        private System.Windows.Forms.OpenFileDialog openDataCab;
        private System.Windows.Forms.TextBox txtElements;
        private System.Windows.Forms.Label lblNewText;
    }
}