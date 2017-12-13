namespace Text2Voice
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Conversion = new System.Windows.Forms.Button();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.tipInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(8, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(373, 58);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Conversion
            // 
            this.Conversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conversion.Location = new System.Drawing.Point(131, 67);
            this.Conversion.Name = "Conversion";
            this.Conversion.Size = new System.Drawing.Size(117, 38);
            this.Conversion.TabIndex = 1;
            this.Conversion.Text = "Conversion";
            this.Conversion.UseVisualStyleBackColor = true;
            this.Conversion.Click += new System.EventHandler(this.Conversion_Click);
            // 
            // OpenFolder
            // 
            this.OpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFolder.Location = new System.Drawing.Point(8, 67);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(117, 38);
            this.OpenFolder.TabIndex = 2;
            this.OpenFolder.Text = "Open Folder";
            this.OpenFolder.UseVisualStyleBackColor = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // tipInfo
            // 
            this.tipInfo.AutoSize = true;
            this.tipInfo.Location = new System.Drawing.Point(10, 120);
            this.tipInfo.Name = "tipInfo";
            this.tipInfo.Size = new System.Drawing.Size(47, 12);
            this.tipInfo.TabIndex = 3;
            this.tipInfo.Text = "Welcome";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 141);
            this.Controls.Add(this.tipInfo);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.Conversion);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text2Voice";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Conversion;
        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.Label tipInfo;
    }
}

