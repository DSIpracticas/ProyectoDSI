using LogroDSI;
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
        private void MuestraLogro()
        {
            /*if (SelMos >= 0)
            {
                VMDron Sel = ListaDrones[SelMos];
                nameInfo.Text = "Id: ," + Sel.Id + ", Nombre: " + Sel.Nombre + ", Estado: " + Sel.Estado.ToString()
                    + ",\nREF: " + Sel.RX.ToString() + "," + Sel.RY.ToString() + " POS: " + Sel.X.ToString() + ", " + Sel.Y.ToString()
                    + "\nExplicación: " + Sel.Explicacion;
                imageDron.Source = Sel.Img.Source;
            }*/
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                AppViewBackButtonVisibility.Collapsed;
            // Carga la lista de ModelView a partir de la lista de Modelo
            if (ListaLogros != null)
                foreach (LogroID logro in LogroModel.GetAllLogros())
                {
                    VMLogro VMitem = new VMLogro(logro);
                    //VMitem.Nombre = logro.Nombre;
                    ListaLogros.Add(VMitem);
                }
            listaLogros_.ItemsSource = ListaLogros;

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
    }
}
