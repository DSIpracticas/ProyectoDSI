﻿using System;
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
    public sealed partial class SeleccionCoche : Page
    {
        bool permitirCompra = false;

        public SeleccionCoche()
        {
            this.InitializeComponent();
            if (permitirCompra)
            {
                BotonJugar.Visibility = Visibility.Collapsed;
            }
            else
            {
                BotonComprar.Visibility = Visibility.Collapsed;
                CosteCompra.Visibility = Visibility.Collapsed;
            }
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

        }

        private void ImageGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Image item = e.ClickedItem as Image;
            ImagenMostrada.Source = item.Source;
        }

        private void ImageGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Image item in e.AddedItems)
            {
                //item.CCImg.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            foreach (Image item in e.RemovedItems)
            {
                //item.CCImg.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }
    }
}
