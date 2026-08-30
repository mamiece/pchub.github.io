using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders26
{
    public partial class SalonIslmelerForm : Form
    {
        public SalonIslmelerForm()
        {
            InitializeComponent();
        }
        AnaEkranForm anaEkranForm;
        Salon salon;
        string salonadi;
        int koltukadet;
        bool VerileriKontrolEt()
        {
            if (string.IsNullOrEmpty(txtSalonAdi.Text))
            {
                MessageBox.Show("Lütfen salon adını boş bırakmayınız");
                return false;
            }
            else if (string.IsNullOrEmpty(txtKoltukAdedi.Text))
            {
                MessageBox.Show("Lütfen koltuk adedini boş bırakmayınız");
                return false;

            }
            else if (!string.IsNullOrEmpty(txtKoltukAdedi.Text))
            {
                try
                {
                    koltukadet = int.Parse(txtKoltukAdedi.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen koltuk adedini sadece sayı olarak giriniz.");
                    return false;

                }

            }

            return true;
        }
        void SalonlariListele()
        {
            listViewSalonlar.Items.Clear();

            foreach (Salon salon in anaEkranForm.sinema.Salonlar)
            {
                string[] salonBilgileri = { salon.SalonAdi, salon.KoltukAdedi.ToString() };
                listViewSalonlar.Items.Add(new ListViewItem(salonBilgileri));
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (VerileriKontrolEt())
            {
                string salonadi = txtSalonAdi.Text.ToUpper();

                if (anaEkranForm.sinema.SalonAra(salonadi) == null)
                {
                    salon = new Salon()
                    {
                        SalonAdi = salonadi,
                        KoltukAdedi = koltukadet,
                    };

                    anaEkranForm.sinema.SalonEkle(salon);
                    MessageBox.Show("Yeni salon başarıyla eklendi.");
                    SalonlariListele();

                    TemizleIptal();
                }
                else
                    MessageBox.Show("Bu isimde salon daha önceden eklenmiştir.");



            }
        }

        void TemizleIptal()
        {
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            btnIptal.Enabled = false;
            txtSalonAdi.Enabled = true;
            txtSalonAdi.Text = string.Empty;
            txtKoltukAdedi.Text = string.Empty;
            salonadi = string.Empty;
        }

        private void SalonIslmelerForm_Load(object sender, EventArgs e)
        {
            anaEkranForm = (AnaEkranForm)Application.OpenForms["AnaEkranForm"];
        }

        private void SalonIslmelerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkranForm.Show();
        }

        private void listViewSalonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSalonlar.SelectedItems.Count > 0)
            {
                btnSil.Enabled = true;
                btnGuncelle.Enabled = true;
                btnIptal.Enabled = true;

                txtSalonAdi.Text = listViewSalonlar.SelectedItems[0].SubItems[0].Text;
                txtKoltukAdedi.Text = listViewSalonlar.SelectedItems[0].SubItems[1].Text;
                txtSalonAdi.Enabled = false;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            TemizleIptal();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            salonadi = txtSalonAdi.Text.ToUpper();
            Salon silincekSalon = anaEkranForm.sinema.SalonAra(salonadi);
            if (silincekSalon != null)
            {
                if (anaEkranForm.sinema.SalonSil(silincekSalon))
                {
                    MessageBox.Show("Salon başarıyla silindi.");
                    SalonlariListele();
                    TemizleIptal();
                }
                else
                    MessageBox.Show("Salon silme esnasında hatayla karşılaşıldı.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            salonadi = txtSalonAdi.Text.ToUpper();
            Salon guncellenecekSalon = anaEkranForm.sinema.SalonAra(salonadi);
            if (guncellenecekSalon != null)
            {
                guncellenecekSalon.KoltukAdedi = int.Parse(txtKoltukAdedi.Text);

                if (anaEkranForm.sinema.SalonGuncelle(guncellenecekSalon))
                {
                    MessageBox.Show("Salon başarıyla güncellendi.");
                    SalonlariListele();
                    TemizleIptal();
                }
            }
        }
    }
}
