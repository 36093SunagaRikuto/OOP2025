namespace Exercise01 {
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
            bt1 = new Button();
            ss1 = new StatusStrip();
            rtextbox = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // bt1
            // 
            bt1.Location = new Point(43, 26);
            bt1.Name = "bt1";
            bt1.Size = new Size(116, 44);
            bt1.TabIndex = 0;
            bt1.Text = "読み込み";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // ss1
            // 
            ss1.Location = new Point(0, 428);
            ss1.Name = "ss1";
            ss1.Size = new Size(800, 22);
            ss1.TabIndex = 2;
            ss1.Text = "ss1";
            // 
            // rtextbox
            // 
            rtextbox.Location = new Point(43, 90);
            rtextbox.Name = "rtextbox";
            rtextbox.Size = new Size(745, 376);
            rtextbox.TabIndex = 3;
            rtextbox.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(199, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 4;
            button1.Text = "遅延ボタン";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(rtextbox);
            Controls.Add(ss1);
            Controls.Add(bt1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt1;
        private StatusStrip ss1;
        private RichTextBox rtextbox;
        private Button button1;
    }
}
