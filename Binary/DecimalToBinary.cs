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
            //l�ser det der bliver intastet og sender det vidre ind i funktion 'ConvertBinaryToDecimal' og f�r resultatet tilbage hvor det bliver gemt i binIP
            string binIP = ConvertDecimalToBinary(Console.ReadLine());
            //udskriver resultat
            Console.WriteLine("Binary IP: " + binIP);
        }

        //koveterer decimal IP til bin�r IP
        public static string ConvertDecimalToBinary(string decimalIP)
        {
            
            //string decimalIP bliver delt i 4 strings og gemmes i arrey med navn decimalDeler 
            string[] decimalDeler = decimalIP.Split('.');
            //slut resultat
            string result = "";
            //decimalDel er v�rt string i decimalDeler arrey
            foreach (string decimalDel in decimalDeler)
            {
                //kovetere fra string til integer og det gemmmes i variable decimalDelint
                int decimalDelint = int.Parse(decimalDel);
                //her gemmes resultat som bin�r
                string binary = "";
                //int arrey med navn numbers
                int[] numbers = { 128, 64, 32, 16, 8, 4, 2, 1 };
                //loop der g�r i gemmen alle elementer i arrey numbers
                foreach (int number in numbers)
                {
                    //tjekker om vores koveteret integer er st�re end hvert tal i arrey numbers
                    if (decimalDelint >= number)
                    {
                        //hvis det er st�rer gemmes et 1 tal i string binary
                        binary = binary + "1";
                        //n�r det er st�re bliver det minuset 
                        decimalDelint = decimalDelint - number;


                    }
                    //hvis vores konveteret integer er mindre end tilsvarende tal i arrey numbers
                    else
                    {
                        //s� gemmes der et 0 i string binary
                        binary = binary + "0";
                    }

                }
                //gemmer resultaterne
                result = result + binary + ".";
                //result += binary + ".";
            }
            //retunere til der hvor klader p� funktionen med resultatet og trimmer det sidste punktum
            return result.TrimEnd('.');












        }
    }
}
