using islamovski.fatih._4H.ReadCSV.Models;
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


namespace islamovski.fatih._4H.ReadCSV
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dgDati.ItemsSource = new Utenti("utente.csv");
            }
            catch (Exception errore)
            {
                MessageBox.Show(errore.Message);
            }

            private void gdDati_Loading(object sender, DataGridRowEventArgs e)
            {
                try
                {
                    if (e != null && e.Row != null)
                    {

                        Utente u = e.Row.Item as Utente;
                        if (u != null)
                            if (u.Tipo == "docente")
                                e.Row.Background = Brushes.Green;
                        if (u.Tipo == "studente")
                            e.Row.Background = Brushes.Blue;
                    }
                }
                catch { };
            }
        }
    }
}
