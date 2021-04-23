forma1
na pocetku forma za log in ili sign up
log in  - username; sifra
	- proverava oba iz dnevnika u kome se nalaze korisnici

sign up - username; sifra
	- upisuje u fajl u kome se nalaze korisnici
kada se uop-uje napravi se objekat korisnik

forma2
forma pocetna ima filmove displejovane iste za sve korisnike
kada se klikne ili hoveruje preko filma izadju njegove karakteristike
	- karakteristike filma
	- dugme gledaj film
	- dugme dodaj na listu koje dodaje film na listu filmova koje korisnik zeli da gleda (mozda fajl)
ako se dvoklikne na film moze da se gleda

pretrazivanje filmova - vrsi se pomocu liste svih filmova

fyle system watcher
da li mi trebaju lista svih filmova i gde ce se to praviti
gde ce se praviti dnevnik za korisnike







pokusavam da napravim picturebox kontejnere za slike filmova i svaki taj ima naziv kao id filma






while ((linija = sr.ReadLine()) != null)
            {
                PictureBox p = new PictureBox();
                p.Location = new Point(XKoordinata, YKoordinata);
                p.Name = brojac++.ToString();
                p.BackColor = Color.Red;
                /*p.Click += p_Click;
                Image img = Image.FromFile("landscape.jpg");*/
                //Image img = Image.FromFile("Filmovi.txt");
                //p.Image = img;
                //p.SizeMode = PictureBoxSizeMode.StretchImage;
                  
                Controls.Add(p);
                XKoordinata += 115;



            }
