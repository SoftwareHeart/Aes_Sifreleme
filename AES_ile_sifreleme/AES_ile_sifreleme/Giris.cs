using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_ile_sifreleme
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void MesajAlaninaGit_Click(object sender, EventArgs e)
        {
            MesajSifreleme mesaj = new();
            this.Hide();
            mesaj.Show();
        }

        private void GoruntuAlaninaGit_Click(object sender, EventArgs e)
        {
            ResimSifreleme resim = new();
            this.Hide();
            resim.Show();
        }
    }
}
