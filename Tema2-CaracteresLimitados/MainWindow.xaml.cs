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

namespace Tema2_CaracteresLimitados
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string texto = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void recuadroEscritura_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(int.Parse(conteoCaracteres.Text) < int.Parse(limitePalabras.Text))
            {
                texto = recuadroEscritura.Text;
            }
            recuadroEscritura.Text = texto;
            conteoCaracteres.Text = texto.Length.ToString();
            
            
        }
    }
}
