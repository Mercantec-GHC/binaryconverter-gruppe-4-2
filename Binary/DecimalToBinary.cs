using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public static class DecimalToBinary
    {
        public static void Run()
        {
            Console.WriteLine("Decimal to Binary Converter");
            
            string binIP = ConvertDecimalToBinary(Console.ReadLine());
            Console.WriteLine("Binary IP: " + binIP);
        }

        public static string ConvertDecimalToBinary(string decimalIP)
        {
            

            string[] decimalDeler = decimalIP.Split('.');

            string result = "";

            foreach (string decimalDel in decimalDeler)
            {
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
                //result += binary + ".";
            }

            return result.TrimEnd('.');












        }
    }
}
