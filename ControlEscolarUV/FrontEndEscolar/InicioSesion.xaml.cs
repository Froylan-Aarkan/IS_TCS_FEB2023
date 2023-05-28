using System;
using System.Windows;
using System.Windows.Media;

namespace FrontEndEscolar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            if (!hayCamposVacios())
            {
                //TODO
            }
        }

        private bool hayCamposVacios()
        {
            bool camposVacios = false;

            if (String.IsNullOrEmpty(tbUsuario.Text))
            {
                camposVacios = true;
                tbUsuario.BorderBrush = Brushes.Red;
            }
            else
            {
                tbUsuario.ClearValue(BorderBrushProperty);
            }

            if (String.IsNullOrEmpty(tbContrasenia.Text))
            {
                camposVacios = true;
                tbContrasenia.BorderBrush = Brushes.Red;
            }
            else
            {
                tbContrasenia.ClearValue(BorderBrushProperty);
            }

            return camposVacios;
        }
    }
}
