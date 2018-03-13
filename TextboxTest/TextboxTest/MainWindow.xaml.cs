using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace TextboxTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Regex number_regex = new Regex("([0-9-])");
        Regex komma_regex = new Regex("([0-9,-])");
        bool komma = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        public string Text
        {
            get
            {
                txtBox.Text = txtBox.Text.Replace(" ", "");               
                string[] numbers = txtBox.Text.Split('-');
                double result = Convert.ToDouble(numbers[0]);
                for(int i = 1; i < numbers.Length; i++)
                {
                    result -= Convert.ToDouble(numbers[i]);
                }
                return result.ToString();
            }
            set
            {
                txtBox.Text = value;
            }
        }

        private void txtBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private bool IsTextAllowed(string text)
        {            
            if (komma)
            {                
                return number_regex.IsMatch(text);
            }
            else
            {
                return komma_regex.IsMatch(text);
            }
        }

        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            komma = txtBox.Text.Contains(",");
        }

        private void btnLöschen_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "";
        }

        private void getText_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = Text;
        }
    }
}
