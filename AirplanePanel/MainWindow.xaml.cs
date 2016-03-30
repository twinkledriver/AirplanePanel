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
            InitializeComponent();               //系统生成，做一些初始化的工作，这里主要是初始化一个窗口（Window）
        }

         SolidColorBrush gray = new SolidColorBrush(Color.FromArgb(255, 193, 195, 189));   //定义三个颜色变量，方便后面设置用。格式如左边，这里用了RGB方式来获取一个特有的颜色。tips：可以现在xaml的属性栏中选好心仪的颜色，记录他的rgb值+透明度。然后在这里定义。
         SolidColorBrush green = new SolidColorBrush(Color.FromArgb(255, 50, 255, 18));   //黑：无变化，与背景一致。灰：代表选中。绿：字本身的颜色
         SolidColorBrush black = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        

        private void btn_up_Click(object sender, RoutedEventArgs e)    //对“上升”按钮 点击 的方法
        {
            if (FlyCondition == 1)      //判断 飞机状态，先要有处于“平飞”状态，才有“上升”按钮的变化
            {
                this.status.Text = "上升";
                this.btn_up.Background = gray;     //按钮 背景色 变化。意在 提示 这个按钮 被按下状态
                this.btn_down.Background = black;   //其他按钮 要保持 未按下的 黑色 。一个按钮的按下 不能改变其他的状态。
                this.btn_accelerate.Background = black;
                this.btn_decelerate.Background = black;
                this.btn_crab.Background = black;
                this.btn_levelflight.Background = gray;     //“平飞”按钮 也要 变色 以提示 用户
                
            }
            
      
        }

        private void btn_down_Click(object sender, RoutedEventArgs e)  //对 “下降”的处理；方式同上面“起飞”。
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

        private void btn_accelerate_Click(object sender, RoutedEventArgs e) //对“加速”的处理，同上。
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

        private void btn_decelerate_Click(object sender, RoutedEventArgs e) //对“减速”的处理，同上。
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

        private void btn_crab_Click(object sender, RoutedEventArgs e)//对“侧飞”的处理，同上。
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

        int FlyCondition = -1;   //定义一个 飞机状态 初始。当然-1 与视图里三种状态 都不符。默认用。

        private void Button_Click_launch(object sender, RoutedEventArgs e) //起飞 按下
        {
            this.status.Text = "  ";            //清空    飞机状态中的 文字
            FlyCondition = 0;                   //新的 飞机状态
           

            this.btn_up.Background = black;
            this.btn_down.Background = black;
            this.btn_accelerate.Background = black;     //5个平飞 状态 全部 暗下
            this.btn_decelerate.Background = black;
            this.btn_crab.Background = black;

            this.btn_levelflight.Background = black;
            this.btn_launch.Background = gray;              //起飞 亮起
            this.btn_landing.Background = black;
        }

        

        private void Button_Click_levelflight(object sender, RoutedEventArgs e)     //平飞状态
        {
            FlyCondition = 1;           //又一种 新的飞机状态定义
         

            this.btn_up.Background = black;
            this.btn_down.Background = black;
            this.btn_accelerate.Background = black;
            this.btn_decelerate.Background = black;      //5个平飞 状态 全部 暗下
            this.btn_crab.Background = black;

            this.btn_levelflight.Background = gray;
            this.btn_launch.Background = black;
            this.btn_landing.Background = black;
       
        }

        private void btn_landing_Click(object sender, RoutedEventArgs e) //同理，针对 降落 按钮
        {
            FlyCondition = 2;
            this.status.Text = "  ";
          

            this.btn_up.Background = black;
            this.btn_down.Background = black;
            this.btn_accelerate.Background = black;
            this.btn_decelerate.Background = black;
            this.btn_crab.Background = black;

            this.btn_levelflight.Background = black;
            this.btn_launch.Background = black;
            this.btn_landing.Background = gray;
        }

       

        //private void Button_WindRight_Click(object sender, RoutedEventArgs e)  //右侧风 按钮按下
        //{
        //    this.Button_WindRight.Foreground = black;
        //    this.Button_WindLeft.Foreground = green;            //Foreground指字的颜色
        //    this.Button_WindRight.Background = new SolidColorBrush(Colors.Yellow);  //背景色处理
        //    this.Button_WindLeft.Background = black;

        //}

        //private void Button_WindLeft_Click(object sender, RoutedEventArgs e)            //同上
        //{
        //    this.Button_WindLeft.Foreground = black;            
        //    this.Button_WindRight.Foreground = green;
        //    this.Button_WindLeft.Background = new SolidColorBrush(Colors.Yellow);
        //    this.Button_WindRight.Background = black;
        //}


    
    }
}
