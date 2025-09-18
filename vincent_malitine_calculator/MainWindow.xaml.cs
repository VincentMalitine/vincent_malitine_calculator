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

namespace vincent_malitine_calculator
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

        int numb1;
        int numb2;
        int result;
        char operation;

        private void BTN0_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text += "0";
        }

        private void BTN1_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text += "1";
        }

        private void BTN2_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text += "2";
        }

        private void BTN3_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text += "3";
        }

        private void BTN4_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text += "4";
        }

        private void BTN5_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text += "5";
        }

        private void BTN6_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text += "6";
        }

        private void BTN7_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text += "7";
        }

        private void BTN8_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text += "8";
        }

        private void BTN9_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text += "9";
        }

        private void BTN_plus_Click(object sender, RoutedEventArgs e)
        {
            numb1 = int.Parse(TB_Display.Text);
            operation = '+';
            TB_Display.Text ="";
        }

        private void BTN_moins_Click(object sender, RoutedEventArgs e)
        {
            numb1 = int.Parse(TB_Display.Text);
            operation = '-';
            TB_Display.Text = "";
        }

        private void BTN_fois_Click(object sender, RoutedEventArgs e)
        {
            numb1 = int.Parse(TB_Display.Text);
            operation = '*';
            TB_Display.Text = "";
        }

        private void BTN_division_Click(object sender, RoutedEventArgs e)
        {
            numb1 = int.Parse(TB_Display.Text);
            operation = '/';
            TB_Display.Text = "";
        }

        private void BTN_egal_Click(object sender, RoutedEventArgs e)
        {

            numb2 = int.Parse(TB_Display.Text);
        
            switch (operation)
            {
                case '+':
                    result = numb1 + numb2;
                    TB_Display.Text = result.ToString();
                    break;
                case '-':
                    result = numb1 - numb2;
                    TB_Display.Text = result.ToString();
                    break;
                case '*':
                    result = numb1 * numb2;
                    TB_Display.Text = result.ToString();
                    break;
                case '/':
                    result = numb1 / numb2;
                    TB_Display.Text = result.ToString();
                    break;
                default:
                    break;
            }

        }

        private void BTN_clear_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "";
        }
    }
}