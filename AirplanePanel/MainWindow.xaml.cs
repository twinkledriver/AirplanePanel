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

         SolidColorBrush gray = new SolidColorBrush(Color.FromArgb(255, 193, 195, 189));
         SolidColorBrush green = new SolidColorBrush(Color.FromArgb(255, 50, 255, 18));
         SolidColorBrush black = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        

        private void btn_up_Click(object sender, RoutedEventArgs e)
        {
            if (FlyCondition == 1)
            {
                this.status.Text = "上升";
                this.btn_up.Background = gray;
                this.btn_down.Background = black;
                this.btn_accelerate.Background = black;
                this.btn_decelerate.Background = black;
                this.btn_crab.Background = black;
                this.btn_levelflight.Background = gray;
                
            }
            
      
        }

        private void btn_down_Click(object sender, RoutedEventArgs e)
        {
            if (FlyCondition == 1)
            {
                this.status.Text = "下降";
                this.btn_up.Background = black;
                this.btn_down.Background = gray;
                this.btn_accelerate.Background = black;
                this.btn_decelerate.Background = black;
                this.btn_crab.Background = black;
                this.btn_levelflight.Background = gray;
            }
           
        }

        private void btn_accelerate_Click(object sender, RoutedEventArgs e)
        {
            if (FlyCondition == 1)
            {
                this.status.Text = " 加速";
                this.btn_up.Background = black;
                this.btn_down.Background = black;
                this.btn_accelerate.Background = gray;
                this.btn_decelerate.Background = black;
                this.btn_crab.Background = black;
                this.btn_levelflight.Background = gray;
            }
        }

        private void btn_decelerate_Click(object sender, RoutedEventArgs e)
        {
            if (FlyCondition == 1)
            {
                this.status.Text = " 减速";
                this.btn_up.Background = black;
                this.btn_down.Background = black;
                this.btn_accelerate.Background = black;
                this.btn_decelerate.Background = gray;
                this.btn_crab.Background = black;
                this.btn_levelflight.Background = gray;
            }
        }

        private void btn_crab_Click(object sender, RoutedEventArgs e)
        {
            if (FlyCondition == 1)
            {
                this.status.Text = " 侧飞";
                this.btn_up.Background = black;
                this.btn_down.Background = black;
                this.btn_accelerate.Background = black;
                this.btn_decelerate.Background = black;
                this.btn_crab.Background = gray;
                this.btn_levelflight.Background = gray;
            }
        }

        int FlyCondition = -1;

        private void Button_Click_launch(object sender, RoutedEventArgs e)
        {
            this.status.Text = "  ";
            FlyCondition = 0;
            this.GroupBox_launch.Background = black;
            this.GroupBox_levelflight.Background = new SolidColorBrush(Colors.Black);
            this.GroupBox_landing.Background = new SolidColorBrush(Colors.Black);

            this.btn_up.Background = black;
            this.btn_down.Background = black;
            this.btn_accelerate.Background = black;
            this.btn_decelerate.Background = black;
            this.btn_crab.Background = black;

            this.btn_levelflight.Background = black;
            this.btn_launch.Background = gray;
            this.btn_landing.Background = black;
        }

        

        private void Button_Click_levelflight(object sender, RoutedEventArgs e)
        {
            FlyCondition = 1;
            this.GroupBox_levelflight.Background = black;
            this.GroupBox_launch.Background = new SolidColorBrush(Colors.Black);
            this.GroupBox_landing.Background = new SolidColorBrush(Colors.Black);

            this.btn_up.Background = black;
            this.btn_down.Background = black;
            this.btn_accelerate.Background = black;
            this.btn_decelerate.Background = black;
            this.btn_crab.Background = black;

            this.btn_levelflight.Background = gray;
            this.btn_launch.Background = black;
            this.btn_landing.Background = black;
       
        }

        private void btn_landing_Click(object sender, RoutedEventArgs e)
        {
            FlyCondition = 2;
            this.status.Text = "  ";
            this.GroupBox_landing.Background = black;
            this.GroupBox_levelflight.Background = new SolidColorBrush(Colors.Black);
            this.GroupBox_launch.Background = new SolidColorBrush(Colors.Black);

            this.btn_up.Background = black;
            this.btn_down.Background = black;
            this.btn_accelerate.Background = black;
            this.btn_decelerate.Background = black;
            this.btn_crab.Background = black;

            this.btn_levelflight.Background = black;
            this.btn_launch.Background = black;
            this.btn_landing.Background = gray;
        }

       

        private void Button_WindRight_Click(object sender, RoutedEventArgs e)
        {
            this.Button_WindRight.Foreground = black;
            this.Button_WindLeft.Foreground = green;
            this.Button_WindRight.Background = new SolidColorBrush(Colors.Yellow);
            this.Button_WindLeft.Background = black;

        }

        private void Button_WindLeft_Click(object sender, RoutedEventArgs e)
        {
            this.Button_WindLeft.Foreground = black;
            this.Button_WindRight.Foreground = green;
            this.Button_WindLeft.Background = new SolidColorBrush(Colors.Yellow);
            this.Button_WindRight.Background = black;
        }

        //private void Button_Daytime_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Button_Daytime.Foreground = black;
        //    this.Button_Night.Foreground = green;
        //    this.Button_Daytime.Background = new SolidColorBrush(Colors.Yellow);
        //    this.Button_Night.Background = black;
        //}

        //private void Button_Night_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Button_Night.Foreground = black;
        //    this.Button_Daytime.Foreground = green;
        //    this.Button_Night.Background = new SolidColorBrush(Colors.Yellow);
        //    this.Button_Daytime.Background = black;
        //}

      
       
        

        

    
    }
}
