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

namespace AirplanePanel
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void btn_up_Click(object sender, RoutedEventArgs e)
        {
            if (FlyCondition == 1)
            {
                this.status.Text = "上升";
                this.btn_up.Background = new SolidColorBrush(Color.FromArgb(255,255,0,0));
                this.btn_down.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_accelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_decelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_crab.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                
            }
            
      
        }

        private void btn_down_Click(object sender, RoutedEventArgs e)
        {
            if (FlyCondition == 1)
            {
                this.status.Text = "下降";
                this.btn_up.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_down.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); 
                this.btn_accelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_decelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_crab.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));

            }
           
        }

        private void btn_accelerate_Click(object sender, RoutedEventArgs e)
        {
            if (FlyCondition == 1)
            {
                this.status.Text = " 加速";
                this.btn_up.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_down.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_accelerate.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                this.btn_decelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_crab.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            }
        }

        private void btn_decelerate_Click(object sender, RoutedEventArgs e)
        {
            if (FlyCondition == 1)
            {
                this.status.Text = " 减速";
                this.btn_up.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_down.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_accelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_decelerate.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                this.btn_crab.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            }
        }

        private void btn_crab_Click(object sender, RoutedEventArgs e)
        {
            if (FlyCondition == 1)
            {
                this.status.Text = " 侧飞";
                this.btn_up.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_down.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_accelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_decelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
                this.btn_crab.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            }
        }

        int FlyCondition = -1;

        private void Button_Click_launch(object sender, RoutedEventArgs e)
        {
            this.status.Text = "  ";
            FlyCondition = 0;
            this.GroupBox_launch.Background = new SolidColorBrush(Colors.LightBlue);
            this.GroupBox_levelflight.Background = new SolidColorBrush(Colors.White);
            this.GroupBox_landing.Background = new SolidColorBrush(Colors.White);

            this.btn_up.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_down.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_accelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_decelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_crab.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
        }

        

        private void Button_Click_levelflight(object sender, RoutedEventArgs e)
        {
            FlyCondition = 1;
            this.GroupBox_levelflight.Background = new SolidColorBrush(Colors.LightBlue);
            this.GroupBox_launch.Background = new SolidColorBrush(Colors.White);
            this.GroupBox_landing.Background = new SolidColorBrush(Colors.White);

            this.btn_up.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_down.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_accelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_decelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_crab.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
       
        }

        private void btn_landing_Click(object sender, RoutedEventArgs e)
        {
            FlyCondition = 2;
            this.status.Text = "  ";
            this.GroupBox_landing.Background = new SolidColorBrush(Colors.LightBlue);
            this.GroupBox_levelflight.Background = new SolidColorBrush(Colors.White);
            this.GroupBox_launch.Background = new SolidColorBrush(Colors.White);

            this.btn_up.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_down.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_accelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_decelerate.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
            this.btn_crab.Background = new SolidColorBrush(Color.FromArgb(255, 205, 205, 205));
        }

       

        private void Button_WindRight_Click(object sender, RoutedEventArgs e)
        {
            this.Button_WindRight.Foreground = new SolidColorBrush(Colors.Red);
            this.Button_WindLeft.Foreground = new SolidColorBrush(Colors.Black);
            this.Button_WindRight.Background = new SolidColorBrush(Colors.Yellow);
            this.Button_WindLeft.Background = new SolidColorBrush(Colors.White);

        }

        private void Button_WindLeft_Click(object sender, RoutedEventArgs e)
        {
            this.Button_WindLeft.Foreground = new SolidColorBrush(Colors.Red);
            this.Button_WindRight.Foreground = new SolidColorBrush(Colors.Black);
            this.Button_WindLeft.Background = new SolidColorBrush(Colors.Yellow);
            this.Button_WindRight.Background = new SolidColorBrush(Colors.White);
        }

      
       
        

        

    
    }
}
