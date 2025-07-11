namespace CarReportSystem {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtDate = new DateTimePicker();
            cbCarName = new ComboBox();
            rbOther = new PictureBox();
            rbToyota = new RadioButton();
            rbNissan = new RadioButton();
            rbSubaru = new RadioButton();
            rbSuzuki = new RadioButton();
            rbYunyusya = new RadioButton();
            rbSonota = new RadioButton();
            tbReport = new TextBox();
            cbAuthor = new ComboBox();
            dgvRecord = new DataGridView();
            bt1 = new Button();
            bt2 = new Button();
            btRecordAdd = new Button();
            btRecordModify = new Button();
            btRecordDelete = new Button();
            pbPicture = new PictureBox();
            ofdPicFileOpen = new OpenFileDialog();
            button1 = new Button();
            ssMessageAria = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            tsmiExit = new ToolStripMenuItem();
            編集EToolStripMenuItem = new ToolStripMenuItem();
            元に戻すToolStripMenuItem = new ToolStripMenuItem();
            地獄送りToolStripMenuItem = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            tsmiAbout = new ToolStripMenuItem();
            cdColor = new ColorDialog();
            sfdReportFileOpen = new OpenFileDialog();
            sfdReportFileSave = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)rbOther).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ssMessageAria.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("游明朝", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(33, 37);
            label1.Name = "label1";
            label1.Size = new Size(54, 27);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("游明朝", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(33, 96);
            label2.Name = "label2";
            label2.Size = new Size(75, 27);
            label2.TabIndex = 0;
            label2.Text = "記録者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("游明朝", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(33, 159);
            label3.Name = "label3";
            label3.Size = new Size(96, 27);
            label3.TabIndex = 0;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("游明朝", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(33, 217);
            label4.Name = "label4";
            label4.Size = new Size(54, 27);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("游明朝", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(33, 290);
            label5.Name = "label5";
            label5.Size = new Size(96, 27);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("游明朝", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(33, 426);
            label6.Name = "label6";
            label6.Size = new Size(54, 27);
            label6.TabIndex = 0;
            label6.Text = "一覧";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("游明朝", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(583, 70);
            label7.Name = "label7";
            label7.Size = new Size(54, 27);
            label7.TabIndex = 0;
            label7.Text = "画像";
            // 
            // dtDate
            // 
            dtDate.Location = new Point(149, 37);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(197, 23);
            dtDate.TabIndex = 1;
            dtDate.ValueChanged += dtPicker_ValueChanged;
            // 
            // cbCarName
            // 
            cbCarName.FormattingEnabled = true;
            cbCarName.ItemHeight = 15;
            cbCarName.Location = new Point(149, 217);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(197, 23);
            cbCarName.TabIndex = 2;
            cbCarName.SelectedIndexChanged += cbCarName_SelectedIndexChanged;
            // 
            // rbOther
            // 
            rbOther.Location = new Point(149, 147);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(381, 48);
            rbOther.TabIndex = 3;
            rbOther.TabStop = false;
            rbOther.Click += pictureBox1_Click;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(164, 159);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 4;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            rbToyota.CheckedChanged += rbToyota_CheckedChanged;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(220, 159);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 5;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(275, 159);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 6;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbSuzuki
            // 
            rbSuzuki.AutoSize = true;
            rbSuzuki.Location = new Point(335, 159);
            rbSuzuki.Name = "rbSuzuki";
            rbSuzuki.Size = new Size(52, 19);
            rbSuzuki.TabIndex = 7;
            rbSuzuki.TabStop = true;
            rbSuzuki.Text = "スズキ";
            rbSuzuki.UseVisualStyleBackColor = true;
            // 
            // rbYunyusya
            // 
            rbYunyusya.AutoSize = true;
            rbYunyusya.Location = new Point(393, 159);
            rbYunyusya.Name = "rbYunyusya";
            rbYunyusya.Size = new Size(61, 19);
            rbYunyusya.TabIndex = 8;
            rbYunyusya.TabStop = true;
            rbYunyusya.Text = "輸入車";
            rbYunyusya.UseVisualStyleBackColor = true;
            // 
            // rbSonota
            // 
            rbSonota.AutoSize = true;
            rbSonota.Location = new Point(460, 159);
            rbSonota.Name = "rbSonota";
            rbSonota.Size = new Size(56, 19);
            rbSonota.TabIndex = 9;
            rbSonota.TabStop = true;
            rbSonota.Text = "その他";
            rbSonota.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(149, 273);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(381, 98);
            tbReport.TabIndex = 10;
            tbReport.TextChanged += tbReport_TextChanged;
            // 
            // cbAuthor
            // 
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(149, 96);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(197, 23);
            cbAuthor.TabIndex = 2;
            cbAuthor.SelectedIndexChanged += cbAuthor_SelectedIndexChanged;
            // 
            // dgvRecord
            // 
            dgvRecord.AllowUserToAddRows = false;
            dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecord.Location = new Point(149, 406);
            dgvRecord.MultiSelect = false;
            dgvRecord.Name = "dgvRecord";
            dgvRecord.ReadOnly = true;
            dgvRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecord.Size = new Size(630, 161);
            dgvRecord.TabIndex = 11;
            dgvRecord.CellContentClick += dgvRecord_CellContentClick;
            dgvRecord.Click += dgvRecord_Click;
            // 
            // bt1
            // 
            bt1.AllowDrop = true;
            bt1.Location = new Point(831, 74);
            bt1.Name = "bt1";
            bt1.Size = new Size(75, 23);
            bt1.TabIndex = 12;
            bt1.Text = "開く...";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(912, 74);
            bt2.Name = "bt2";
            bt2.Size = new Size(75, 23);
            bt2.TabIndex = 12;
            bt2.Text = "削除";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // btRecordAdd
            // 
            btRecordAdd.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRecordAdd.Location = new Point(639, 317);
            btRecordAdd.Name = "btRecordAdd";
            btRecordAdd.Size = new Size(112, 60);
            btRecordAdd.TabIndex = 12;
            btRecordAdd.Text = "追加";
            btRecordAdd.UseVisualStyleBackColor = true;
            btRecordAdd.Click += btRecordAdd_Click;
            // 
            // btRecordModify
            // 
            btRecordModify.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRecordModify.Location = new Point(757, 317);
            btRecordModify.Name = "btRecordModify";
            btRecordModify.Size = new Size(112, 60);
            btRecordModify.TabIndex = 12;
            btRecordModify.Text = "修正";
            btRecordModify.UseVisualStyleBackColor = true;
            btRecordModify.Click += btRecordModify_Click;
            // 
            // btRecordDelete
            // 
            btRecordDelete.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRecordDelete.Location = new Point(875, 317);
            btRecordDelete.Name = "btRecordDelete";
            btRecordDelete.Size = new Size(112, 60);
            btRecordDelete.TabIndex = 12;
            btRecordDelete.Text = "削除";
            btRecordDelete.UseVisualStyleBackColor = true;
            btRecordDelete.Click += btRecordDelete_Click;
            // 
            // pbPicture
            // 
            pbPicture.Location = new Point(628, 103);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(359, 211);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 13;
            pbPicture.TabStop = false;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(372, 33);
            button1.Name = "button1";
            button1.Size = new Size(103, 38);
            button1.TabIndex = 14;
            button1.Text = "新規登録";
            button1.UseVisualStyleBackColor = true;
            // 
            // ssMessageAria
            // 
            ssMessageAria.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            ssMessageAria.Location = new Point(0, 580);
            ssMessageAria.Name = "ssMessageAria";
            ssMessageAria.Size = new Size(1011, 22);
            ssMessageAria.TabIndex = 15;
            ssMessageAria.Text = "statusStrip1";
            ssMessageAria.ItemClicked += tllsbMessage_ItemClicked;
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, 編集EToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1011, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 保存ToolStripMenuItem, 開くToolStripMenuItem, toolStripSeparator1, 色設定ToolStripMenuItem, tsmiExit });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            ファイルFToolStripMenuItem.Click += ファイルFToolStripMenuItem_Click;
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(180, 22);
            保存ToolStripMenuItem.Text = "保存...";
            保存ToolStripMenuItem.Click += 保存ToolStripMenuItem_Click;
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(180, 22);
            開くToolStripMenuItem.Text = "開く...";
            開くToolStripMenuItem.Click += 開くToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.BackColor = SystemColors.Control;
            色設定ToolStripMenuItem.ForeColor = SystemColors.ControlDarkDark;
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(180, 22);
            色設定ToolStripMenuItem.Text = "色設定";
            色設定ToolStripMenuItem.Click += 色設定ToolStripMenuItem_Click;
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.ShortcutKeys = Keys.Alt | Keys.F4;
            tsmiExit.Size = new Size(180, 22);
            tsmiExit.Text = "終了";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // 編集EToolStripMenuItem
            // 
            編集EToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 元に戻すToolStripMenuItem, 地獄送りToolStripMenuItem });
            編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            編集EToolStripMenuItem.Size = new Size(57, 20);
            編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 元に戻すToolStripMenuItem
            // 
            元に戻すToolStripMenuItem.Name = "元に戻すToolStripMenuItem";
            元に戻すToolStripMenuItem.Size = new Size(118, 22);
            元に戻すToolStripMenuItem.Text = "元に戻す";
            // 
            // 地獄送りToolStripMenuItem
            // 
            地獄送りToolStripMenuItem.Name = "地獄送りToolStripMenuItem";
            地獄送りToolStripMenuItem.Size = new Size(118, 22);
            地獄送りToolStripMenuItem.Text = "地獄送り";
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiAbout });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(65, 20);
            ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // tsmiAbout
            // 
            tsmiAbout.Name = "tsmiAbout";
            tsmiAbout.Size = new Size(170, 22);
            tsmiAbout.Text = "このアプリについて.....";
            tsmiAbout.Click += tsmi_Click;
            // 
            // sfdReportFileOpen
            // 
            sfdReportFileOpen.FileName = "openFileDialog1";
            sfdReportFileOpen.FileOk += sfdReportFSave_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1011, 602);
            Controls.Add(ssMessageAria);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            Controls.Add(pbPicture);
            Controls.Add(bt2);
            Controls.Add(btRecordDelete);
            Controls.Add(btRecordModify);
            Controls.Add(btRecordAdd);
            Controls.Add(bt1);
            Controls.Add(dgvRecord);
            Controls.Add(tbReport);
            Controls.Add(rbSonota);
            Controls.Add(rbYunyusya);
            Controls.Add(rbSuzuki);
            Controls.Add(rbSubaru);
            Controls.Add(rbNissan);
            Controls.Add(rbToyota);
            Controls.Add(rbOther);
            Controls.Add(cbAuthor);
            Controls.Add(cbCarName);
            Controls.Add(dtDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)rbOther).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ssMessageAria.ResumeLayout(false);
            ssMessageAria.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtDate;
        private ComboBox cbCarName;
        private PictureBox rbOther;
        private RadioButton rbToyota;
        private RadioButton rbNissan;
        private RadioButton rbSubaru;
        private RadioButton rbSuzuki;
        private RadioButton rbYunyusya;
        private RadioButton rbSonota;
        private TextBox tbReport;
        private ComboBox cbAuthor;
        private DataGridView dgvRecord;
        private Button bt1;
        private Button bt2;
        private Button btRecordAdd;
        private Button btRecordModify;
        private Button btRecordDelete;
        private PictureBox pbPicture;
        private OpenFileDialog ofdPicFileOpen;
        private Button setCbAuthor;
        private Button button1;
        private StatusStrip ssMessageAria;
        private ToolStripStatusLabel tsslbMessage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 編集EToolStripMenuItem;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem tsmiAbout;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem 元に戻すToolStripMenuItem;
        private ToolStripMenuItem 地獄送りToolStripMenuItem;
        private ColorDialog cdColor;
        private OpenFileDialog sfdReportFileOpen;
        private SaveFileDialog sfdReportFileSave;
    }
}
