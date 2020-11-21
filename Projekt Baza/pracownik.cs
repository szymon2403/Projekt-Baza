using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<adress> Adres { get; set; }

    }
}
