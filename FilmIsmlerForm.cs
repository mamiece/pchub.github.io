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
    public partial class FilmIsmlerForm : Form
    {
        public FilmIsmlerForm()
        {
            InitializeComponent();
        }
        AnaEkranForm anaEkranForm;
        Film yeniFilm;
        ListViewItem yeniSatir;



        private void FilmIsmlerForm_Load(object sender, EventArgs e)
        {
            anaEkranForm = (AnaEkranForm)Application.OpenForms["AnaEkranForm"];
        }

        private void FilmIsmlerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkranForm.Show();    
        }
        bool VerileriKontrolEt()
        {
            if (string.IsNullOrEmpty(txtFilmAdi.Text))
            {
                MessageBox.Show("Film adını boş bırakmayınız.");

                return false;
            }
            else if (cBoxFilmTur.SelectedIndex<0)
            {
                MessageBox.Show("Filmin türünü boş bırakmayınız.");
                return false;
            }
            else if (string.IsNullOrEmpty(txtFilmSuresi.Text))
            {
                try
                {
                    int sure = Convert.ToInt16(txtFilmSuresi.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Film süresini sadece rakam olarak giriniz.");
                    return false;
                   
                }
                MessageBox.Show("Film süresini boş bırakmayınız.");
                return false;
            }
            else if (string.IsNullOrEmpty(txtFilmUcreti.Text))
            {
                MessageBox.Show("Film ücretini boş bırakmayınız.");

                return false;
            }
            return true;
        }
        void VerileriTemizle()
        {
            txtFilmAdi.Text=string.Empty;   
            txtFilmSuresi.Text=string.Empty;    
            txtFilmUcreti.Text=string.Empty;
            cBoxFilmTur.SelectedIndex = -1;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
             if(VerileriKontrolEt())
            {
                string filmid = new Random().Next(10000, 99999).ToString();
                string filmadi = txtFilmAdi.Text.ToUpper();

                if (anaEkranForm.sinema.FilmAra(filmid, filmadi) == null)
                {
                    ///////////////// Film Ekleme ////////////////////////
                    yeniFilm = new Film()
                    {

                        Id = filmid,
                        FilmAdi = filmadi,
                        FilmTuru = cBoxFilmTur.Text,
                        FilmSuresi = int.Parse(txtFilmSuresi.Text),
                        FilmUcreti = double.Parse(txtFilmUcreti.Text),

                    };

                    anaEkranForm.sinema.FilmEkle(yeniFilm);
                    MessageBox.Show("Film başarıyla eklendi.");
                    /*
                    listViewFilmler.Items.Add(yeniFilm.Id);
                    listViewFilmler.Items[listViewFilmler.Items.Count-1].SubItems.Add(yeniFilm.FilmAdi);
                    listViewFilmler.Items[listViewFilmler.Items.Count-1].SubItems.Add( yeniFilm.FilmTuru);
                    listViewFilmler.Items[listViewFilmler.Items.Count-1].SubItems.Add( yeniFilm.FilmSuresi.ToString());
                    listViewFilmler.Items[listViewFilmler.Items.Count - 1].SubItems.Add(yeniFilm.FilmUcreti.ToString());
                    */

                    string[] bilgiler = { yeniFilm.Id, yeniFilm.FilmAdi, yeniFilm.FilmTuru, yeniFilm.FilmSuresi.ToString(), yeniFilm.FilmUcreti.ToString() };

                    listViewFilmler.Items.Add(new ListViewItem(bilgiler));

                    VerileriTemizle();
                    ///////////////////////////////////////////////////////////////////////////  

                }
                else
                    MessageBox.Show("Bu film daha önceden eklenmiştir.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(listViewFilmler.SelectedItems.Count > 0) {

                string filmid = listViewFilmler.SelectedItems[0].Text;
                Film arananFilm = anaEkranForm.sinema.FilmAra(filmid);
                if(arananFilm !=null) {
                    if (anaEkranForm.sinema.FilmSil(arananFilm))
                    {
                        MessageBox.Show("Film başarıyla silindi.");
                        listViewFilmler.Items.Remove(listViewFilmler.SelectedItems[0]);
                        VerileriTemizle();

                    }
                    else
                        MessageBox.Show("Film silinirken hatayla karşılaşıldı.");
                }


            }
            else
                MessageBox.Show("Silmek istediğiniz film listeden seçiniz.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (listViewFilmler.SelectedItems.Count > 0)
            {
                string filmid = listViewFilmler.SelectedItems[0].Text;
                Film guncellenecekFilm = anaEkranForm.sinema.FilmAra(filmid);
                if (guncellenecekFilm != null)
                {
                    if(VerileriKontrolEt())
                    {
                        guncellenecekFilm.FilmAdi=txtFilmAdi.Text.ToUpper();
                        guncellenecekFilm.FilmTuru = cBoxFilmTur.Text;
                        guncellenecekFilm.FilmSuresi=int.Parse(txtFilmSuresi.Text);
                        guncellenecekFilm.FilmUcreti=double.Parse(txtFilmUcreti.Text);  

                        if (anaEkranForm.sinema.FilmGuncelle(guncellenecekFilm))
                        {
                            MessageBox.Show("Film başarıyla güncellendi.");
                            ///Listview in tamamını temizleyip tekrar filmleri ekleniyor.
                            listViewFilmler.Items.Clear();
                            foreach (Film film in anaEkranForm.sinema.Filmler)
                            {
                                string[] bilgiler = { film.Id, film.FilmAdi, film.FilmTuru,film.FilmSuresi.ToString(), film.FilmUcreti.ToString() };

                                listViewFilmler.Items.Add(new ListViewItem(bilgiler));
                            }
                            //////////////////////////////////////////////////
                            VerileriTemizle();
                        }
                        else
                            MessageBox.Show("Film güncellenirken hatayla karşılaşıldı.");
                    }  
       
                }
            }
            else
                MessageBox.Show("Silmek istediğiniz film listeden seçiniz.");
        }

        private void listViewFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewFilmler.SelectedItems.Count>0)
            {
                txtFilmAdi.Text= listViewFilmler.SelectedItems[0].SubItems[1].Text;
                cBoxFilmTur.Text = listViewFilmler.SelectedItems[0].SubItems[2].Text;
                txtFilmSuresi.Text = listViewFilmler.SelectedItems[0].SubItems[3].Text;
                txtFilmUcreti.Text = listViewFilmler.SelectedItems[0].SubItems[4].Text;
            }
         
        }
    }
}
