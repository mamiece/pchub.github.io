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
    public partial class SeansIslemlerForm : Form
    {
        AnaEkranForm anaEkranForm;
        Salon seansSalon;
        Saat seansSaat;
        Film seansFilm; 
        public SeansIslemlerForm()
        {
            InitializeComponent();
        }
        Sinema sinema;
       void SeansBilgileriListele()
        {
            listViewSeanslar.Items.Clear();
            foreach (Seans seans in sinema.Seanslar)
            {
                string[] satirVeriler = { 
                                              seans.Id,
                                              seans.Salon.SalonAdi,
                                              seans.SeansSaat.Baslangic,
                                              seans.SeansSaat.Bitis,
                                              seans.SeansSaat.UzunlukDk.ToString(),
                                              seans.Film.FilmAdi,
                                              seans.Film.FilmSuresi.ToString(),
                        };

                ListViewItem yeniSatir = new ListViewItem(satirVeriler);
                listViewSeanslar.Items.Add(yeniSatir);
            }
        }
        private void SeansIslemlerForm_Load(object sender, EventArgs e)
        {
            anaEkranForm =(AnaEkranForm)Application.OpenForms["AnaEkranForm"];
            sinema=anaEkranForm.sinema;

            foreach (Salon s in sinema.Salonlar)
            {
                cBoxSalonlar.Items.Add(s.SalonAdi);
            }

            foreach (Saat s in sinema.Saatler)
            {
                cBoxSaatler.Items.Add(s.Baslangic +"-"+s.Bitis);
            }

            foreach (Film f in sinema.Filmler)
            {
                cBoxFilmler.Items.Add(f.Id + "-"+f.FilmAdi);
            }


            SeansBilgileriListele();
        }

        private void SeansIslemlerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkranForm.Show();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            if(cBoxSalonlar.SelectedIndex <0)
            {
                MessageBox.Show("Lütfen salon seçiniz");
            }
            else if (cBoxSaatler.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen seans saati seçiniz");
            }
            else if (cBoxFilmler.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen seans filmini seçiniz");
            }
            else
            {
                //Bütün bilgiler seçilmiş
                //Salon Nesnesini
               seansSalon=sinema.SalonAra(cBoxSalonlar.Text);

                //Seansın Saat Nesnesi
                string saat =cBoxSaatler.Text;
                string baslangic = saat.Split('-')[0];
                string bitis = saat.Split('-')[1];
                seansSaat = sinema.SeansSaatiAra(baslangic, bitis);

                //Seansın Film Nesnesi
                string film = cBoxFilmler.Text;
                string filmID = film.Split('-')[0];
                seansFilm=sinema.FilmAra(filmID);
                if (sinema.SeansAra(seansSalon.SalonAdi, seansSaat.Baslangic, seansSaat.Bitis) == null)
                {

                    if (seansSaat.UzunlukDk >= seansFilm.FilmSuresi)
                    {
                        Seans yeniSeans = new Seans();
                        yeniSeans.Salon = seansSalon;
                        yeniSeans.SeansSaat = seansSaat;
                        yeniSeans.Film = seansFilm;

                        if (sinema.SeansEkle(yeniSeans))
                        {
                            MessageBox.Show("Yeni seans başarıyla eklendi.");

                            string[] satirVeriler = {
                                              yeniSeans.Id,
                                              yeniSeans.Salon.SalonAdi,
                                              yeniSeans.SeansSaat.Baslangic,
                                              yeniSeans.SeansSaat.Bitis,
                                              yeniSeans.SeansSaat.UzunlukDk.ToString(),
                                              yeniSeans.Film.FilmAdi,
                                              yeniSeans.Film.FilmSuresi.ToString(),
                        };

                            ListViewItem yeniSatir = new ListViewItem(satirVeriler);
                            listViewSeanslar.Items.Add(yeniSatir);
                        }
                    }
                    else
                        MessageBox.Show("Sean süresi filmin süresinden uzun olmalıdır.");
                }
                else
                    MessageBox.Show("Seçtiğiniz salon ve saatte başka bir film vardır.");
            }
        }

        private void btnSeansSil_Click(object sender, EventArgs e)
        {
            if (listViewSeanslar.SelectedItems.Count > 0)
            {

                string seansId = listViewSeanslar.SelectedItems[0].SubItems[0].Text;
                if(DialogResult.Yes==MessageBox.Show($"{seansId} nolu seansı silmek istiyor musunuz","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    if(sinema.SeansSil(seansId))
                    {
                        MessageBox.Show($"{seansId} nolu seansı başarıyla silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SeansBilgileriListele();
                    }
                }
            }
            else
                MessageBox.Show("Silmek istediğiniz seansı seçiniz.");

           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
