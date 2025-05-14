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
            //læser det der bliver intastet og sender det vidre ind i funktion 'ConvertBinaryToDecimal' og får resultatet tilbage hvor det bliver gemt i binIP
            string binIP = ConvertDecimalToBinary(Console.ReadLine());
            //udskriver resultat
            Console.WriteLine("Binary IP: " + binIP);
        }

        //koveterer decimal IP til binær IP
        public static string ConvertDecimalToBinary(string decimalIP)
        {
            
            //string decimalIP bliver delt i 4 strings og gemmes i arrey med navn decimalDeler 
            string[] decimalDeler = decimalIP.Split('.');
            //slut resultat
            string result = "";
            //decimalDel er vært string i decimalDeler arrey
            foreach (string decimalDel in decimalDeler)
            {
                //kovetere fra string til integer og det gemmmes i variable decimalDelint
                int decimalDelint = int.Parse(decimalDel);
                //her gemmes resultat som binær
                string binary = "";
                //int arrey med navn numbers
                int[] numbers = { 128, 64, 32, 16, 8, 4, 2, 1 };
                //loop der går i gemmen alle elementer i arrey numbers
                foreach (int number in numbers)
                {
                    //tjekker om vores koveteret integer er støre end hvert tal i arrey numbers
                    if (decimalDelint >= number)
                    {
                        //hvis det er stører gemmes et 1 tal i string binary
                        binary = binary + "1";
                        //når det er støre bliver det minuset 
                        decimalDelint = decimalDelint - number;


                    }
                    //hvis vores konveteret integer er mindre end tilsvarende tal i arrey numbers
                    else
                    {
                        //så gemmes der et 0 i string binary
                        binary = binary + "0";
                    }

                }
                //gemmer resultaterne
                result = result + binary + ".";
                //result += binary + ".";
            }
            //retunere til der hvor klader på funktionen med resultatet og trimmer det sidste punktum
            return result.TrimEnd('.');












        }
    }
}
