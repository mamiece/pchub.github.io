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
    public partial class AnaEkranForm : Form
    {
        public AnaEkranForm()
        {
            InitializeComponent();
        }
       public Sinema sinema = new Sinema();   


        private void btnFimIslemleri_Click(object sender, EventArgs e)
        {
            FilmIsmlerForm filmIsmlerForm = new FilmIsmlerForm();
            this.Hide();
            filmIsmlerForm.ShowDialog();  
        }

        private void AnaEkranForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSalonIslemler_Click(object sender, EventArgs e)
        {
            SalonIslmelerForm salonIslmelerForm = new SalonIslmelerForm(); 
            this.Hide();    
            salonIslmelerForm.ShowDialog(); 
        }

        private void btnSeansSaatleri_Click(object sender, EventArgs e)
        {
            SeansSaatleriForm seansSaatleriForm = new SeansSaatleriForm();  
            this.Hide();    
            seansSaatleriForm.ShowDialog(this); 
        }

        private void btnSeansIslemler_Click(object sender, EventArgs e)
        {
            SeansIslemlerForm seansIslemlerForm = new SeansIslemlerForm();  
            this.Hide();
            seansIslemlerForm.ShowDialog();
        }
    }
}
