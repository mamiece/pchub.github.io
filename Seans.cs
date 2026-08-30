using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders26
{
    internal class Seans
    {
        //Alanlarımız
        Salon salon;
        Saat seansSaat;
        Film film;
        string id;
        
        //Yapıcı Metodlarımız
        public Seans()
        {
            this.id= new Random().Next(10000,99999).ToString();   
        }
        public Seans(Salon salon, Saat seansSaat, Film film)
        {
            this.id = new Random().Next(10000, 99999).ToString();
            Salon = salon;
            SeansSaat = seansSaat;
            Film = film;
          
        }

        public Salon Salon { get => salon; set => salon = value; }
        public Saat SeansSaat { get => seansSaat; set => seansSaat = value; }
        public Film Film { get => film; set => film = value; }
        public string Id { get => id;}
    }
}
