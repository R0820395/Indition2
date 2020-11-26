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
using System.Text.RegularExpressions;

namespace Project_InditionFinal_WPF
{
    /// <summary>
    /// Interaction logic for AanmakenKlantWindow.xaml
    /// </summary>
    public partial class AanmakenKlantWindow : Window
    {
        public AanmakenKlantWindow()
        {
            InitializeComponent();
        }

        private void btnOpslaanKlantdetails_Click(object sender, RoutedEventArgs e)
        {
            string foutmelding = Validatie();

            if (string.IsNullOrWhiteSpace(foutmelding))
            {
                //klant wordt toegevoegd
                Klant klant = new Klant();
                klant.klant_isArchived = false;
                klant.klant_voornaam = txtVoornaamKlantdetails.Text;
                klant.klant_familienaam = txtFamilienaamKlantdetails.Text;
                klant.klant_adres = $"{txtStraatKlantdetails.Text}";
                klant.klant_adresnummer = int.Parse(txtStraatnummerKlantdetails.Text);
                klant.klant_plaats = txtStadKlantdetails.Text;
                klant.klant_postcode = txtPostcodeKlantdetails.Text;
                klant.klant_telefoon = txtTelefoonKlantdetails.Text;
                klant.klant_e_mail = txtEmailKlantDetails.Text;
                DatabaseOperations.ToevoegenKlant(klant);
                KlantBestandWindow.klantenlijst.Add(klant);
                MessageBox.Show("Een nieuwe klant is aangemaakt");
                this.Close();
            }
            else
            {
                MessageBox.Show(foutmelding, "foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnVerwijderenKlantdetails_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsEmailAdress(string text) //werkt
        {
            return Regex.Match(text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success;
        }
        private bool IsPhoneNumber(string number) //werkt
        {
            return (Regex.Match(number, @"^03\d{7}$").Success
                || Regex.Match(number, @"^04\d{8}$").Success
                || Regex.Match(number, @"^\+324\d{8}$").Success);
        }
        private bool BevatNummer(string text)
        {
            bool isGetalAanwezig = text.Any(c => char.IsDigit(c));
            return isGetalAanwezig;
        }

        public string Validatie()
        {
            string foutmelding = "";
            //VALIDATIE VOORNAAM
            if (string.IsNullOrWhiteSpace(txtVoornaamKlantdetails.Text))
            {
                foutmelding += "De voornaam is niet ingevuld\n";
            }
            //VALIDATIE ACHTERNAAM
            if (string.IsNullOrWhiteSpace(txtFamilienaamKlantdetails.Text))
            {
                foutmelding += "De familienaam is niet ingevuld\n";
            }
            //VALIDATIE STRAAT ADRES + NUMMER
            if (string.IsNullOrWhiteSpace(txtStraatKlantdetails.Text) || BevatNummer(txtStraatKlantdetails.Text) != false)
            {
                foutmelding += "Geen geldige straatnaam ingevuld - straatnaam heeft geen nummers\n";
            }
            //VALIDATIE ADRES NUMMER
            if (!string.IsNullOrWhiteSpace(txtStraatnummerKlantdetails.Text))
            {
                if (int.TryParse(txtStraatnummerKlantdetails.Text, out int number) != true)
                {
                    foutmelding += "Straatnummer is numeriek\n";
                }
            }
            else
            {
                foutmelding += "Geen straatnummer ingevuld\n";
            }
            //VALIDATIE STAD/GEMEENTE
            if (string.IsNullOrWhiteSpace(txtStadKlantdetails.Text))
            {
                foutmelding += "De gemeente/stad is niet ingevuld\n";
            }
            //VALIDATIE POSTCODE
            if (!string.IsNullOrWhiteSpace(txtPostcodeKlantdetails.Text))
            {
                if (int.TryParse(txtPostcodeKlantdetails.Text, out int postcode))
                {
                    if (postcode < 1000 || postcode > 9999)
                    {
                        foutmelding += "Geen geldige postcode ingevuld\n";
                    }
                }
                else
                {
                    foutmelding += "Postcode moet numeriek zijn\n";
                }
            }
            else
            {
                foutmelding += "Geen postcode ingevuld\n";
            }
            //VALIDATIE TELEFOONNUMMER
            if (!string.IsNullOrWhiteSpace(txtTelefoonKlantdetails.Text))
            {
                if (IsPhoneNumber(txtTelefoonKlantdetails.Text) != true)
                {
                    foutmelding += "De ingevulde telefoonnummer is niet geldig\n";
                }
            }
            else
            {
                foutmelding += "Geen telefooonnummer ingevuld\n";
            }
            //VALIDATIE E-MAIL
            if (!string.IsNullOrWhiteSpace(txtEmailKlantDetails.Text)/*extra validatie email*/)
            {
                if (IsEmailAdress(txtEmailKlantDetails.Text) != true)
                {
                    foutmelding += "De ingevulde e-mail is niet geldig";
                }
            }
            else
            {
                foutmelding += "Geen geldig email adres ingevuld\n";
            }
            return foutmelding;
        }
    }
}
