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
    /// Interaction logic for AanmakenBehandelingWindow.xaml
    /// </summary>
    public partial class AanmakenBehandelingWindow : Window
    {
        public AanmakenBehandelingWindow()
        {
            InitializeComponent();
            InitialisatiePagina();
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            string foutmelding = "";
            bool herhaling = false;
            //VALIDATIE
            //...Belangrijk, productAangeduid? Nota ingevuld?(optional) Check of behandeling ooit voorkwam?
            //VALIDATIE GESELECTEERDE PRODUCT
            if (cbxBehandelingen.SelectedItem != null)
            {
                foreach (string item in KlantDetailsWindow.behandelinglijstKleur)
                {
                    if (item.Contains(cbxBehandelingen.SelectedItem.ToString()))
                    {
                        MessageBox.Show("TRUE");
                        herhaling = true;
                    }
                }
            }
            else
            {
                foutmelding += "Er is geen product geselecteerd";
            }
            //END VALIDATIE
            if (string.IsNullOrWhiteSpace(foutmelding))
            {
                Behandeling nieuweBehandeling = new Behandeling();
                BehandelingLijn nieuweBehandelLijn = new BehandelingLijn();
                Product geselecteerdProduct = new Product();

                foreach (Product product in DatabaseOperations.OphalenProduct())
                {
                    if (product.product_naam == cbxBehandelingen.SelectedItem.ToString())
                    {
                        geselecteerdProduct.product_id = product.product_id;
                    }
                }

                /*Aanmaken Nieuwe Behandeling*/
                nieuweBehandeling.behandeling_klant = KlantBestandWindow.selectedKlant.klant_id;
                nieuweBehandeling.behandeling_nota = txtNota.Text;
                nieuweBehandeling.behandeling_datum = DateTime.Now;
                nieuweBehandeling.behandeling_isVoorafBehandeld = herhaling;

                /*Aanmaken Nieuwe Lijn*/
                nieuweBehandelLijn.behandelingLijn_behandeling = nieuweBehandeling.behandeling_id;
                nieuweBehandelLijn.behandelingLijn_product = geselecteerdProduct.product_id;

                DatabaseOperations.ToevoegenBehandeling(nieuweBehandeling, nieuweBehandelLijn);
                KlantDetailsWindow.behandelinglijstKleur.Add($"{cbxBehandelingen.SelectedItem.ToString()}\t\t-\t{nieuweBehandeling.behandeling_datum}");
                MessageBox.Show("Nieuwe behandeling is toegevoegd!");
                this.Close();
            }
            else
            {
                MessageBox.Show(foutmelding);
            }
        }

        private void btnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void InitialisatiePagina()
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
                foreach (var item in KlantDetailsWindow.behandelinglijstKleur)
                {
                    lblGeschiedenis.Content += $"{item}\n";
                }
                cbxBehandelingen.ItemsSource = lijstProducten;
                lblBehandelingAanmaken.Content = "Behandeling Kleur Toevoegen";
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
                foreach (var item in KlantDetailsWindow.behandelinglijstPermanent)
                {
                    lblGeschiedenis.Content += $"{item}\n";
                }
                cbxBehandelingen.ItemsSource = lijstProducten;
                lblBehandelingAanmaken.Content = "Behandeling Permanent Toevoegen";
                lblVoorKlant.Content = $"Voor {KlantBestandWindow.selectedKlant.klant_voornaam} {KlantBestandWindow.selectedKlant.klant_familienaam}";
            }
        }
    }
}
