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
        int velocidad = new Int16();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void SliderVelocidad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            velocidad = (int)SliderVelocidad.Value;
            txtVelocidad.Text = "Velocidad : " + velocidad.ToString("0");

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            btnPlay.IsEnabled = false;
            AddButon.IsEnabled = false;
            UIElementCollection reditboxcollection= mainPanel.Children;
            foreach (UIElement reditBox in reditboxcollection)
            {   
                reditBox.Visibility = Visibility.Collapsed;
                
            }
            scrollViewer.ScrollToVerticalOffset(scrollViewer.ExtentHeight);
           
            foreach (UIElement rb in reditboxcollection)
            {
                if (rb.IsEnabled) { rb.Visibility = Visibility.Visible; }
                
                RedditBox redditBox = (RedditBox)rb;
                await redditBox.typewriting(velocidad);
               
                
            }
            btnPlay.IsEnabled = true;
            AddButon.IsEnabled = true;
            //var sended = false;
            //int cont = 0;
            // while (cont < reditboxcollection.Count)
            // {
            //    UIElement uIElement = reditboxcollection[cont];
            //    RedditBox redditBox = (RedditBox)uIElement;
            //    if (sended)
            //    {   
            //        uIElement.Visibility = Visibility.Visible;

            //        redditBox.typewriting(velocidad);
            //        sended = true;
            //    }
            //    if (redditBox.termino) { cont++;sended = false; }
            //    redditBox.
            // }


        }

        private void AddButon_Click(object sender, RoutedEventArgs e)
        {
            RedditBox redditBox = new RedditBox();
            mainPanel.Children.Add(redditBox);
        }

    }
}
