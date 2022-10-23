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

namespace var3blackbox
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

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            //Отсутствует обработчик исключений try catch
            double x1 = Convert.ToDouble(tx1.Text);
            double y1 = Convert.ToDouble(ty1.Text);
            double x2 = Convert.ToDouble(tx2.Text);
            double y2 = Convert.ToDouble(ty2.Text);
            double x3 = Convert.ToDouble(tx3.Text);
            double y3 = Convert.ToDouble(ty3.Text);
            double x4 = Convert.ToDouble(tx4.Text);
            double y4 = Convert.ToDouble(ty4.Text);

            double l1, l2, l3, l4, l5, d;

            l1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            l2 = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            l3 = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
            l4 = Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));
            l5 = Math.Sqrt((x2 - x4) * (x2 - x4) + (y2 - y4) * (y2 - y4));

            d = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            //не обрабатываются несуществующие четырёхугольники
            if(l1==l2 && l2==l3 && l3==l4 && (l5*l5 + l4*l4 == 4*((l1*l1))))
            {
                MessageBox.Show("Квадрат");
            }
            else if (l1 == l2 && l2 == l3 && l3 == 1 && (4*Math.Sqrt(2)!=d))
            {
                MessageBox.Show("Ромб");
            }
            else if ((l1 != l4 && l3 != l4) && ((x4-x1)*(y3-y2)==(x3-x2)*(y1-y4)) 
                || ((x2 - x1) * (y4 - y3) == (x4 - x3) * (y2 - y4)))
            {
                MessageBox.Show("Трапеция");
            }
        }
    }
}
