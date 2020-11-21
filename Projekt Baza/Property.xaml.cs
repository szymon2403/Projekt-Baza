using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekt_Baza
{
    /// <summary>
    /// Interaction logic for Property.xaml
    /// </summary>
    public partial class Property : Window
    {
        public Property(pracownik osoba)
        {
            InitializeComponent();
            mvarOsoba = osoba;
            this.DataContext = mvarOsoba;
            foreach (Adress adres in mvarOsoba.Adres)
            {
                //ctlTab.Items.Add(new AdresForm(adres));
            }

        }
        private pracownik mvarOsoba;
        public pracownik Return { get; set; }

        private void Window_Closed(object sender, EventArgs e)
        {
            Return = (pracownik)this.DataContext;
        }

        private void DodajAdres(object sender, RoutedEventArgs e)
        {

        }

        private void UsunAdres(object sender, RoutedEventArgs e)
        {

        }
    }
}
