namespace AES_ile_sifreleme
{
    partial class Giris
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
            MesajAlaninaGit = new Button();
            GoruntuAlaninaGit = new Button();
            SuspendLayout();
            // 
            // MesajAlaninaGit
            // 
            MesajAlaninaGit.BackColor = SystemColors.ActiveCaption;
            MesajAlaninaGit.Location = new Point(90, 79);
            MesajAlaninaGit.Name = "MesajAlaninaGit";
            MesajAlaninaGit.Size = new Size(150, 130);
            MesajAlaninaGit.TabIndex = 0;
            MesajAlaninaGit.Text = "Mesaj Şifrele";
            MesajAlaninaGit.UseVisualStyleBackColor = false;
            MesajAlaninaGit.Click += MesajAlaninaGit_Click;
            // 
            // GoruntuAlaninaGit
            // 
            GoruntuAlaninaGit.BackColor = SystemColors.ActiveCaption;
            GoruntuAlaninaGit.Location = new Point(347, 79);
            GoruntuAlaninaGit.Name = "GoruntuAlaninaGit";
            GoruntuAlaninaGit.Size = new Size(150, 130);
            GoruntuAlaninaGit.TabIndex = 1;
            GoruntuAlaninaGit.Text = "Görüntü Şifrele";
            GoruntuAlaninaGit.UseVisualStyleBackColor = false;
            GoruntuAlaninaGit.Click += GoruntuAlaninaGit_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 313);
            Controls.Add(GoruntuAlaninaGit);
            Controls.Add(MesajAlaninaGit);
            Name = "Giris";
            Text = "Giris";
            ResumeLayout(false);
        }

        #endregion

        private Button MesajAlaninaGit;
        private Button GoruntuAlaninaGit;
    }
}