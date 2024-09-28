using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rekenmachine
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

        double number1;
        double number2;
        double result;
        bool result1;
        bool result2;
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            
            result1 = double.TryParse(number1Textbox.Text, out number1);
            result2 = double.TryParse(number2Textbox.Text, out number2);
            if (result1 && result2)
            {
                result = number1 + number2;
                resultTextbox.Text = $"{result}";

            }
            else
            {
                resultTextbox.Text = "Give a Number!";
            }

        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {

            result1 = double.TryParse(number1Textbox.Text, out number1);
            result2 = double.TryParse(number2Textbox.Text, out number2);
            if (result1 && result2)
            {
                result = number1 - number2;
                resultTextbox.Text = $"{result}";

            }
            else
            {
                resultTextbox.Text = "Give a Number!";
            }
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {

            result1 = double.TryParse(number1Textbox.Text, out number1);
            result2 = double.TryParse(number2Textbox.Text, out number2);
            if (result1 && result2)
            {
                result = number1 * number2;
                resultTextbox.Text = $"{result}";

            }
            else
            {
                resultTextbox.Text = "Give a Number!";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            result1 = double.TryParse(number1Textbox.Text, out number1);
            result2 = double.TryParse(number2Textbox.Text, out number2);
            if (result1 && result2)
            {
                result = number1 / number2;
                resultTextbox.Text = $"{result}";

            }
            else
            {
                resultTextbox.Text = "Give a Number!";
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            number1Textbox.Text = "0";
            number2Textbox.Text = "0";
            resultTextbox.Text = "0";
        }

    }
}