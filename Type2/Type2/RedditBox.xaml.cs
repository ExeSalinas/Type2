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
            this.velocidad_tipeo = milisVelocidadTipeo +15 ;
            rand = new Random(System.DateTime.Now.Millisecond);
            this.timer.Interval = new TimeSpan(0, 0, 0, 0,velocidad_tipeo);// INTERVALO  , BASADO EN LA VELOCIDAD QUE RECIBIO POR PARAM 
            this.timer.Tick += new EventHandler(TimerTick);
            SetString();
            this.timer.Start();
            var waitTask = Task.Run(async () =>
            {
                while (termino == false) await Task.Delay(100000);                
            });
            await waitTask;
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
        private async Task Termino()
        {   
           
        }
        void AddFollowingLetter()

        {
            txtContent.Text += this.stringToDisplay.Substring(whichLetter, 1);
            whichLetter++;

        }

    }
}
