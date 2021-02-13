using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace Type2
{
    /// <summary>
    /// Lógica de interacción para RedditBox.xaml
    /// </summary>
    public partial class RedditBox : UserControl
    {

        private DispatcherTimer timer = new DispatcherTimer();
        private string stringToDisplay;       
        private Random rand;
        private int velocidad_tipeo;
        private int whichLetter = 0;
        private bool termino;


        public int order { get; set; }        
        public RedditBox()
        {
            InitializeComponent();
        }


        private void btnReply_Click(object sender, RoutedEventArgs e)
        {
            RedditBox redditBox = new RedditBox();
            redditBox.order = this.order+1;

            wrapResponse.Children.Add(redditBox);
            
           
        }
        
        public async Task typewriting(int milisVelocidadTipeo )
        {
            if (!this.IsEnabled) { return; }
            
            btnVisibiliy(btnEliminar, false);

            UIElementCollection reditboxcollection= wrapResponse.Children ;
            foreach (UIElement reditBox in reditboxcollection)
            {
                reditBox.Visibility = Visibility.Collapsed;
               
            }

            
            termino = false;
            this.velocidad_tipeo = 300 - milisVelocidadTipeo ;
            rand = new Random(System.DateTime.Now.Millisecond);
            this.timer.Interval = new TimeSpan(0, 0, 0, 0,velocidad_tipeo);// INTERVALO  , BASADO EN LA VELOCIDAD QUE RECIBIO POR PARAM 
            var tick = new EventHandler(TimerTick);
            this.timer.Tick += tick;
            SetString();
            this.timer.Start();
            
            await Termino(velocidad_tipeo, -1);
            this.timer.Tick -= tick;
           


            foreach (UIElement rb in reditboxcollection)
            {

                if (rb.IsEnabled) { rb.Visibility = Visibility.Visible; }
                RedditBox redditBox = (RedditBox)rb;
                await redditBox.typewriting(milisVelocidadTipeo);
               

            }
            btnVisibiliy(btnEliminar, true);
        }

        private void btnVisibiliy(Button button, bool enabled)
        {
            if (enabled)
            {
                button.Visibility = Visibility.Visible;
                button.IsEnabled = true;

            }
            else
            {
                button.Visibility = Visibility.Hidden;
                button.IsEnabled = false;
                

            }
        }

        public void SetString()
        {   whichLetter = 0;
            this.stringToDisplay = txtContent.Text;
            txtContent.Text = "";         
            
        }

        private void TimerTick(object sender, EventArgs e)

        {           

            //Let's change the time that the following letter will last to appear (just to simulate not-synchronous-writing) 
            this.timer.Stop();

            this.timer.Interval = new TimeSpan(0, 0, 0, 0, rand.Next(0, velocidad_tipeo)); //the following letter will appear in a period between the next 0 and 200 milliseconds.

            if (whichLetter < this.stringToDisplay.Length)

            {
                AddFollowingLetter();
                timer.Start();
            }
            else
            {
                termino = true;
            }
            

        }
        
        bool Condition()
        {
            if (termino) { return true; }
            return false;
        }

        public  async Task Termino(int frequency = 25, int timeout = -1)
        {
            var waitTask = Task.Run(async () =>
            {
                while (termino == false) await Task.Delay(100);
            });

            await waitTask;
            //if (waitTask != await Task.WhenAny(waitTask, Task.Delay(timeout)))
            //    throw new TimeoutException();
        }
        
        void AddFollowingLetter()

        {
            txtContent.Text += this.stringToDisplay.Substring(whichLetter, 1);
            whichLetter++;

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            this.Visibility = Visibility = Visibility.Collapsed;
            

        }
    }
}
