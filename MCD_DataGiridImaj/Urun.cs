using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_DataGiridImaj
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunTanim { get; set; }
        public string ResimYol { get; set; }
        public Image UrunResim 
        {
            get
            {
                if (!string.IsNullOrEmpty(ResimYol))
                    return Image.FromFile(ResimYol);
                else
                    return Image.FromFile(@"C:\Users\103AKSAM_EMRE\Desktop\aksamemre\photos\NoImage.jpg");
            }
   
        }
    }
}
