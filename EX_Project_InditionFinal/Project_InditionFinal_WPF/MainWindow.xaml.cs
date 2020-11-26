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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_InditionFinal_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnKlantenbeheer_Click(object sender, RoutedEventArgs e)
        {
            var klantbestandWindow = new KlantBestandWindow();
            klantbestandWindow.ShowDialog();
        }

        private void btnOpties_Click(object sender, RoutedEventArgs e)
        {
            var optiesWindow = new OptiesWindows();
            optiesWindow.ShowDialog();
        }

        private void btnArchief_Click(object sender, RoutedEventArgs e)
        {
            var archiefWindow = new ArchiefWindow();
            archiefWindow.ShowDialog();
        }
    }
}
