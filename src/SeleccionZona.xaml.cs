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
    public sealed partial class SeleccionZona : Page
    {
        public SeleccionZona()
        {
            this.InitializeComponent();
        }
        private void grarage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PostPartida));
            /*this.Frame.Navigate(typeof(SeleccionCoche));*/
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            On_BackRequested();
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
        private void Zone_Click(object sender, PointerRoutedEventArgs e)
        {
            if (e.OriginalSource == ZoneA)
            {
                Difficulty.Text = "Dificultad: Fácil";
                Type.Text = "Circuito";
                Laps.Text = "Nº de vueltas: 3";
                Reward1.Text = "1º: Fama: 500   Dinero: 600";
                Reward2.Text = "2º: Fama: 300   Dinero: 500";
                Reward3.Text = "3º: Fama: 100   Dinero: 400";
                RestReward.Text = "Resto: Fama: 0  Dinero: 200";
                Challenge.Visibility = Visibility.Visible;
                Unlock.Visibility = Visibility.Collapsed;
            }
            else if (e.OriginalSource == ZoneAA)
            {
                Difficulty.Text = "Dificultad: Fácil";
                Type.Text = "Aceleración";
                Laps.Text = "Nº de vueltas: 1";
                Reward1.Text = "1º: Fama: 800   Dinero: 800";
                Reward2.Text = "2º: Fama: 500   Dinero: 600";
                Reward3.Text = "3º: Fama: 300   Dinero: 500";
                RestReward.Text = "Resto: Fama: 0  Dinero: 300";
                Challenge.Visibility = Visibility.Visible;
                Unlock.Visibility = Visibility.Collapsed;
            }
            else if (e.OriginalSource == ZoneB)
            {
                Difficulty.Text = "Dificultad: Intermedia";
                Type.Text = "Drift";
                Laps.Text = "Nº de vueltas: 2";
                Reward1.Text = "1º: Fama: 1000   Dinero: 2000";
                Reward2.Text = "2º: Fama: 800     Dinero: 1500";
                Reward3.Text = "3º: Fama: 600     Dinero: 1000";
                RestReward.Text = "Resto: Fama: 0  Dinero: 500";
                Challenge.Visibility = Visibility.Collapsed;
                Unlock.Visibility = Visibility.Visible;
            }
            else if (e.OriginalSource == ZoneBB)
            {
                Difficulty.Text = "Dificultad: Intermedia";
                Type.Text = "Circuito";
                Laps.Text = "Nº de vueltas: 5";
                Reward1.Text = "1º: Fama: 1500   Dinero: 2600";
                Reward2.Text = "2º: Fama: 1300   Dinero: 2400";
                Reward3.Text = "3º: Fama: 1000   Dinero: 2200";
                RestReward.Text = "Resto: Fama: 0  Dinero: 800";
                Challenge.Visibility = Visibility.Collapsed;
                Unlock.Visibility = Visibility.Visible;
            }
            else if (e.OriginalSource == ZoneBBB)
            {
                Difficulty.Text = "Dificultad: Difícil";
                Type.Text = "Rally";
                Laps.Text = "Nº de vueltas: 1";
                Reward1.Text = "1º: Fama: 2500   Dinero: 3000";
                Reward2.Text = "2º: Fama: 2000   Dinero: 2700";
                Reward3.Text = "3º: Fama: 1700   Dinero: 2500";
                RestReward.Text = "Resto: Fama: 0  Dinero: 1000";
                Challenge.Visibility = Visibility.Collapsed;
                Unlock.Visibility = Visibility.Visible;
            }
        }
    }
}
