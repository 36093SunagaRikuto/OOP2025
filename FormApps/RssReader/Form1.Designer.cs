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
            wvRssLink = new Microsoft.Web.WebView2.WinForms.WebView2();
            back = new Button();
            go = new Button();
            cbBox = new ComboBox();
            byfavorite = new Button();
            label2 = new Label();
            btRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)wvRssLink).BeginInit();
            SuspendLayout();
            // 
            // tburl
            // 
            tburl.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tburl.Location = new Point(232, 30);
            tburl.Name = "tburl";
            tburl.Size = new Size(424, 35);
            tburl.TabIndex = 0;
            tburl.TextChanged += tburl_TextChanged;
            // 
            // btRssGet
            // 
            btRssGet.Location = new Point(650, 82);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(104, 33);
            btRssGet.TabIndex = 1;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = true;
            btRssGet.Click += btRssGet_Click;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitles.DrawMode = DrawMode.OwnerDrawFixed;
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 15;
            lbTitles.Location = new Point(35, 124);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(765, 154);
            lbTitles.TabIndex = 2;
            lbTitles.Click += lbTitles_Click;
            lbTitles.DrawItem += lbTitles_DrawItem;
            lbTitles.SelectedIndexChanged += lbTitles_SelectedIndexChanged_1;
            // 
            // wvRssLink
            // 
            wvRssLink.AllowExternalDrop = true;
            wvRssLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wvRssLink.CreationProperties = null;
            wvRssLink.DefaultBackgroundColor = Color.White;
            wvRssLink.Location = new Point(35, 284);
            wvRssLink.Name = "wvRssLink";
            wvRssLink.Size = new Size(765, 354);
            wvRssLink.TabIndex = 3;
            wvRssLink.ZoomFactor = 1D;
            wvRssLink.NavigationStarting += wvRssLink_NavigationStarting;
            wvRssLink.SourceChanged += wvRssLink_SourceChanged;
            // 
            // back
            // 
            back.AutoEllipsis = true;
            back.Enabled = false;
            back.Location = new Point(16, 9);
            back.Name = "back";
            back.Size = new Size(36, 24);
            back.TabIndex = 4;
            back.Text = "戻る";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // go
            // 
            go.Location = new Point(49, 9);
            go.Name = "go";
            go.Size = new Size(45, 24);
            go.TabIndex = 4;
            go.Text = "進み";
            go.UseVisualStyleBackColor = true;
            go.Click += go_Click;
            // 
            // cbBox
            // 
            cbBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbBox.FormattingEnabled = true;
            cbBox.Location = new Point(232, 82);
            cbBox.Name = "cbBox";
            cbBox.Size = new Size(424, 33);
            cbBox.TabIndex = 5;
            cbBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // byfavorite
            // 
            byfavorite.Location = new Point(650, 30);
            byfavorite.Name = "byfavorite";
            byfavorite.Size = new Size(104, 35);
            byfavorite.TabIndex = 6;
            byfavorite.Text = "お気に入り登録";
            byfavorite.UseVisualStyleBackColor = true;
            byfavorite.Click += byfavorite_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(5, 35);
            label2.Name = "label2";
            label2.Size = new Size(228, 25);
            label2.TabIndex = 7;
            label2.Text = "URLまたはお気に入り登録：";
            label2.Click += label2_Click;
            // 
            // btRemove
            // 
            btRemove.Location = new Point(750, 30);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(67, 35);
            btRemove.TabIndex = 8;
            btRemove.Text = "削除";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 650);
            Controls.Add(btRemove);
            Controls.Add(label2);
            Controls.Add(byfavorite);
            Controls.Add(cbBox);
            Controls.Add(go);
            Controls.Add(back);
            Controls.Add(wvRssLink);
            Controls.Add(lbTitles);
            Controls.Add(btRssGet);
            Controls.Add(tburl);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "　　";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)wvRssLink).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tburl;
        private Button btRssGet;
        private ListBox lbTitles;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvRssLink;
        private Button back;
        private Button go;
        private ComboBox cbBox;
        private Button byfavorite;
        private Label label2;
        private Button btRemove;
    }
}
