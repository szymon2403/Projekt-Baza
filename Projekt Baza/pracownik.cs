using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

namespace Projekt_Baza
{
    class pracownik
    {
        public int idpracownika { get; set; }
        public string nazwisko { get; set; }
        public string imie { get; set; }
        public int pesel { get; set; }
        public string stanowisko { get; set; }
        public int wiek { get; set; }
        public List<Adress> Adres { get; set; }
        public BitmapImage obrazek { get; set; }

        //[XmlElement("LargeIcon")]
        [XmlIgnore]
        public byte[] LargeIconSerialized
        {
            get
            {
                if (obrazek == null) return null;
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(obrazek));
                using(MemoryStream ms = new MemoryStream())
                {
                    encoder.Save(ms);
                    return ms.ToArray();
                }
            }
            set
            {
                //deserialize
                if (value == null)
                {
                    obrazek = null;
                }
                else
                {
                    using(MemoryStream ms = new MemoryStream(value))
                    {
                        obrazek = new BitmapImage();
                        obrazek.BeginInit();
                        obrazek.CacheOption = BitmapCacheOption.OnLoad;
                        obrazek.StreamSource = ms;
                        obrazek.EndInit();
                    }
                }
            }
        }

        public pracownik(int nidpracownika, string nnazwisko, string nimie, int npesel, int nwiek, string nstanowisko)
        {
            idpracownika = nidpracownika;
            nazwisko = nnazwisko;
            imie = nimie;
            pesel = npesel;
            wiek = nwiek;
            stanowisko = nstanowisko;
            obrazek = new BitmapImage();
            obrazek.BeginInit();
            obrazek.UriSource = new Uri(@"C:\Users\szymp\Desktop\screen.png", UriKind.Absolute);
            obrazek.EndInit();
            Adres = new List<Adress>();
        }
        public pracownik()
        {

        }
    }
}
