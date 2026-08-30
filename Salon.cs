using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders26
{
    public class Salon
    {
        //Alanlarımız
        string salonAdi;
        int koltukAdedi;

        //Yapıcı Metdolarımız
        public Salon() { }
        public Salon(string salonAdi, int koltukAdedi)
        {
            this.SalonAdi = salonAdi;
            this.KoltukAdedi = koltukAdedi;
        }

        public string SalonAdi { get => salonAdi; set => salonAdi = value; }
        public int KoltukAdedi
        {
            get => koltukAdedi;

            set
            {
                if (value >= 10)
                    koltukAdedi = value;
                else
                    throw new ArgumentException("Koltuk adedi en az 10 olmalıdır.");
            }
        }
    }
}
