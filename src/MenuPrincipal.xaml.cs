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
    public sealed partial class MenuPrincipal : Page
    {
        public MenuPrincipal()
        {
            this.InitializeComponent();
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ajustes));
        }
        private void ranking_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ranking));
        }
        private void logros_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Logros));
        }
        private void garage_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(SeleccionCoche));
            this.Frame.Navigate(typeof(SeleccionCoche), true);
        }
        private void worldSelection_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SeleccionMundo));
        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
