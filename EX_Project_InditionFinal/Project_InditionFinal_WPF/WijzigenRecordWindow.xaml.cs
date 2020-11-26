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

namespace Project_InditionFinal_WPF
{
    /// <summary>
    /// Interaction logic for WijzigenRecordWindow.xaml
    /// </summary>
    public partial class WijzigenRecordWindow : Window
    {
        public WijzigenRecordWindow()
        {
            InitializeComponent();
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAnnuleren_Click(object sender, RoutedEventArgs e)
        {

        }
        private void InitiatieTabel()
        {
            List<string> lijstProducten = new List<string>();
            if (KlantDetailsWindow.kleurOpen == true)
            {
                lijstProducten = new List<string>();
                foreach (Product product in DatabaseOperations.OphalenProduct())
                {
                    if (product.product_type == "Kleur")
                    {
                        lijstProducten.Add(product.product_naam);
                    }
                }

                cbxBehandelingen.ItemsSource = lijstProducten;
                lblBehandelingWijzigen.Content = "Behandeling Kleur Toevoegen";
                lblVoorKlant.Content = $"Voor {KlantBestandWindow.selectedKlant.klant_voornaam} {KlantBestandWindow.selectedKlant.klant_familienaam}";
            }
            if (KlantDetailsWindow.permanentOpen == true)
            {
                lijstProducten = new List<string>();
                foreach (Product product in DatabaseOperations.OphalenProduct())
                {
                    if (product.product_type == "Permanent")
                    {
                        lijstProducten.Add(product.product_naam);
                    }
                }

                cbxBehandelingen.ItemsSource = lijstProducten;
                lblBehandelingWijzigen.Content = "Behandeling Kleur Toevoegen";
                lblVoorKlant.Content = $"Voor {KlantBestandWindow.selectedKlant.klant_voornaam} {KlantBestandWindow.selectedKlant.klant_familienaam}";
            }
        }
    }
}
