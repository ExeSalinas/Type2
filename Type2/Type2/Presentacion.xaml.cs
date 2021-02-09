using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Type2
{
    /// <summary>
    /// Lógica de interacción para Presentacion.xaml
    /// </summary>
    public partial class Presentacion : Window
    {
        public Presentacion(UIElementCollection collection)
        {
           
            InitializeComponent();

            foreach (UIElement item in collection)
            {
                mainPanel.Children.Add(item);

            }
        }
    }
}
