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

namespace ProyectoSegundoParcialFinal
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

        private void CbProducto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdProducto.Children.Clear();
        }

        private void Btnagregar_Click(object sender, RoutedEventArgs e)
        {
            switch (cbProducto.SelectedIndex)
            {
                case 0:
                    grdProducto.Children.Add(new Anillo2());
                    break;
                case 1:
                    grdProducto.Children.Add(new Camiseta2());
                    break;
                case 2:
                    grdProducto.Children.Add(new Traje2());
                    break;
                case 3:
                    grdProducto.Children.Add(new Short());
                    break;
                case 4:
                    grdProducto.Children.Add(new Pantalon());
                    break;
                case 5:
                    grdProducto.Children.Add(new Chamarra());
                    break;
                case 6:
                    grdProducto.Children.Add(new Saco());
                    break;

                default:
                    break;
            }
        }
    }
}
