using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProyectoDSI
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Pausa : Page
    {
        public Pausa()
        {
            this.InitializeComponent();
        }

        private void Reanudar(object sender, RoutedEventArgs e)
        {
            On_BackRequested();
        }
        private void Reiniciar(object sender, RoutedEventArgs e)
        {

        }
        private void Ajustes(object sender, RoutedEventArgs e)
        {

        }
        private void Salir(object sender, RoutedEventArgs e)
        {

        }
        private void Ganar(object sender, RoutedEventArgs e)
        {

        }
        private void Perder(object sender, RoutedEventArgs e)
        {

        }
        private bool On_BackRequested()
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
                return true;
            }
            return false;
        }
    }
}
