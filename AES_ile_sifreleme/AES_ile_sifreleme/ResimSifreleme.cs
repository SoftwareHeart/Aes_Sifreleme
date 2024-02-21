using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AES_ile_sifreleme
{
    public partial class ResimSifreleme : Form
    {
        private byte[] selectedImageBytes;
        private byte[] key;
        private byte[] iv;
        public ResimSifreleme()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            // Resim seçme penceresi
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen resmi byte dizisine yükle
                selectedImageBytes = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (selectedImageBytes == null)
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
                return;
            }

            using (Aes aesAlg = Aes.Create())
            {
                // Anahtar ve IV (Initialization Vector) oluştur
                key = aesAlg.Key;
                iv = aesAlg.IV;
                string key1 = Convert.ToBase64String(key);
                string iv1 = Convert.ToBase64String(iv);

                keyText.Text = key1;
                textIv.Text = iv1;

                // Resmi şifrele
                byte[] encryptedImage = EncryptImage(key, iv, selectedImageBytes);

                // Şifrelenmiş resmi kaydet
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Encrypted Image Files|*.enc";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveDialog.FileName, encryptedImage);
                    MessageBox.Show("Resim başarıyla şifrelendi ve kaydedildi.");
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Encrypted Image Files|*.enc";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Şifreli resmi seç
                selectedImageBytes = File.ReadAllBytes(openFileDialog.FileName);
            }
            if (selectedImageBytes == null)
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
                return;
            }

            using (Aes aesAlg = Aes.Create())
            {
                // Resmi çöz
                byte[] decryptedImage = DecryptImage(key, iv, selectedImageBytes);

                // Çözülmüş resmi göster
                pictureBox.Image = Image.FromStream(new MemoryStream(decryptedImage));
            }
        }

        private byte[] EncryptImage(byte[] key, byte[] iv, byte[] imageBytes)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            csEncrypt.Write(imageBytes, 0, imageBytes.Length);
                            csEncrypt.FlushFinalBlock();
                        }
                    }

                    return msEncrypt.ToArray();
                }
            }
        }

        private byte[] DecryptImage(byte[] key, byte[] iv, byte[] encryptedImage)
        {
            using (Aes aesAlg = Aes.Create())
            {
                byte[] keyBytes = Convert.FromBase64String(keyText.Text);
                byte[] ivBytes = Convert.FromBase64String(textIv.Text);

                aesAlg.Key = keyBytes;
                aesAlg.IV = ivBytes;


                using (MemoryStream msDecrypt = new MemoryStream())
                {
                    using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write))
                        {
                            csDecrypt.Write(encryptedImage, 0, encryptedImage.Length);
                            csDecrypt.FlushFinalBlock();
                        }
                    }

                    return msDecrypt.ToArray();
                }
            }
        }

        private void button_ana_sayfa_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Close();
            giris.Show();
        }
    }
}
 