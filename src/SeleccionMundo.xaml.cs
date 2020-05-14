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
    public sealed partial class SeleccionMundo : Page
    {
        public SeleccionMundo()
        {
            this.InitializeComponent();
        }
        private void ranking_Click(object sender, RoutedEventArgs e)
        {
            On_BackRequested();
            this.Frame.Navigate(typeof(Ranking));
        }
        private void seleccion_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SeleccionZona));
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            On_BackRequested();
        }
        private bool On_BackRequested()
        {
            this.Frame.Navigate(typeof(MenuPrincipal));
            return true;
        }
        private void World_Click(object sender, PointerRoutedEventArgs e)
        {
            if (e.OriginalSource == World1)
            {
                Difficulty.Text = "Dificultad: Fácil";
                Races.Text = "Nº carreras: 5";
                MapAccess.Visibility = Visibility.Visible;
                Unlock.Visibility = Visibility.Collapsed;
            }
            else if (e.OriginalSource == World2)
            {
                Difficulty.Text = "Dificultad: Intermedia";
                Races.Text = "Nº carreras: 8";
                MapAccess.Visibility = Visibility.Collapsed;
                Unlock.Visibility = Visibility.Visible;
            }
            else if (e.OriginalSource == World3)
            {
                Difficulty.Text = "Dificultad: Difícil";
                Races.Text = "Nº carreras: 3";
                MapAccess.Visibility = Visibility.Collapsed;
                Unlock.Visibility = Visibility.Visible;
            }
        }
    }
}
