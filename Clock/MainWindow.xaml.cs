using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;
            timer.Tick += tickevent;
            timer.Tick += tickevent2;
            timer.Start();
            imgDesign1.Opacity = 100;
            imgDesign2.Opacity = 0;
            imgDesign3.Opacity = 0;
            imgDesign4.Opacity = 0;
            imgDesign5.Opacity = 0;
        }

        private void tickevent2(object sender, EventArgs e)
        {
            datelbl2.Text = DateTime.Now.ToLongDateString();
        }

        private void tickevent(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RotationSecond.Angle = 6 * DateTime.Now.Second;
            RotationMinute.Angle = 6 * DateTime.Now.Minute;
            RotationHour.Angle = 30 * DateTime.Now.Hour + 5 * (DateTime.Now.Minute / 10);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            imgDesign1.Opacity = 100;
            imgDesign2.Opacity = 0;
            imgDesign3.Opacity = 0;
            imgDesign4.Opacity = 0;
            imgDesign5.Opacity = 0;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            imgDesign1.Opacity = 0;
            imgDesign2.Opacity = 100;
            imgDesign3.Opacity = 0;
            imgDesign4.Opacity = 0;
            imgDesign5.Opacity = 0;
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            imgDesign1.Opacity = 0;
            imgDesign2.Opacity = 0;
            imgDesign3.Opacity = 100;
            imgDesign4.Opacity = 0;
            imgDesign5.Opacity = 0;
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            imgDesign1.Opacity = 0;
            imgDesign2.Opacity = 0;
            imgDesign3.Opacity = 0;
            imgDesign4.Opacity = 100;
            imgDesign5.Opacity = 0;
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            imgDesign1.Opacity = 0;
            imgDesign2.Opacity = 0;
            imgDesign3.Opacity = 0;
            imgDesign4.Opacity = 0;
            imgDesign5.Opacity = 100;
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
