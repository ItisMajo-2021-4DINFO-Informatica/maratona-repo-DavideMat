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

namespace MatulloEsercitazioneApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Maratone maratone;
        public MainWindow()
        {
            InitializeComponent();
            maratone = new Maratone();
            dgElenco.ItemsSource = maratone.ElencoMaratone;
        }

        private void btnLeggifile_Click(object sender, RoutedEventArgs e)
        {
            maratone.LeggiDati();
            dgElenco.Items.Refresh();
        }

        private void btnTempoInMinuti_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtNome.Text;
            string città = txtCittà.Text;

            string tempoinminuti = maratone.CercaTempo(nome, città);

        }
    }
}
