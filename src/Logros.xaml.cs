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
    public sealed partial class Logros : Page
    {
        public ObservableCollection<VMLogro> ListaLogros { get; } = new ObservableCollection<VMLogro>();
        public Logros()
        {
            this.InitializeComponent();
        }

        //Método para mostrar los atributos de los logros
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                AppViewBackButtonVisibility.Collapsed;
            // Carga la lista de ModelView a partir de la lista de Modelo
            if (ListaLogros != null)
            {
                //Primero se agregan los bloqueados
                foreach (LogroID logro in Model.GetAllLogros())
                {
                    VMLogro VMitem = new VMLogro(logro);
                    if (VMitem.Estado == LogroID.estados.bloqueado)
                    {
                        ListaLogros.Add(VMitem);
                    }
                    //VMitem.Nombre = logro.Nombre;
                }
                //Después los desbloqueados
                foreach (LogroID logro in Model.GetAllLogros())
                {
                    //Primero se agregan los bloqueados
                    VMLogro VMitem = new VMLogro(logro);
                    if (VMitem.Estado == LogroID.estados.desbloqueado)
                    {
                        ListaLogros.Add(VMitem);
                    }
                    //VMitem.Nombre = logro.Nombre;
                }
            }
            listaLogros_.ItemsSource = ListaLogros;

            base.OnNavigatedTo(e);
        }
        //Método para cobrar la recompensa
        private void ChargeAward(object sender, RoutedEventArgs e) {
            if (ListaLogros != null) {
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
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
