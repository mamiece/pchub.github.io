using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders26
{
    public class Saat
    {
        //Alanlarımız
        string baslangic, bitis;
        double uzunlukDk;

        //Yapıcı Metodumuz
        public Saat(string baslangic, string bitis)
        {
            this.baslangic = baslangic; 
            this.bitis = bitis;

            TimeSpan fark = DateTime.Parse(bitis).Subtract(DateTime.Parse(baslangic));
            uzunlukDk = fark.TotalMinutes;
        }


        //Özelliklerimiz
        public string Baslangic { get => baslangic; set => baslangic = value; }
        public string Bitis { get => bitis; set => bitis = value; }
        public double UzunlukDk { get => uzunlukDk;}
    }
}
