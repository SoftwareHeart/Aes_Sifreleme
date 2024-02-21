using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AES_ile_sifreleme
{
    public partial class MesajSifreleme : Form
    {
        public MesajSifreleme()
        {
            InitializeComponent();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtDecryptedText.Text = "";
            try
            {
                string plainText = txtInput.Text;

                // Anahtar oluþturma
                byte[] keyBytes = GenerateRandomKey();
                byte[] ivBytes =  GenerateIV();
                string key = Convert.ToBase64String(keyBytes);
                string iv = Convert.ToBase64String(ivBytes);
                txtKey.Text = key;
                txt_iv.Text = iv;
                // AES þifreleme
                string encryptedText = EncryptString(plainText, keyBytes,ivBytes);

                // Þifrelenmiþ metni ekrana yazdýr
                txtEncryptedText.Text = encryptedText;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private byte[] GenerateRandomKey()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] keyBytes = new byte[32]; // 256-bit anahtar
                rng.GetBytes(keyBytes);
                return keyBytes;
            }
        }
        static byte[] GenerateIV(int length = 16)
        {
            /*
             * Güvenli bir Initialization Vector (IV) oluþturur.
             * 
             * Parameters:
             *   length: IV'nin uzunluðu (varsayýlan olarak 16).
             * 
             * Returns:
             *   IV vektörü olarak kullanýlabilecek rastgele sayý dizisi (byte[]).
             */

            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                byte[] iv = new byte[length];
                rngCsp.GetBytes(iv);
                return iv;
            }
        }



        private string EncryptString(string plainText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;
                aesAlg.Mode = CipherMode.ECB;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor();

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }


        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string encryptedText = txtEncryptedText.Text;

                try
                {
                    byte[] key = Convert.FromBase64String(txtKey.Text);
                    byte[] iv = Convert.FromBase64String(txt_iv.Text);
                    // AES þifre çözme
                    string decryptedText = DecryptString(encryptedText, key,iv);

                    // Þifre çözülmüþ metni ekrana yazdýr
                    txtDecryptedText.Text = decryptedText;
                }
                catch
                {
                    MessageBox.Show("Hata: Anahtar deðerini kontrol ediniz!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private string DecryptString(string encryptedText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.Mode = CipherMode.ECB;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void button_ana_sayfa_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Close();
            giris.Show();
        }

        private void MesajSifreleme_Load(object sender, EventArgs e)
        {

        }
    }
}
