using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace Calculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            string[] results = display.Text.Split(' ');
            try
            {
                float firstNumber = Convert.ToSingle(results[0]);
                float secondNumber = Convert.ToSingle(results[2]);
                string arithmeticOperator = results[1];

                float result;

                switch (arithmeticOperator)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        display.Text = result.ToString();
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        display.Text = result.ToString();
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        display.Text = result.ToString();
                        break;
                    case "/":
                        result = firstNumber / secondNumber;

                        if (secondNumber == 0)
                        {
                            display.Foreground = Brushes.Red;
                            display.TextAlignment = TextAlignment.Center;
                            display.Text = "ERROR: You can't divide through 0";
                        }
                        else
                        {
                            display.Text = result.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException ex)
            {
                display.TextWrapping = TextWrapping.Wrap;
                display.Foreground = Brushes.Red;
                display.TextAlignment = TextAlignment.Center;
                display.FontSize = 20;
                display.Text = "ERROR: InputFormatException";
            }

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text = String.Empty;
            display.Foreground = Brushes.Black;
            display.TextAlignment = TextAlignment.Left;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += " + ";
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += " - ";
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += " * ";
        }

        private void DivisionButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += " / ";
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "0";
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "1";
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "2";
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "3";
        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "4";
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "5";
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "6";
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "7";
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "8";
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "9";
        }
    }
}
