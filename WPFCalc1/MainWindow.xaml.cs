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

namespace WPFCalc1
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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            number1.Clear();
            number2.Clear();
            TextForNumbers.Clear();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(number1); // присваиваем переменной a значение введеное пользователем в первом текст боксе
            double b = Convert.ToDouble(number2); // присваиваем переменной b значение введеное пользователем во втором текст боксе

            TextForNumbers.Text = Convert.ToString(a + b);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            string operation = ComboBox1.Text;
            double a = double.Parse(number1.Text);
            double b = double.Parse(number2.Text);
            double result = 0;

            if (operation == "+")
            {
                result = a + b;
            }
            else if (operation == "-")
            {
                result = a - b;
            }
            else if (operation == "*")
            {
                result = a * b;
            }
            else if (operation == "/")
            {
                if (b != 0)
                {
                    result = a / b;
                }
                else
                {
                    MessageBox.Show("На ноль делить нельзя!");
                }
            }
            TextForNumbers.Text = result.ToString();
       

            }

        private void number1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }


       
    

