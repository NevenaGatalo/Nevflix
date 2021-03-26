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
        private string naziv;
        private double rating;
        private string opis;
        private List<string> glumci = new List<string>();
        private int vremeTrajanja;
        private Zanr zanr ;


        public override string ToString()
        {
            return $"naziv: {naziv}\n{opis}\nglumci: {glumci.ToString()}\nrating: {rating}\nvreme trajanja: {vremeTrajanja}";
        }
        public void PrikaziFilm()
        {
            
        }
    }
}
