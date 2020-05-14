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
using System.Windows.Input;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProyectoDSI
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Ajustes : Page
    {
        //lista de teclas
        public List<Keys> keys { get; set; }
        public string[] keysChar = new string[] { "Q", "W", "E", "R", "T", "Y", "A", "S", "D", "F", "SPACE", "UP", "LEFT", "RIGTH", "DOWN" };
        public Ajustes()
        {
            this.InitializeComponent();
            initKeys();
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

        private void sounds_Click(object sender, RoutedEventArgs e)
        {
            keyPanel.Visibility = Visibility.Collapsed;
            graphicPanel.Visibility = Visibility.Collapsed;
            soundsPanel.Visibility = Visibility.Visible;
        }

        private void controls_Click(object sender, RoutedEventArgs e)
        {
            soundsPanel.Visibility = Visibility.Collapsed;
            graphicPanel.Visibility = Visibility.Collapsed;
            keyPanel.Visibility = Visibility.Visible;
        }

        private void graphic_Click(object sender, RoutedEventArgs e)
        {
            keyPanel.Visibility = Visibility.Collapsed;
            soundsPanel.Visibility = Visibility.Collapsed;
            graphicPanel.Visibility = Visibility.Visible;
        }

        private void initKeys()
        {
            //for (int i = 0; i < keysChar.Length; i++)
            //{
            //    Keys key = new Keys(keysChar[i]);
            //    keys.Add(key);
            //}
            //DataContext = this;
        }
    }

    public sealed partial class Keys
    {
        string key_ = "";
        public Keys(string key)
        {
            key_ = key;
        }
    }
}
