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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Type2
{
    /// <summary>
    /// Lógica de interacción para RedditBox.xaml
    /// </summary>
    public partial class RedditBox : UserControl
    {
      public int order { get; set; }        
        public RedditBox()
        {
            InitializeComponent();

            //Thickness margin = wrapBox.Margin;
            //margin.Left = 30 * order;
            //wrapBox.Margin = margin;
        }

        
       

        private void btnReply_Click(object sender, RoutedEventArgs e)
        {
            RedditBox redditBox = new RedditBox();
            redditBox.order = this.order+1;

            wrapResponse.Children.Add(redditBox);
            

        }
    }
}
