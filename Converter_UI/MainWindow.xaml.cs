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

namespace Converter_UI
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
        //Binary to Decimal 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string binIP = BinaryTextBox.Text.Trim();
            string decIP = ConvertBinaryToDecimal(binIP);
            ResultTextBlock.Text = decIP;
        }

            public static string ConvertBinaryToDecimal(string binary)
        {
            string[] binaryDeler = binary.Split('.');
            string result = "";
            foreach (string binaryDel in binaryDeler)
            {
                if (binaryDel.Length != 8)
                {
                    return "Invalid input";
                }
                if (!binaryDel.All(c => c == '0' || c == '1'))
                {
                    return "Invalid input";
                }
                int value = 0;
                for (int i = 0; i < 8; i++)
                {
                    value = value * 2 + (binaryDel[i] - '0');
                }
                result += value.ToString() + ".";
            }
            return result.TrimEnd('.');
        }



        //Decimal to Binary
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string decimalsIP = DecimalTextBox.Text.Trim();
            string binaryIP = ConvertDecimalToBinary(decimalsIP);
            ResultDectoBin.Text = binaryIP;
            
        }
        public static string ConvertDecimalToBinary(string decimalIP)
        {
            string[] decimalDeler = decimalIP.Split('.');
            string result = "";
            foreach (string decimalDel in decimalDeler)
            {
                if(decimalDel.Length < 1 || decimalDel.Length > 3)
                {
                    return "Invalid input";
                }

                if (!decimalDel.All(char.IsDigit))
                {
                    return "Invalid input";
                }


                int decimalDelint = int.Parse(decimalDel);
                string binary = "";
                int[] numbers = { 128, 64, 32, 16, 8, 4, 2, 1 };
                foreach (int number in numbers)
                {
                    if (decimalDelint >= number)
                    {
                        binary = binary + "1";
                        decimalDelint = decimalDelint - number;
                    }
                    else
                    {
                        binary = binary + "0";
                    }
                }
                result = result + binary + ".";
            }
            return result.TrimEnd('.');
        }
    }
}