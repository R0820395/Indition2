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
using Project_InditionFinal_DAL;
using System.Data.Entity;

namespace Project_InditionFinal_WPF
{
    /// <summary>
    /// Interaction logic for KlantBestandWindow.xaml
    /// </summary>
    public partial class KlantBestandWindow : Window
    {
        public static List<Klant> klantenlijst = new List<Klant>();
        public static Klant selectedKlant;
        public KlantBestandWindow()
        {
            InitializeComponent();
            InitialisatieTabel();
        }

        private void btnKlantaanmakenKlantbestand_Click(object sender, RoutedEventArgs e)
        {
            var aanmaakWindow = new AanmakenKlantWindow();
            aanmaakWindow.ShowDialog();
            dataKlantbestand.Items.Refresh();
        }

        private void btnKlantZoekenKlantbestand_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnKlantBewerken_Click(object sender, RoutedEventArgs e)
        {
            if (dataKlantbestand.SelectedItem is Klant klant)
            {
                selectedKlant = klant;
                var detailWindow = new KlantDetailsWindow();
                detailWindow.ShowDialog();
                dataKlantbestand.Items.Refresh();
            }
        }

        private void btnSluitenKlantbestand_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void InitialisatieTabel()
        {
            klantenlijst = new List<Klant>();
            foreach (Klant klant in DatabaseOperations.OphalenKlant())
            {
                klantenlijst.Add(klant);
            }
            dataKlantbestand.ItemsSource = klantenlijst;
        }
    }
}
