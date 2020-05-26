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
        private int Money = 30000;

        public ObservableCollection<VMCar> ListaCoches { get; } = new ObservableCollection<VMCar>();

        public SeleccionCoche()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                AppViewBackButtonVisibility.Collapsed;
            // Carga la lista de ModelView a partir de la lista de Modelo
            if (ListaCoches != null)
                foreach (CarID currCar in CarModel.GetAllCars())
                {
                    VMCar VMitem = new VMCar(currCar);
                    //VMitem.Nombre = logro.Nombre;
                    ListaCoches.Add(VMitem);
                    if(VMitem.Estado == CarID.estados.bloqueado)
                    {

                    }
                }

            listaCoches_.ItemsSource = ListaCoches;

            if (e.Parameter is bool)
            {
                permitirCompra = (bool)e.Parameter;
            }

            if (permitirCompra)
            {
                BotonJugar.Visibility = Visibility.Collapsed;
            }

            DineroText.Text = "DINERO: " + Money.ToString() + "€";

            ActualizaDatos();

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
            this.Frame.Navigate(typeof(gameHUD));
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

        private void ImageGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (VMCar selectCar in e.AddedItems)
            {
                SelCar = selectCar.Posicion;
                ImagenesGrandes.SelectedIndex = SelCar;
            }
            ActualizaDatos();
        }

        private void ActualizaDatos()
        {
            //Dinero
            DineroText.Text = "DINERO: " + Money.ToString() + "€";

            //Muestra estrellas según la gama
            Estrella1.Visibility = Visibility.Collapsed;
            Estrella2.Visibility = Visibility.Collapsed;
            Estrella3.Visibility = Visibility.Collapsed;
            Estrella4.Visibility = Visibility.Collapsed;
            Estrella5.Visibility = Visibility.Collapsed;
            if (ListaCoches.ElementAt(SelCar).Gama >= 1) Estrella1.Visibility = Visibility.Visible;
            if (ListaCoches.ElementAt(SelCar).Gama >= 2) Estrella2.Visibility = Visibility.Visible;
            if (ListaCoches.ElementAt(SelCar).Gama >= 3) Estrella3.Visibility = Visibility.Visible;
            if (ListaCoches.ElementAt(SelCar).Gama >= 4) Estrella4.Visibility = Visibility.Visible;
            if (ListaCoches.ElementAt(SelCar).Gama == 5) Estrella5.Visibility = Visibility.Visible;

            //Actualiza Características
            //GamaText.Text = ListaCoches.ElementAt(SelCar).Gama.ToString();
            AceleracionText.Text = ListaCoches.ElementAt(SelCar).Aceleracion.ToString();
            AgarreText.Text = ListaCoches.ElementAt(SelCar).Agarre.ToString();
            AerodinamicaText.Text = ListaCoches.ElementAt(SelCar).Aerodinamica.ToString();
            SuspensionText.Text = ListaCoches.ElementAt(SelCar).Suspension.ToString();
            VelocidadText.Text = ListaCoches.ElementAt(SelCar).Velocidad.ToString();

            //Actualiza Mejoras
            Turbo.Text = "NIVEL TURBO " + ListaCoches.ElementAt(SelCar).Turbo.ToString();
            MejoraAceleracion.Text = "ACELERACION + " + ListaCoches.ElementAt(SelCar).Gama.ToString();
            Motor.Text = "NIVEL MOTOR " + ListaCoches.ElementAt(SelCar).Motor.ToString();
            MejoraVelocidad.Text = "VELOCIDAD + " + ListaCoches.ElementAt(SelCar).Gama.ToString();
            Amortiguadores.Text = "NIVEL AMORTIGUADORES " + ListaCoches.ElementAt(SelCar).Amortiguador.ToString();
            MejoraSuspension.Text = "SUSPENSIÓN + " + ListaCoches.ElementAt(SelCar).Gama.ToString();
            Neumaticos.Text = "NIVEL NEUMÁTICOS " + ListaCoches.ElementAt(SelCar).Neumaticos.ToString();
            MejoraAgarre.Text = "AGARRE + " + ListaCoches.ElementAt(SelCar).Gama.ToString();
            Carroceria.Text = "NIVEL CAROCERÍA " + ListaCoches.ElementAt(SelCar).Carroceria.ToString();
            MejoraAerodinamica.Text = "AERODINÁMCA + " + ListaCoches.ElementAt(SelCar).Gama.ToString();


            //Boton Turbo
            if (ListaCoches.ElementAt(SelCar).Turbo.ToString() == "5" || ListaCoches.ElementAt(SelCar).Estado == CarID.estados.bloqueado)
            {
                BotonMejoraAce.Visibility = Visibility.Collapsed;
                ImagenMejoraAce.Visibility = Visibility.Collapsed;
                TextoMejoraAce.Text = "";
            }
            else
            {
                BotonMejoraAce.Visibility = Visibility.Visible;
                ImagenMejoraAce.Visibility = Visibility.Visible;
                TextoMejoraAce.Text = (ListaCoches.ElementAt(SelCar).Gama * (ListaCoches.ElementAt(SelCar).Turbo + 1) * 100).ToString();
            }
            //Boton Motor
            if (ListaCoches.ElementAt(SelCar).Motor.ToString() == "5" || ListaCoches.ElementAt(SelCar).Estado == CarID.estados.bloqueado)
            {
                BotonMejoraVel.Visibility = Visibility.Collapsed;
                ImagenMejoraVel.Visibility = Visibility.Collapsed;
                TextoMejoraVel.Text = "";
            }
            else
            {
                BotonMejoraVel.Visibility = Visibility.Visible;
                ImagenMejoraVel.Visibility = Visibility.Visible;
                TextoMejoraVel.Text = (ListaCoches.ElementAt(SelCar).Gama * (ListaCoches.ElementAt(SelCar).Motor + 1) * 100).ToString();
            }
            //Boton Amortiguador
            if (ListaCoches.ElementAt(SelCar).Amortiguador.ToString() == "5" || ListaCoches.ElementAt(SelCar).Estado == CarID.estados.bloqueado)
            {
                BotonMejoraSus.Visibility = Visibility.Collapsed;
                ImagenMejoraSus.Visibility = Visibility.Collapsed;
                TextoMejoraSus.Text = "";
            }
            else
            {
                BotonMejoraSus.Visibility = Visibility.Visible;
                ImagenMejoraSus.Visibility = Visibility.Visible;
                TextoMejoraSus.Text = (ListaCoches.ElementAt(SelCar).Gama * (ListaCoches.ElementAt(SelCar).Amortiguador + 1) * 100).ToString();
            }
            //Boton Neumaticos
            if (ListaCoches.ElementAt(SelCar).Neumaticos.ToString() == "5" || ListaCoches.ElementAt(SelCar).Estado == CarID.estados.bloqueado)
            {
                BotonMejoraAga.Visibility = Visibility.Collapsed;
                ImagenMejoraAga.Visibility = Visibility.Collapsed;
                TextoMejoraAga.Text = "";
            }
            else
            {
                BotonMejoraAga.Visibility = Visibility.Visible;
                ImagenMejoraAga.Visibility = Visibility.Visible;
                TextoMejoraAga.Text = (ListaCoches.ElementAt(SelCar).Gama * (ListaCoches.ElementAt(SelCar).Neumaticos + 1) * 100).ToString();
            }
            //Boton Carroceria
            if (ListaCoches.ElementAt(SelCar).Carroceria.ToString() == "5" || ListaCoches.ElementAt(SelCar).Estado == CarID.estados.bloqueado)
            {
                BotonMejoraAer.Visibility = Visibility.Collapsed;
                ImagenMejoraAer.Visibility = Visibility.Collapsed;
                TextoMejoraAer.Text = "";
            }
            else
            {
                BotonMejoraAer.Visibility = Visibility.Visible;
                ImagenMejoraAer.Visibility = Visibility.Visible;
                TextoMejoraAer.Text = (ListaCoches.ElementAt(SelCar).Gama * (ListaCoches.ElementAt(SelCar).Carroceria + 1) * 100).ToString();
            }
            ////Si no hay NINGUN boton de mejorar, se desactiva el panel
            //if (mejorasCompletadas == 5 || ListaCoches.ElementAt(SelCar).Estado == CarID.estados.bloqueado) PanelBotonesMejorar.Visibility = Visibility.Collapsed;
            //else PanelBotonesMejorar.Visibility = Visibility.Visible;
            //PanelBotonesMejorar.Margin = new Thickness(0, 30.0 + desactivados * 72.0, 0, 0);

            //Actualiza el nombre del vehiculo
            NombreCoche.Text = ListaCoches.ElementAt(SelCar).Nombre;
            //Si está bloqueado se muestra el precio de compra, y un botón para desbloquearlo
            if (ListaCoches.ElementAt(SelCar).Estado == CarID.estados.bloqueado)
            {
                ImagenComprar.Visibility = Visibility.Visible;
                Candado.Visibility = Visibility.Visible;
                BotonComprar.Visibility = Visibility.Visible;
                CosteCompra.Visibility = Visibility.Visible;
                CosteCompra.Text = "COMPRAR: " + ListaCoches.ElementAt(SelCar).Coste.ToString() + "€";
            }
            //Si está desbloqueado no se ven
            else
            {
                Candado.Visibility = Visibility.Collapsed;
                ImagenComprar.Visibility = Visibility.Collapsed;
                BotonComprar.Visibility = Visibility.Collapsed;
                CosteCompra.Visibility = Visibility.Collapsed;
            }

            //Boton Jugar
            if (!permitirCompra && ListaCoches.ElementAt(SelCar).Estado == CarID.estados.desbloqueado)
            {
                BotonJugar.Visibility = Visibility.Visible;
                TextoJugar.Text = "JUGAR";
                ImagenJugar.Visibility = Visibility.Visible;
            }
            else
            {
                BotonJugar.Visibility = Visibility.Collapsed;
                TextoJugar.Text = "";
                ImagenJugar.Visibility = Visibility.Collapsed;
            }
        }

        private void ImagenesGrandes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListaCoches.Count > 0)
            {
                SelCar = ImagenesGrandes.SelectedIndex;
                listaCoches_.SelectedIndex = SelCar;
                ActualizaDatos();
            }
        }

        private void BotonMejoraAce_Click(object sender, RoutedEventArgs e)
        {
            int coste = ListaCoches.ElementAt(SelCar).Gama * (ListaCoches.ElementAt(SelCar).Turbo + 1) * 100;
            if (Money >= coste)
            {
                Money -= coste;
                ListaCoches.ElementAt(SelCar).Turbo++;
                ListaCoches.ElementAt(SelCar).Aceleracion += ListaCoches.ElementAt(SelCar).Gama;
                ActualizaDatos();
            }
        }

        private void BotonMejoraVel_Click(object sender, RoutedEventArgs e)
        {
            int coste = ListaCoches.ElementAt(SelCar).Gama * (ListaCoches.ElementAt(SelCar).Motor + 1) * 100;
            if (Money >= coste)
            {
                Money -= coste;
                ListaCoches.ElementAt(SelCar).Motor++;
                ListaCoches.ElementAt(SelCar).Velocidad += ListaCoches.ElementAt(SelCar).Gama;
                ActualizaDatos();
            }
        }

        private void BotonMejoraSus_Click(object sender, RoutedEventArgs e)
        {
            int coste = ListaCoches.ElementAt(SelCar).Gama * (ListaCoches.ElementAt(SelCar).Amortiguador + 1) * 100;
            if (Money >= coste)
            {
                Money -= coste;
                ListaCoches.ElementAt(SelCar).Amortiguador++;
                ListaCoches.ElementAt(SelCar).Suspension += ListaCoches.ElementAt(SelCar).Gama;
                ActualizaDatos();
            }
        }

        private void BotonMejoraAga_Click(object sender, RoutedEventArgs e)
        {
            int coste = ListaCoches.ElementAt(SelCar).Gama * (ListaCoches.ElementAt(SelCar).Neumaticos + 1) * 100;
            if (Money >= coste)
            {
                Money -= coste;
                ListaCoches.ElementAt(SelCar).Neumaticos++;
                ListaCoches.ElementAt(SelCar).Agarre += ListaCoches.ElementAt(SelCar).Gama;
                ActualizaDatos();
            }
        }

        private void BotonMejoraAer_Click(object sender, RoutedEventArgs e)
        {
            int coste = ListaCoches.ElementAt(SelCar).Gama * (ListaCoches.ElementAt(SelCar).Carroceria + 1) * 100;
            if (Money >= coste)
            {
                Money -= coste;
                ListaCoches.ElementAt(SelCar).Carroceria++;
                ListaCoches.ElementAt(SelCar).Aerodinamica += ListaCoches.ElementAt(SelCar).Gama;
                ActualizaDatos();
            }
        }
    }
}
