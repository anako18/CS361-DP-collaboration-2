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
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для value.xaml
    /// </summary>
    public partial class Value : Window
    {

        private Dictionary<string, int> variables;
        private Dictionary<string, int> constants;

        public Value()
        {
            InitializeComponent();
            textBox.Text ="";
        }

        //Checking if the input is correct
        private void input_correct( KeyEventArgs e)
        {
            if (e.Key.ToString() == "OemComma") //If comma
            {
                if (textBox.Text[textBox.Text.Length - 1] == ',' || textBox.Text[textBox.Text.Length - 1] == '-')
                {
                    e.Handled = true;
                    invalid.Visibility = Visibility.Visible;
                }
            }
            else
                if (e.Key.ToString() == "OemMinus") //If minus
            {
                if (Char.IsDigit(textBox.Text[textBox.Text.Length - 1]) || (textBox.Text[textBox.Text.Length - 1] == '-'))
                {
                    e.Handled = true;
                    invalid.Visibility = Visibility.Visible;
                }
            }
            else
                if (!((e.Key >= Key.D0) && (e.Key <= Key.D9)) && !(((int)e.Key >= 74) && ((int)e.Key <= 83))) //If not number
            {
                e.Handled = true;
                invalid.Visibility = Visibility.Visible;
            }
        }

        //Input
        private void textBox_KeyDown(object sender, KeyEventArgs e) //
        {
            invalid.Visibility = Visibility.Hidden;
            input_correct(e);
        }

        private void textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
                invalid.Visibility = Visibility.Visible;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
