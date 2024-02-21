namespace AES_ile_sifreleme
{
    partial class ResimSifreleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            groupBox1 = new GroupBox();
            pictureBox = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            keyText = new TextBox();
            label10 = new Label();
            label2 = new Label();
            textIv = new TextBox();
            button_ana_sayfa = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(333, 44);
            button1.Name = "button1";
            button1.Size = new Size(201, 77);
            button1.TabIndex = 0;
            button1.Text = "Resim seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSelectImage_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox);
            groupBox1.Location = new Point(29, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 263);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Çözülmüş Resim";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(19, 26);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(244, 217);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(333, 136);
            button2.Name = "button2";
            button2.Size = new Size(201, 72);
            button2.TabIndex = 4;
            button2.Text = "Şifrele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnEncrypt_Click;
            // 
            // button3
            // 
            button3.Location = new Point(333, 229);
            button3.Name = "button3";
            button3.Size = new Size(201, 69);
            button3.TabIndex = 5;
            button3.Text = "Çöz";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDecrypt_Click;
            // 
            // keyText
            // 
            keyText.Location = new Point(82, 330);
            keyText.Name = "keyText";
            keyText.Size = new Size(452, 27);
            keyText.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 333);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 7;
            label10.Text = "Anahtar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 363);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 9;
            label2.Text = "İv:";
            // 
            // textIv
            // 
            textIv.Location = new Point(82, 363);
            textIv.Name = "textIv";
            textIv.Size = new Size(452, 27);
            textIv.TabIndex = 8;
            // 
            // button_ana_sayfa
            // 
            button_ana_sayfa.Location = new Point(0, 0);
            button_ana_sayfa.Name = "button_ana_sayfa";
            button_ana_sayfa.Size = new Size(38, 29);
            button_ana_sayfa.TabIndex = 13;
            button_ana_sayfa.Text = "<";
            button_ana_sayfa.UseVisualStyleBackColor = true;
            button_ana_sayfa.Click += button_ana_sayfa_Click;
            // 
            // ResimSifreleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 411);
            Controls.Add(button_ana_sayfa);
            Controls.Add(label2);
            Controls.Add(textIv);
            Controls.Add(label10);
            Controls.Add(keyText);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "ResimSifreleme";
            Text = "ResimSifreleme";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private PictureBox pictureBox;
        private Button button2;
        private Button button3;
        private TextBox keyText;
        private Label label10;
        private Label label2;
        private TextBox textIv;
        private Button button_ana_sayfa;
    }
}