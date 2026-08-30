using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders26
{
    public class Film
    {
        //Alanlarımız
        string id, filmAdi, filmTuru;
        int filmSuresi;
        double filmUcreti;     

       //Yapıcı / Kurucu Metodlar 
       public Film() // Boş yapıcı metod
       {      
            
       }
        public Film(string id, string filmAdi, string filmTuru, int filmSuresi, double filmUcreti)
        {
            this.id = id;
            this.filmAdi = filmAdi; 
            this.filmTuru=filmTuru; 
            this.filmSuresi=filmSuresi; 
            this.filmUcreti=filmUcreti; 


        }
        //Özelliklerimiz
        public string Id { get => id; set => id = value; }
        public string FilmAdi { get => filmAdi; set => filmAdi = value; }
        public string FilmTuru { get => filmTuru; set => filmTuru = value; }
        public int FilmSuresi
        {
            get => filmSuresi; 
            set
            {
                if (value >= 30)
                    filmSuresi = value;
                else
                    throw new ArgumentException("Film süresi 30' dan küçük olamaz.");    
            }
        }
        public double FilmUcreti { get => filmUcreti; set => filmUcreti = value; }


    }
}
