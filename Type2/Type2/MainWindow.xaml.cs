using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Type2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double velocidad = new Double();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void SliderVelocidad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            velocidad = SliderVelocidad.Value;
            txtVelocidad.Text = "Velocidad : " + velocidad.ToString("0");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        //    Presentacion pres = new Presentacion((int)SliderVelocidad.Value, textBoxPrincipal.Text);
        //    pres.Show();
        


        }

        private void AddButon_Click(object sender, RoutedEventArgs e)
        {
            RedditBox redditBox = new RedditBox();
            wrapView.Children.Add(redditBox);
        }
    }
}
