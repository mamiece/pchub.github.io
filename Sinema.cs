using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ders26
{
    public class Sinema
    {
        List<Film> filmler= new List<Film>();
        List<Saat> saatler= new List<Saat>();
        List<Salon> salonlar = new List<Salon>();
        List<Seans> seanslar = new List<Seans>();

        public List<Film> Filmler { get => filmler; }
        public List<Saat> Saatler { get => saatler; }
        public List<Salon> Salonlar { get => salonlar; }
        internal List<Seans> Seanslar { get => seanslar; }

        public bool FilmEkle(Film yeniFilm)
        {
            try
            {
                Filmler.Add(yeniFilm);
                return true;    
            }
            catch (Exception)
            {
                return false;   
            }
        }
        public bool SalonEkle(Salon yeniSalon)
        {
            try
            {
                salonlar.Add(yeniSalon);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        internal bool SeansEkle(Seans yeniSeans)
        {
            try
            {
                seanslar.Add(yeniSeans);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Salon SalonAra(string salonAdi)
        {
            Salon arananSalon = null;

            foreach (Salon salon in Salonlar)
            {
                if (salon.SalonAdi == salonAdi)
                {
                    arananSalon = salon;
                }
            }

            return arananSalon;
        }
        public bool SalonSil(Salon salon)
        {
            try
            {
                Salonlar.Remove(salon);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SalonGuncelle(Salon guncellenecekSalon)
        {
            try
            {
                foreach (Salon salon in Salonlar)
                {
                    if (salon.SalonAdi == guncellenecekSalon.SalonAdi)
                    {
                        salon.KoltukAdedi = guncellenecekSalon.KoltukAdedi;

                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SaatEkle(Saat yeniSaat)
        {
            try
            {
                saatler.Add(yeniSaat);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Saat SeansSaatiAra(string baslangic , string bitis)
        {
            Saat arananSeansSaati = null;

            foreach (Saat saat in saatler)
            {
                if (saat.Baslangic == baslangic && saat.Bitis==bitis)
                {
                    arananSeansSaati = saat;
                    break;
                }
            }
            return arananSeansSaati;
        }

        public Film FilmAra(string filmID)
        {
            Film arananFilm=null;

            foreach (Film film in Filmler)
            {
                if(film.Id==filmID )
                {
                    arananFilm = film;  
                    break;  
                }
            }

            return arananFilm;
        }
        public Film FilmAra(string filmAdi, string filmID )
        {
            Film arananFilm = null;

            foreach (Film film in Filmler)
            {
                if (film.Id == filmID || film.FilmAdi == filmAdi)
                {
                    arananFilm = film;
                }
            }

            return arananFilm;

        }

        public bool FilmSil(Film film)
        {
            try
            {
                Filmler.Remove(film);
                return true;    
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool FilmGuncelle(Film guncellenecekFilm)
        {
            try
            {
                foreach (Film film in Filmler)
                {
                    if(film.Id==guncellenecekFilm.Id)
                    {
                        film.FilmAdi = guncellenecekFilm.FilmAdi;
                        film.FilmTuru = guncellenecekFilm.FilmTuru;
                        film.FilmSuresi = guncellenecekFilm.FilmSuresi;
                        film.FilmUcreti = guncellenecekFilm.FilmUcreti;
                        return true;    
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SeansSaatSil(Saat saat)
        {
            try
            {
                saatler.Remove(saat);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        internal Seans SeansAra(string salonAdi,string baslangic,string bitis)
        {
            Seans arananSeans=null;
            foreach (Seans s in seanslar)
            {
                if(s.Salon.SalonAdi==salonAdi && s.SeansSaat.Baslangic==baslangic && s.SeansSaat.Bitis==bitis)
                {
                    arananSeans = s; 
                    break;
                }
            }
            return arananSeans; 
        }

        public bool SeansSil(string seansid)
        {
            try
            {
                foreach (Seans seans in seanslar)
                {
                    if(seans.Id==seansid)
                    {
                        seanslar.Remove(seans); 
                        return true;    
                    }
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
