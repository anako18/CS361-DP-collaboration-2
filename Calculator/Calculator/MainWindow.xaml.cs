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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Value value_form = new Value();

        Operation op = new Operation();

        public MainWindow()
        {
            InitializeComponent();
            textBox.Tag = false; //Shows if there's any formula
        }

        //Shows user's input into a textbox
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!(bool)textBox.Tag)
            {
                textBox.Tag = true;
                textBox.Text = "";
            }
            textBox.Text += (sender as Button).Content;
        }

        //Click C button(deletes current formula)
        private void C_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "0";
            textBox.Tag = false;
        }

        //Exit application
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void init_with_const_Click(object sender, RoutedEventArgs e)
        {
            value_form.Show();
        }

        private void extend_Click(object sender, RoutedEventArgs e)
        {
            op.Show();
        }
    }
}
