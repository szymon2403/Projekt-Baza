using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Baza
{
    class Adress
    {
        public string Ulica { get; set; }
        public string Kodpocztowy { get; set; }
        public string Miasto { get; set; }
        public string Dzielnica { get; set; }  //dzielnica/wojewodztwo
        public string Panstwo { get; set; }
        public bool IsKorespondencyjny;
        public Adress(string ulica, string kodpocztowy, string miasto, string dzielnica, string panstwo,bool IsKorespondencyjny) 
        {
            this.Ulica = ulica;
            this.Kodpocztowy = kodpocztowy;
            this.Miasto = miasto;
            this.Dzielnica = dzielnica;
            this.Panstwo = panstwo;
            this.IsKorespondencyjny = IsKorespondencyjny;
        }

        public Adress()
        {
            this.Ulica = "Oleska";
            this.Kodpocztowy = "45-320";
            this.Miasto = "Opole";
            this.Dzielnica = "opolskie";
            this.Panstwo = "Polska";
            this.IsKorespondencyjny = true;
        }
    }
}
