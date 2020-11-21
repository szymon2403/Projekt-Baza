using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;

namespace Projekt_Baza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<pracownik> m_wListaPracownikow = null;
        public MainWindow()
        {
            InitializeComponent();
            InitBinding();
        }

        private void listapracownikow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Property okno  = new Property((pracownik)listapracownikow.SelectedItem);
            okno.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Property okno = new Property(new pracownik());
            okno.ShowDialog();
            m_wListaPracownikow.Add(okno.Return);
            listapracownikow.Items.Refresh();           
        }
        private void InitBinding() 
        {
            m_wListaPracownikow = new List<pracownik>();
            try 
            {
                using(var reader = new StreamReader("PersonList.xml")) 
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<pracownik>), new XmlRootAttribute("ArrayOfPerson"));
                    m_wListaPracownikow = (List<pracownik>)deserializer.Deserialize(reader);
                }
            }
            catch 
            {
                MessageBox.Show("Brak pliku do załadowania!", "Uwaga", MessageBoxButton.OK);
            }


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) 
        {
            var serializer = new XmlSerializer(m_wListaPracownikow.GetType());
            using(var writer = XmlWriter.Create("PersonList.xml")) 
            {
                serializer.Serialize(writer, m_wListaPracownikow);
            }
        }
    }
}
