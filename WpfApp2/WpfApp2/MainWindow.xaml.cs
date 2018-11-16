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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            int FirstNumber = Convert.ToInt32(num1.Text);
            int SecondNumber = Convert.ToInt32(num2.Text);
            int sum = FirstNumber + SecondNumber;
             result.Content = sum.ToString();

        }



        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            int FirstNumber = Convert.ToInt32(num1.Text);
            int SecondNumber = Convert.ToInt32(num2.Text);
            int sub = FirstNumber - SecondNumber;
            result.Content = sub.ToString();
        }

        private void Multi_Click(object sender, RoutedEventArgs e)
        {

            int FirstNumber = Convert.ToInt32(num1.Text);
            int SecondNumber = Convert.ToInt32(num2.Text);
            int multiply = FirstNumber * SecondNumber;
            result.Content = multiply.ToString();


        }

        private void Dev_Click(object sender, RoutedEventArgs e)
        {
            int FirstNumber = Convert.ToInt32(num1.Text);
            int SecondNumber = Convert.ToInt32(num2.Text);
            int dev = FirstNumber / SecondNumber;
            result.Content = dev.ToString();
        }
    }
}
