using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevflix
{
    [Serializable]
    class User
    {
        string username;
        string sifra;

        public User(string username, string sifra)
        {
            this.Username = username;
            this.Sifra = sifra;
        }

        public string Username { get => username; set => username = value; }
        public string Sifra { get => sifra; set => sifra = value; }
    }
}
