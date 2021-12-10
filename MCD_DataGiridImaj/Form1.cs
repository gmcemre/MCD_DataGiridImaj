using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_DataGiridImaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Urun> urunlerim = new List<Urun>();
            urunlerim.Add(new Urun()
            {
                Id =1,
                UrunTanim=  "Tablet 1",
                ResimYol  = @"C:\Users\103AKSAM_EMRE\Desktop\aksamemre\Tablet1.jfif"
            });

            urunlerim.Add(new Urun()
            {
                Id = 2,
                UrunTanim = "Tablet 2",
                ResimYol = @"C:\Users\103AKSAM_EMRE\Desktop\aksamemre\Tablet2.jfif"
            });

            urunlerim.Add(new Urun()
            {
                Id = 3,
                UrunTanim = "Tablet 3",
                ResimYol = @"C:\Users\103AKSAM_EMRE\Desktop\aksamemre\Tablet3.jfif"
            });

            urunlerim.Add(new Urun()
            {
                Id = 4,
                UrunTanim = "Tablet 4",
                ResimYol =string .Empty 
            });

            grdUrunler.DataSource = urunlerim;
        }
    }
}
