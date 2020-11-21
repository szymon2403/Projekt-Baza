using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Baza
{
    class adress
    {
        public string ulica { get; set; }
        public string kodpocztowy { get; set; }
        public string miasto { get; set; }
        public string dzielnica { get; set; }  //dzielnica/wojewodztwo
        public string panstwo { get; set; }
        public bool IsKorespondencyjny;
        public adress(string ulica, string kodpocztowy, string miasto, string dzielnica, string panstwo,bool IsKorespondencyjny) 
        {
            this.ulica = ulica;
            this.kodpocztowy = kodpocztowy;
            this.miasto = miasto;
            this.dzielnica = dzielnica;
            this.panstwo = panstwo;
            this.IsKorespondencyjny = IsKorespondencyjny;
        }

        public adress()
        {
            this.ulica = "Oleska";
            this.kodpocztowy = "45-320";
            this.miasto = "Opole";
            this.dzielnica = "opolskie";
            this.panstwo = "Polska";
            this.IsKorespondencyjny = true;
        }
    }
}
