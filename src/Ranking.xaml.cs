using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
    public sealed partial class Ranking : Page
    {
        public ObservableCollection<VMRanking> ListaRanking { get; } = new ObservableCollection<VMRanking>();
        public Ranking()
        {
            this.InitializeComponent();
        }

        private void MuestraInfo(VMRanking ranking)
        {
            ranking.FamaText = "Fama necesaria: " + ranking.Fama + " Seguidores";
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                AppViewBackButtonVisibility.Collapsed;
            // Carga la lista de ModelView a partir de la lista de Modelo
            if (ListaRanking != null)
            {
                int id = 0;
                //Primero los incompletos
                foreach (RankingID ranking in Model.GetAllRanking())
                {
                    VMRanking VMitem = new VMRanking(ranking);
                    if (VMitem.Estado == RankingID.estados.incompleto)
                    {
                        VMitem.Id = id;
                        VMitem.Imagen = "Assets/barraRoja.png";
                        ListaRanking.Add(VMitem);
                        MuestraInfo(VMitem);
                        id++;
                    }
                }
                //Después el siguiente contrincante
                foreach (RankingID ranking in Model.GetAllRanking())
                {
                    VMRanking VMitem = new VMRanking(ranking);
                    if (VMitem.Estado == RankingID.estados.siguiente)
                    {
                        VMitem.Id = id;
                        VMitem.Imagen = "Assets/barraVerde.png";
                        ListaRanking.Add(VMitem);
                        MuestraInfo(VMitem);
                        id++;
                    }
                }
                //Después el player
                foreach (RankingID ranking in Model.GetAllRanking())
                {
                    VMRanking VMitem = new VMRanking(ranking);
                    if (VMitem.Estado == RankingID.estados.player)
                    {
                        VMitem.Id = id;
                        VMitem.FamaText = "Fama actual: " + VMitem.Fama + " Followers";
                        VMitem.Imagen = "Assets/barraAmarilla.png";
                        ListaRanking.Add(VMitem);
                        id++;
                    }
                }
                //Por último los completados
                foreach (RankingID ranking in Model.GetAllRanking())
                {
                    VMRanking VMitem = new VMRanking(ranking);
                    if (VMitem.Estado == RankingID.estados.completado)
                    {
                        VMitem.Id = id;
                        VMitem.FamaText = "Derrotado";
                        VMitem.Imagen = "Assets/barraGris.png";
                        ListaRanking.Add(VMitem);
                        id++;
                    }
                }
            }
            listaRanking_.ItemsSource = ListaRanking;

            base.OnNavigatedTo(e);
        }
        private void garage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SeleccionCoche), false);
        }
        private void worldSelection_Click(object sender, RoutedEventArgs e)
        {
            On_BackRequested();
            this.Frame.Navigate(typeof(SeleccionMundo));
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
    }
}
