namespace AES_ile_sifreleme
{
    partial class MesajSifreleme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            txtKey = new TextBox();
            txtEncryptedText = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDecryptedText = new TextBox();
            label4 = new Label();
            btnDecrypt = new Button();
            button_ana_sayfa = new Button();
            label5 = new Label();
            txt_iv = new TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(145, 41);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(495, 27);
            txtInput.TabIndex = 0;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(145, 92);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(495, 27);
            txtKey.TabIndex = 1;
            // 
            // txtEncryptedText
            // 
            txtEncryptedText.Location = new Point(147, 186);
            txtEncryptedText.Name = "txtEncryptedText";
            txtEncryptedText.Size = new Size(495, 27);
            txtEncryptedText.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(672, 186);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Şifrele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEncrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 46);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 6;
            label1.Text = "Mesaj: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 95);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Anahtar: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 190);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 8;
            label3.Text = "Şifrelenmis Metin:";
            // 
            // txtDecryptedText
            // 
            txtDecryptedText.Location = new Point(147, 248);
            txtDecryptedText.Name = "txtDecryptedText";
            txtDecryptedText.Size = new Size(495, 27);
            txtDecryptedText.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 251);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 10;
            label4.Text = "Çözülmüş mesaj :";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(672, 247);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(94, 29);
            btnDecrypt.TabIndex = 11;
            btnDecrypt.Text = "Mesajı Çöz";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // button_ana_sayfa
            // 
            button_ana_sayfa.Location = new Point(2, 5);
            button_ana_sayfa.Name = "button_ana_sayfa";
            button_ana_sayfa.Size = new Size(38, 29);
            button_ana_sayfa.TabIndex = 12;
            button_ana_sayfa.Text = "<";
            button_ana_sayfa.UseVisualStyleBackColor = true;
            button_ana_sayfa.Click += button_ana_sayfa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 142);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 14;
            label5.Text = "IV:";
            // 
            // txt_iv
            // 
            txt_iv.Location = new Point(145, 142);
            txt_iv.Name = "txt_iv";
            txt_iv.Size = new Size(495, 27);
            txt_iv.TabIndex = 13;
            // 
            // MesajSifreleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(799, 353);
            Controls.Add(label5);
            Controls.Add(txt_iv);
            Controls.Add(button_ana_sayfa);
            Controls.Add(btnDecrypt);
            Controls.Add(label4);
            Controls.Add(txtDecryptedText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtEncryptedText);
            Controls.Add(txtKey);
            Controls.Add(txtInput);
            Name = "MesajSifreleme";
            Text = "MesajSifreleme";
            Load += MesajSifreleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtKey;
        private TextBox txtEncryptedText;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDecryptedText;
        private Label label4;
        private Button btnDecrypt;
        private Button button_ana_sayfa;
        private Label label5;
        private TextBox txt_iv;
    }
}
