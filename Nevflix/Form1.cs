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
using System.Text.RegularExpressions;

namespace Nevflix
{
    public partial class forma : Form
    {
        private List<Film> filmovi = new List<Film>();

        public forma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UcitajFilmoveUListu();
            UcitajFilmoveNaFormu(filmovi);
            UcitajComboBox();
            //MessageBox.Show(Ispis());

        }

        private string Ispis()
        {
            string s = "";
            foreach (var film in filmovi)
            {
                s += film + "\n";
            }
            return s;
        }

        /// <summary>
        /// ucitava filmove iz fajla u listu filmovi
        /// </summary>
        private void UcitajFilmoveUListu()
        {
            Regex izraz = new Regex(@"[0-9]+\|[a-z A-Z]+\|[0-9]{4}\|[a-z A-Z]+\|[0-9]+\|[1-5]{1}\.[0-9]{1}\|[a-z A-Z]+\|[a-z A-Z ,]+\|.+");
            StreamReader sr = new StreamReader("Filmovi.txt");
            string linija;
            while((linija = sr.ReadLine()) != null)
            {
                //ako se linija ne slaze sa regularnim izrazom preskoci je
                if (!izraz.IsMatch(linija))
                    continue;

                string[] objekat = linija.Split('|');
                int id = Convert.ToInt32(objekat[0]);
                int godina = Convert.ToInt32(objekat[2]);
                int vreme = Convert.ToInt32(objekat[4]);
                double rating = Convert.ToDouble(objekat[5]);
                Zanr zanr = (Zanr)Enum.Parse(typeof(Zanr), objekat[6]);

                Film film = new Film(id, objekat[1], godina, objekat[3], vreme, rating, zanr, objekat[7], objekat[9], objekat[8]);
                filmovi.Add(film);
            }
        }

        private void UcitajFilmoveNaFormu(List<Film> lista)
        {
            IzbrisiBoxove();
            int XKoordinata = 12;
            int YKoordinata = 196;
            int brojac = 0;
            foreach (var film in lista)
            {
                PictureBox p = new PictureBox();
                p.Location = new Point(XKoordinata, YKoordinata);
                p.Name = film.Id.ToString();
                p.BackColor = Color.Red;
                p.Load(film.UrlSlike);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(p);
                p.Click += this.PictureBox_Click;

                Button b = new Button();
                b.Location = new Point(XKoordinata, YKoordinata + 55);
                b.Text = "Gledaj";
                b.Name = film.Id.ToString();
                b.AccessibleName = film.Url;
                Controls.Add(b);
                b.Click += this.GledajButton_Click;
                //p.DoubleClick += this.PictureBox_DoubleClick;

                XKoordinata += 115;
                //ako je x koordinata veca ili jednaka sa x + width od forme --> povecaj y i resetuj x

            }
        }

        private void IzbrisiBoxove()
        {
            var PBs = this.Controls.OfType<PictureBox>().ToList();
            foreach (Control pb in PBs)
                if(pb.Name != "Nevflix")
                    this.Controls.Remove(pb);
        }

        //kasnije ce biti da ova metoda proverava da li se prosledjeni string nalazi u nazivu svakog filma
        //i ako se nalazi stavlja ga u listu koju kasnije prikazuje na formi
        private bool PretraziFilmove(string nazivFilma, out List<Film> movie)
        {
            List<Film> f = new List<Film>();
            foreach (var film in filmovi)
            {
                if(film.Naziv == nazivFilma)
                {
                    f.Add(film);
                }
            }
            if (f.Count == 0)
            {
                movie = null;
                return false;
            }
            movie = f;
            return true;
        }

        /// <summary>
        /// pretrazuje filmove po zanru koji je prosledjen stavlja ih u listu
        /// </summary>
        /// <param name="zanr"></param>
        /// <returns></returns>
        private bool PretraziFilmovePoZanru(Zanr zanr, out List<Film> lista)
        {
            List<Film> f = new List<Film>();
            foreach (var film in filmovi)
            {
                if (film.Zanr == zanr)
                    f.Add(film);
            }
            if (f.Count == 0)
            {
                lista = null;
                return false;
            }
            lista = f;
            return true;

        }
        private void UcitajComboBox()
        {
            foreach (var zanr in Enum.GetValues(typeof(Zanr)))
            {
                cbZanrovi.Items.Add(zanr);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            int ime = Convert.ToInt32(box.Name);
            MessageBox.Show(filmovi[ime-1].Opis, filmovi[ime-1].Naziv);
        }

        public static string prosledi;
        private void GledajButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            prosledi = b.AccessibleName;
            Video v = new Video();
            v.ShowDialog();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            List<Film> f = new List<Film>();
            
            if (e.KeyData == Keys.Enter)
            {
                if (PretraziFilmove(tbSearch.Text, out f))
                    UcitajFilmoveNaFormu(f);
                //zameni za label umesto messagebox
                else MessageBox.Show("nemamo taj film");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            UcitajFilmoveNaFormu(filmovi);
        }

        private void cbZanrovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("baljdf");
            //List <Film> lista = new List<Film>();

            //Zanr z =Enum.Parse(typeof(Zanr), cbZanrovi.SelectedItem.ToString());
            //PretraziFilmovePoZanru(z, out lista);
        }
        
    }
}
