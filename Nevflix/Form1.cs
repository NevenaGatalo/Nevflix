using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nevflix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UcitajFilmove();
        }
        private void UcitajFilmove()
        {
            StreamReader sr = new StreamReader("Filmovi.txt");
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    PictureBox p = new PictureBox();
                    p.Location = new Point(12, 196);
                    p.Click += p_Click;
                Image img = Image.FromFile("landscape.jpg");
                    //Image img = Image.FromFile("Filmovi.txt");
                    p.Image = img;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(p);

                
            }
            void p_Click(object sender, EventArgs e)
            {
                //string RowID = ((PictureBox)sender).Name;
                MessageBox.Show("opis filma");
            }

        }

        
    }
}
