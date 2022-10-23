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

namespace var2blackbox
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //нет обработчика для пустых или полей с не числовыми данными try catch

            double a = Convert.ToDouble(textbox1.Text);
            double b = Convert.ToDouble(textbox2.Text);
            double c = Convert.ToDouble(textbox3.Text);
            //Отсутствует обработчик на несуществующие треугольники
            if (a == b && a == c) textbox4.Text = "Равносторонний";
            else if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b)) textbox4.Text = "Прямоугольный";
            else if ((a == b && a != c) || (b == c && b != a) || (a == c && a != b)) textbox4.Text = "Равнобедренный";
            else textbox4.Text = "Разносторонний";
        }
    }
}
