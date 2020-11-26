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
    /// Interaction logic for KlantDetailsWindow.xaml
    /// </summary>
    public partial class KlantDetailsWindow : Window
    {
        public static List<string> behandelinglijstKleur = new List<string>();
        public static List<string> behandelinglijstPermanent = new List<string>();
        public static bool kleurOpen = false;
        public static bool permanentOpen = false;
        public KlantDetailsWindow()
        {
            InitializeComponent();
            InitialisatieTabel();
            Klant klant = KlantBestandWindow.selectedKlant;
            txtVoornaamKlantdetails.Text = klant.klant_voornaam;
            txtFamilienaamKlantdetails.Text = klant.klant_familienaam;
            txtStraatKlantdetails.Text = klant.klant_adres;
            txtStraatnummerKlantdetails.Text = klant.klant_adresnummer.ToString();
            txtStadKlantdetails.Text = klant.klant_plaats;
            txtPostcodeKlantdetails.Text = klant.klant_postcode;
            txtTelefoonKlantdetails.Text = klant.klant_telefoon;
            txtEmailKlantDetails.Text = klant.klant_e_mail;

            //wat nog te doen
            /*datagrid linken met juiste tabel die gelinkt is aan geselecteerde klant voor zowel kleur en permanent
             kleuren en permanenten kunnen toevoegen / wijzigen*/
            listKleurenKlantdetails.ItemsSource = behandelinglijstKleur;
        }

        private void btnOpslaanKlantdetails_Click(object sender, RoutedEventArgs e)
        {
            string foutmelding = Validatie();
            
            if (string.IsNullOrWhiteSpace(foutmelding))
            {
                KlantBestandWindow.selectedKlant.klant_voornaam = txtVoornaamKlantdetails.Text;
                KlantBestandWindow.selectedKlant.klant_familienaam = txtFamilienaamKlantdetails.Text;
                KlantBestandWindow.selectedKlant.klant_adres = txtStraatKlantdetails.Text;
                KlantBestandWindow.selectedKlant.klant_adresnummer = int.Parse(txtStraatnummerKlantdetails.Text);
                KlantBestandWindow.selectedKlant.klant_plaats = txtStadKlantdetails.Text;
                KlantBestandWindow.selectedKlant.klant_postcode = txtPostcodeKlantdetails.Text;
                KlantBestandWindow.selectedKlant.klant_telefoon = txtTelefoonKlantdetails.Text;
                KlantBestandWindow.selectedKlant.klant_e_mail = txtEmailKlantDetails.Text;

                DatabaseOperations.AanpassenKlant(KlantBestandWindow.selectedKlant);
                MessageBox.Show("Klant is aangepast");
                this.Close();   
            }
            else
            {
                MessageBox.Show(foutmelding);
            }

        }

        private void btnVerwijderenKlantdetails_Click(object sender, RoutedEventArgs e)
        {
            Klant klant = KlantBestandWindow.selectedKlant;
            DatabaseOperations.VerwijderenKlant(klant);
            KlantBestandWindow.klantenlijst.Remove(klant);
            MessageBox.Show("Klant is succesvol verwijderd");
            this.Close();
        }

        private void btnAanmakenKleurKlantdetails_Click(object sender, RoutedEventArgs e)
        {
            kleurOpen = true;
            var aanmaakBehandelingWindow = new AanmakenBehandelingWindow();
            aanmaakBehandelingWindow.ShowDialog();
            kleurOpen = false;
            listKleurenKlantdetails.Items.Refresh();
        }

        private void btnWijzigenKleurKlantdetails_Click(object sender, RoutedEventArgs e)
        {
            kleurOpen = true;
            var wijzigenWindow = new WijzigenRecordWindow();
            wijzigenWindow.ShowDialog();
            kleurOpen = false;
            listKleurenKlantdetails.Items.Refresh();
        }

        private void btnAanmakenPermanentKlantdetails_Click(object sender, RoutedEventArgs e)
        {
            permanentOpen = true;
            var wijzigenWindow = new WijzigenRecordWindow();
            wijzigenWindow.ShowDialog();
            permanentOpen = false;
            listKleurenKlantdetails.Items.Refresh();
        }

        private void btnWijzigenPermanentKlantdetails_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSluitenKlantdetails_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void InitialisatieTabel()
        {
            behandelinglijstKleur = new List<string>();
            behandelinglijstPermanent = new List<string>();

            OphalenBehandelingProduct(behandelinglijstKleur, "Kleur");
            OphalenBehandelingProduct(behandelinglijstPermanent, "Permanent");

            listKleurenKlantdetails.ItemsSource = behandelinglijstKleur;
            listPermanentenKlantdetails.ItemsSource = behandelinglijstPermanent;
            
        }

        private void OphalenBehandelingProduct(List<string>lijst, string productType)
        {
            foreach (Behandeling behandeling in DatabaseOperations.OphalenBehandeling(KlantBestandWindow.selectedKlant))
            {
                foreach (var behandelinglijn in behandeling.BehandelingLijn)
                {
                    if (behandelinglijn.Product.product_type == productType)
                    {
                        lijst.Add($"{behandelinglijn.Product.product_naam}\t\t-\t{behandelinglijn.Behandeling.behandeling_datum}");
                    }
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private string ConvertDate(DateTime date)
        {
            string month = "";
            string day = "";

            if (date.Day < 10)
            {
                day = $"0{date.Day}";
            }
            else
            {
                day = date.Day.ToString();
            }
            if (date.Month < 10)
            {
                month = $"0{date.Month}";
            }
            else
            {
                month = date.Month.ToString();
            }

            return $"{date.Year}/{month}/{day}";
        }
        public string Validatie() //!!!staat dubbel in andere window!!!
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
        private bool IsEmailAdress(string text) //werkt !!!staat dubbel in andere window!!!
        {
            return Regex.Match(text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success;
        }
        private bool IsPhoneNumber(string number) //werkt !!!staat dubbel in andere window!!!
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
    }
}
