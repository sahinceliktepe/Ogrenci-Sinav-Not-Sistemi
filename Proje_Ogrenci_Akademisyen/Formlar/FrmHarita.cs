using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ogrenci_Akademisyen.Formlar
{
    public partial class FrmHarita : Form
    {
        public FrmHarita()
        {
            InitializeComponent();
        }

        private void pnlBolumListesi_Click(object sender, EventArgs e)
        {
            FrmBolumListesi fr = new FrmBolumListesi();
            fr.Show();
            this.Close();
        }

        private void pnlYeniBolum_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
            this.Close();
        }

        private void pnlNotlar_Click(object sender, EventArgs e)
        {
            FrmNotlar fr = new FrmNotlar();
            fr.Show();
            this.Close();
        }

        private void pnlOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr = new FrmOgrenci();
            fr.Show();
            this.Close();
        }

        private void pnlOgrenciKayit_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayit fr = new FrmOgrenciKayit();
            fr.Show();
            this.Close();
        }

        private void pnlDersListesi_Click(object sender, EventArgs e)
        {
            FrmDersListesi fr = new FrmDersListesi();
            fr.Show();
            this.Close();
        }

        private void pnlYardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje C# dili ve MSSQL veritabanı kullanılarak bir okul projesi olarak geliştirilmiştir. Akademisyen için kullanıcı adı: 00000 ve şifre: 000 şeklindedir.", "Yardım Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pnlYeniDers_Click(object sender, EventArgs e)
        {
            FrmYeniDers fr = new FrmYeniDers();
            fr.Show();
            this.Close();
        }

        private void pnlCikisYap_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Close();
        }

        private void lblBolumListesi_Click(object sender, EventArgs e)
        {
            FrmBolumListesi fr = new FrmBolumListesi();
            fr.Show();
            this.Close();
        }

        private void lblYeniBolum_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
            this.Close();
        }

        private void lblNotlarFormu_Click(object sender, EventArgs e)
        {
            FrmNotlar fr = new FrmNotlar();
            fr.Show();
            this.Close();
        }

        private void lblOgrenciFormu_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr = new FrmOgrenci();
            fr.Show();
            this.Close();
        }

        private void lblOgrenciKayit_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayit fr = new FrmOgrenciKayit();
            fr.Show();
            this.Close();
        }

        private void lblDersListesi_Click(object sender, EventArgs e)
        {
            FrmDersListesi fr = new FrmDersListesi();
            fr.Show();
            this.Close();
        }

        private void lblYeniDers_Click(object sender, EventArgs e)
        {
            FrmYeniDers fr = new FrmYeniDers();
            fr.Show();
            this.Close();
        }

        private void lblYardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje C# dili ve MSSQL veritabanı kullanılarak bir okul projesi olarak geliştirilmiştir. Akademisyen için kullanıcı adı: 00000 ve şifre: 000 şeklindedir.", "Yardım Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lblCikisYap_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Close();
        }
    }
}
