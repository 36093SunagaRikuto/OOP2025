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
            dtPicker = new DateTimePicker();
            cbCarName = new ComboBox();
            pictureBox1 = new PictureBox();
            rbToyota = new RadioButton();
            rbNissan = new RadioButton();
            rbSubaru = new RadioButton();
            rbSuzuki = new RadioButton();
            rbYunyusya = new RadioButton();
            rbSonota = new RadioButton();
            tbReport = new TextBox();
            cbBoxRecord = new ComboBox();
            dgvRecord = new DataGridView();
            bt1 = new Button();
            bt2 = new Button();
            btRecordAdd = new Button();
            btRecordModify = new Button();
            btRecordDelete = new Button();
            pbPicture = new PictureBox();
            ofdPicFileOpen = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("游明朝", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(33, 34);
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
            // dtPicker
            // 
            dtPicker.Location = new Point(149, 34);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(200, 23);
            dtPicker.TabIndex = 1;
            // 
            // cbCarName
            // 
            cbCarName.FormattingEnabled = true;
            cbCarName.ItemHeight = 15;
            cbCarName.Location = new Point(149, 217);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(197, 23);
            cbCarName.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(149, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 48);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Checked = true;
            rbToyota.Location = new Point(164, 159);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 4;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
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
            // 
            // cbBoxRecord
            // 
            cbBoxRecord.FormattingEnabled = true;
            cbBoxRecord.Location = new Point(149, 96);
            cbBoxRecord.Name = "cbBoxRecord";
            cbBoxRecord.Size = new Size(197, 23);
            cbBoxRecord.TabIndex = 2;
            // 
            // dgvRecord
            // 
            dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecord.Location = new Point(149, 397);
            dgvRecord.Name = "dgvRecord";
            dgvRecord.Size = new Size(488, 150);
            dgvRecord.TabIndex = 11;
            // 
            // bt1
            // 
            bt1.AllowDrop = true;
            bt1.Location = new Point(831, 89);
            bt1.Name = "bt1";
            bt1.Size = new Size(75, 23);
            bt1.TabIndex = 12;
            bt1.Text = "開く...";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(912, 89);
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
            btRecordAdd.Location = new Point(639, 335);
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
            btRecordModify.Location = new Point(757, 335);
            btRecordModify.Name = "btRecordModify";
            btRecordModify.Size = new Size(112, 60);
            btRecordModify.TabIndex = 12;
            btRecordModify.Text = "修正";
            btRecordModify.UseVisualStyleBackColor = true;
            // 
            // btRecordDelete
            // 
            btRecordDelete.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRecordDelete.Location = new Point(875, 335);
            btRecordDelete.Name = "btRecordDelete";
            btRecordDelete.Size = new Size(112, 60);
            btRecordDelete.TabIndex = 12;
            btRecordDelete.Text = "削除";
            btRecordDelete.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            pbPicture.Location = new Point(639, 118);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 621);
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
            Controls.Add(pictureBox1);
            Controls.Add(cbBoxRecord);
            Controls.Add(cbCarName);
            Controls.Add(dtPicker);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "Form1";
            Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
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
        private DateTimePicker dtPicker;
        private ComboBox cbCarName;
        private PictureBox pictureBox1;
        private RadioButton rbToyota;
        private RadioButton rbNissan;
        private RadioButton rbSubaru;
        private RadioButton rbSuzuki;
        private RadioButton rbYunyusya;
        private RadioButton rbSonota;
        private TextBox tbReport;
        private ComboBox cbBoxRecord;
        private DataGridView dgvRecord;
        private Button bt1;
        private Button bt2;
        private Button btRecordAdd;
        private Button btRecordModify;
        private Button btRecordDelete;
        private PictureBox pbPicture;
        private OpenFileDialog ofdPicFileOpen;
    }
}
