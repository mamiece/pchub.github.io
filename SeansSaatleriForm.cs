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
    public partial class SeansSaatleriForm : Form
    {
        public SeansSaatleriForm()
        {
            InitializeComponent();
        }
      
        AnaEkranForm anaEkranForm;
        Saat saat;
        
        private void SeansSaatleriForm_Load(object sender, EventArgs e)
        {
            anaEkranForm = (AnaEkranForm)Application.OpenForms["AnaEkranForm"];

        }

        private void SeansSaatleriForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkranForm.Show();    
        }

        bool VerileriKontrolEt()
        {
            if(string.IsNullOrEmpty(txtBaslangic.Text))
            {
                MessageBox.Show("Lütfen seans başlangıç saatini boş bırakmayın.");
                return false;   
            }
            else if (string.IsNullOrEmpty(txtBitis.Text))
            {
                MessageBox.Show("Lütfen seans bitiş saatini boş bırakmayın.");
                return false;
            }
            
            if(!string.IsNullOrEmpty(txtBaslangic.Text))
            {
                try
                {
                    DateTime dtBaslangic= DateTime.Parse(txtBaslangic.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen seans başlangıç saatini doğru biçimde giriniz");
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(txtBitis.Text))
            {
                try
                {
                    DateTime dtBitis = DateTime.Parse(txtBitis.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen seans bitiş saatini doğru biçimde giriniz");
                    return false;
                }
            }
            return true;

        }
       
      void TemizleIptal()
        {
            txtBaslangic.Text = string.Empty;
            txtBitis.Text = string.Empty;   
            lblUzunlukDk.Text= string.Empty;    

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            /*
            string baslangic = txtBaslangic.Text;
            string bitis = txtBitis.Text;

            DateTime dtBaslangic=DateTime.Parse(baslangic);
            DateTime dtBitis= DateTime.Parse(bitis);

           //TimeSpan fark= dtBitis - dtBaslangic;
           // TimeSpan fark= dtBitis.Subtract(dtBaslangic);
           // MessageBox.Show(fark.TotalMinutes.ToString());

            TimeSpan fark = DateTime.Parse(txtBitis.Text).Subtract(DateTime.Parse(txtBaslangic.Text));

            //MessageBox.Show(DateTime.Parse(baslangic).ToString());
            */

            if(VerileriKontrolEt())
            {
                string baslangic= txtBaslangic.Text;    
                string bitis = txtBitis.Text;

                if (anaEkranForm.sinema.SeansSaatiAra(baslangic, bitis) == null)
                {
                    saat = new Saat(baslangic, bitis);

                    if (anaEkranForm.sinema.SaatEkle(saat))
                    {
                        MessageBox.Show("Yeni seans saati başarıyla eklendi.");
                        string[] saatBilgileri = {saat.Baslangic,saat.Bitis,saat.UzunlukDk.ToString() };
                        listViewSaatler.Items.Add(new ListViewItem(saatBilgileri));

                        TemizleIptal();
                    }
                }
                else
                    MessageBox.Show("Eklemek istediğiniz seans saati daha önceden eklenmiştir.");

            }
        }

        private void listViewSaatler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSaatler.SelectedItems.Count > 0)
            {
                btnSil.Enabled = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           DialogResult cevap=MessageBox.Show("Seçili seans saatini silmek istiyor musunuz?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(cevap==DialogResult.Yes)
            {
                string baslangic = listViewSaatler.SelectedItems[0].SubItems[0].Text;
                string bitis = listViewSaatler.SelectedItems[0].SubItems[1].Text;
                Saat arananSaat = anaEkranForm.sinema.SeansSaatiAra(baslangic, bitis);
                if(arananSaat !=null)
                {
                   if(anaEkranForm.sinema.SeansSaatSil(arananSaat))
                    {
                        MessageBox.Show("Seans saati başarıyla silindi.");
                        listViewSaatler.Items.Clear();
                        foreach (Saat saat in anaEkranForm.sinema.Saatler)
                        {
                            string[] saatBilgileri = { saat.Baslangic, saat.Bitis, saat.UzunlukDk.ToString() };
                            listViewSaatler.Items.Add(new ListViewItem(saatBilgileri));
                        }
                    }
                }

            }

        }
    }
}
