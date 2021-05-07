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
    public partial class Logovanje : Form
    {
        private Dictionary<string, User> Users = new Dictionary<string, User>();
        public Logovanje()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //DeserializeUDictionary();
            UcitajUDictionary();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Provera();
            if (Users.ContainsKey(tbUsername.Text))
                throw new Exception("Ovaj nalog vec postoji");
            else
            {
                StreamWriter sw = new StreamWriter("Users.txt", true);
                string text = "\n" + tbUsername.Text + "|" + tbPassword.Text;
                sw.Write(text);
                User u = new User(tbUsername.Text, tbPassword.Text);
                Users.Add(u.Username, u);
                sw.Close();
                /*FileStream fs = new FileStream("Users.txt", FileMode.Append);
                BinarniFajl bf = new BinarniFajl();
                bf.Serialize(u, fs);*/

                this.Close();
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Provera();
            if (!Users.ContainsKey(tbUsername.Text))
                throw new Exception("Ovaj nalog ne postoji!");
            else
                this.Close();
                
        }
        /*private void DeserializeUDictionary()
        {
            FileStream fs = new FileStream("Users.txt", FileMode.OpenOrCreate);
            BinarniFajl bf = new BinarniFajl();
            User a = bf.Deserialize(fs);
            Users.Add(a.Username, a);
        }*/
        private void UcitajUDictionary()
        {
            StreamReader sr = new StreamReader("Users.txt");
            string linija;
            while ((linija = sr.ReadLine()) != null)
            {
                string[] objekat = linija.Split('|');
                User u = new User(objekat[0], objekat[1]);
                Users.Add(u.Username, u);
            }
            sr.Close();
        }

        private void Provera()
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
                throw new Exception("Morate uneti i username i sifru!");
        }
    }
}
