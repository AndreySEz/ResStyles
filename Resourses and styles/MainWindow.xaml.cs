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

namespace Resourses_and_stylesary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c, d;
            try
            {
                a = Convert.ToDouble(coeffA.Text);
                b = Convert.ToDouble(coeffB.Text);
                c = Convert.ToDouble(coeffC.Text);
                d = Math.Pow(b, 2) - 4 * a * c;
                if (d > 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    resOut.Text = $"x1={x1}\nx2={x2}";
                }
                else if (d == 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    resOut.Text = ($"x1= {x1}");
                }
                else resOut.Text = "Решений нет";
            }
            catch
            {
                MessageBox.Show("Неправильно введённые данные!");
            }
        }
    }
}
