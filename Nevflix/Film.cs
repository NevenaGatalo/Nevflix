using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevflix
{
    enum Zanr { triler, horor, ljubic, akcija, komedija, dokumentarac}
    class Film
    {
        private int id;
        private string naziv;
        private int godina;
        private string opis;
        private int vremeTrajanja; //u mintima
        private double rating;
        private Zanr zanr;
        private string glumci;
        private string urlSlike;
        private string url;

        
        public string Url { get => url; }
        public int Id { get => id; }
        public string UrlSlike { get => urlSlike; }
        public string Opis { get => opis; }
        public string Naziv { get => naziv; }
        internal Zanr Zanr { get => zanr; }

        public Film() { }

        public Film(int id, string naziv, int godina, string opis, int vremeTrajanja, double rating, Zanr zanr, string glumci, string urlSlike, string url)
        {
            this.id = id;
            this.naziv = naziv;
            this.godina = godina;
            this.opis = opis;
            this.vremeTrajanja = vremeTrajanja;
            this.rating = rating;
            this.zanr = zanr;
            this.glumci = glumci;
            this.urlSlike = urlSlike;
            this.url = url;
        }

        public override string ToString()
        {
            return $"id: {Id}\nnaziv: {Naziv}\ngodina: {godina}\nvreme trajanja: {vremeTrajanja}\nrating: {rating}\nzanr: {Zanr}\n{Opis}\nglumci: {glumci}";
        }
        public void PrikaziFilm()
        {
            
        }
    }
}
