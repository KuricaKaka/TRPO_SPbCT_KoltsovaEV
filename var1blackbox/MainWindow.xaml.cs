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

namespace var1blackbox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //отсутствие try для обработок исключений
            double a = Convert.ToDouble(textbox1.Text);
            double b = Convert.ToDouble(textbox2.Text);
            double c = Convert.ToDouble(textbox3.Text);
            double z, z1;

            if (a != 0 && b != 0 && c != 0)
            {
                double d;
                d = Math.Sqrt(b * b + 4 * a * c);
                if (d == 0)
                {
                    z = ((-1) * b) / (2 * a);
                    textbox4.Text = "x1 = " + Convert.ToString(z);
                }
                else if (d < 0) textbox4.Text = "Дискриминант меньше 0, корней нет";
                else if (d > 0)
                {
                    z = ((-1) * b + d) / (2 * a);
                    z1 = ((-1) * b - d) / (2 * a);
                    textbox4.Text = "x1 = " + Convert.ToString(z) + "; x2 = " + Convert.ToString(z1);
                }
            }
            else if (a != 0 && b != 0 && c == 0)
            {
                z = (-1) * (b / a);
                z1 = 0;
                textbox4.Text = "x1 = " + Convert.ToString(z) + "; x2 = " + Convert.ToString(z1);
            }
            else if (a == 0 && b != 0)
            {
                z = (-1) * (c / b);
                textbox4.Text = "x1 = " + Convert.ToString(z);
            }
            else if (a != 0 && b == 0)
            {
                z = (-1) * Math.Sqrt(c / a);
                z1 = Math.Sqrt(c / a);
                textbox4.Text = "x1 = " + Convert.ToString(z) + "; x2 = " + Convert.ToString(z1);
            }
            //отстутвсие обработчика для нулей
        }
    }
}
