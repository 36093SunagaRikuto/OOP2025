namespace RssReader {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tburl = new TextBox();
            btRssGet = new Button();
            lbTitles = new ListBox();
            SuspendLayout();
            // 
            // tburl
            // 
            tburl.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tburl.Location = new Point(35, 22);
            tburl.Name = "tburl";
            tburl.Size = new Size(424, 35);
            tburl.TabIndex = 0;
            // 
            // btRssGet
            // 
            btRssGet.Location = new Point(455, 22);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(104, 35);
            btRssGet.TabIndex = 1;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = true;
            btRssGet.Click += btRssGet_Click;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 15;
            lbTitles.Location = new Point(35, 64);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(524, 349);
            lbTitles.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTitles);
            Controls.Add(btRssGet);
            Controls.Add(tburl);
            Name = "Form1";
            Text = "RSSリーダー";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tburl;
        private Button btRssGet;
        private ListBox lbTitles;
    }
}
