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
using System.Windows.Threading;


namespace MainProgram
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //TomatoClass tomato = new TomatoClass();
            //tomato.MyProperty = DateTime.Now.ToString();
            InitializeComponent();

            //DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            //{
            //    textBox.Text = DateTime.Now.ToString();
            //}, this.Dispatcher);
            List<DateTime> dataDateTimes = new List<DateTime>();
            //dataDateTimes.Add(new DateTime(2019,6,28,14,35,0));
            DateTime dt = new DateTime(2019, 6, 28, 14, 35, 0);
            if (dt == DateTime.Now)
            {
                MessageBox.Show("时间到了");
            }
            ;
        

        }


    }
    }
