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

namespace jabuke
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    enum Boje { Zelena, Crvena, Nedefinirana}
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<string> popisBoja = new List<string>();
        List<int> kolicinaJabuka = new List<int>();

        private void textboxBoja_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonZapamtiBroj_Click(object sender, RoutedEventArgs e)
        {
            popisBoja.Add(textBoxBoja.Text.ToString());
            kolicinaJabuka.Add(Int32.Parse(textBoxKoličina.Text.ToString()));
        }

        private void ButtonIzračunajZbrojKoličinaSvih_Click(object sender, RoutedEventArgs e)
        {
            int suma = 0;
            foreach(var item in kolicinaJabuka)
            {
                suma += item;
            }

            textBoxIspisZbrojKoličinaSvih.Text = suma.ToString();
        }

        private void ButtonPretraži_Click(object sender, RoutedEventArgs e)
        {
            var crvenih = 0;
            var zelenih = 0;
            var nedefiniranih = 0;

            for(var i=0; i<popisBoja.Count(); i++)
            {
                if(popisBoja[i].ToString() == "Crvena")
                {
                    crvenih += kolicinaJabuka[i];
                }
                else if(popisBoja[i].ToString() == "Zelena")
                {
                    zelenih += kolicinaJabuka[i];
                }
                else
                {
                    nedefiniranih += kolicinaJabuka[i];
                }
            }

            if(crvenih < zelenih && crvenih < nedefiniranih)
            {
                textBoxIspisNajmanjeJabukaBoje.Text = "Crvena";
            }
            if(zelenih < crvenih && zelenih < nedefiniranih)
            {
                textBoxIspisNajmanjeJabukaBoje.Text = "Zelena";
            }
            else
            {
                textBoxIspisNajmanjeJabukaBoje.Text = "Nedefinirana";
            }

        }
    }
}
