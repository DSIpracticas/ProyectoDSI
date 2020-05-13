using CocheDSI;
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
    public sealed partial class SeleccionCoche : Page
    {
        //Permite compra si se accede desde Garage, no la permite si se accede antes de jugar
        bool permitirCompra = true;

        //Coche seleccionado (0-12)
        private int SelCar = 0;

        //Dinero
        private int Money = 3000;

        public ObservableCollection<VMCar> ListaCoches { get; } = new ObservableCollection<VMCar>();

        public SeleccionCoche()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is bool)
            {
                permitirCompra = (bool)e.Parameter;
            }

            if (permitirCompra)
            {
                BotonJugar.Visibility = Visibility.Collapsed;
            }
            //else
            //{
            //    BotonComprar.Visibility = Visibility.Collapsed;
            //    CosteCompra.Visibility = Visibility.Collapsed;
            //}

            DineroText.Text = "DINERO: " + Money.ToString() + "€";

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                AppViewBackButtonVisibility.Collapsed;
            // Carga la lista de ModelView a partir de la lista de Modelo
            if (ListaCoches != null)
                foreach (CarID currCar in CarModel.GetAllCars())
                {
                    VMCar VMitem = new VMCar(currCar);
                    //VMitem.Nombre = logro.Nombre;
                    ListaCoches.Add(VMitem);
                }
            listaCoches_.ItemsSource = ListaCoches;

            base.OnNavigatedTo(e);
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
        private void Jugar(object sender, RoutedEventArgs e)
        {

        }
        private void Comprar(object sender, RoutedEventArgs e)
        {
            if(Money >= ListaCoches.ElementAt(SelCar).Coste)
            {
                Money -= ListaCoches.ElementAt(SelCar).Coste;
                ListaCoches.ElementAt(SelCar).Estado = CarID.estados.desbloqueado;
                ActualizaDatos();
            } 
        }

        private void ImageGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Image item = e.ClickedItem as Image;
        }

        private void ImageGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //VMCar selectCar = e.AddedItems as VMCar;
            foreach (VMCar selectCar in e.AddedItems)
            {
                SelCar = selectCar.Posicion;
            }
            ActualizaDatos();
        }

        private void FlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ActualizaDatos()
        {
            //Dinero
            DineroText.Text = "DINERO: " + Money.ToString() + "€";

            //Actualiza Características
            GamaText.Text = ListaCoches.ElementAt(SelCar).Gama.ToString();
            AceleracionText.Text = ListaCoches.ElementAt(SelCar).Aceleracion.ToString();
            AgarreText.Text = ListaCoches.ElementAt(SelCar).Agarre.ToString();
            AerodinamicaText.Text = ListaCoches.ElementAt(SelCar).Aerodinamica.ToString();
            SuspensionText.Text = ListaCoches.ElementAt(SelCar).Suspension.ToString();
            VelocidadText.Text = ListaCoches.ElementAt(SelCar).Velocidad.ToString();

            //Actualiza Mejoras


            //Actualiza la foto mostrada (no funciona)
            //ImagenGrande.Source = ListaCoches.ElementAt(SelCar).Source;
            NombreCoche.Text = ListaCoches.ElementAt(SelCar).Nombre;
            //Si está bloqueado se muestra el precio de compra, y un botón para desbloquearlo
            if (permitirCompra && ListaCoches.ElementAt(SelCar).Estado == CarID.estados.bloqueado)
            {
                BotonComprar.Visibility = Visibility.Visible;
                CosteCompra.Visibility = Visibility.Visible;
                CosteCompra.Text = "COSTE: " + ListaCoches.ElementAt(SelCar).Coste.ToString() + "€";
            }
            //Si está desbloqueado no se ven
            else
            {
                BotonComprar.Visibility = Visibility.Collapsed;
                CosteCompra.Visibility = Visibility.Collapsed;
            }
        }
    }
}
