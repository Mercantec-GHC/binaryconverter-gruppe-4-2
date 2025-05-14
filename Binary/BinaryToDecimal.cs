using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public static class BinaryToDecimal
    {
        public static void Run()
        {
            Console.WriteLine("Binary to Decimal Converter");

            //læser det der bliver intastet og sender det vidre ind i funktion 'ConvertBinaryToDecimal' og får resultatet tilbage hvor det bliver gemt i DecIP
            string DecIP = ConvertBinaryToDecimal(Console.ReadLine());
            //udskriver resultatet
            Console.WriteLine("IP: " + DecIP);

        }
        //skriver ip som string med binary og koveterer til string i decimal
        public static string ConvertBinaryToDecimal(string binary)
        {
            //string arrey det heder binaryDeler | binary.split deler vores string ved vært punktum '.' 
            string[] binaryDeler = binary.Split('.');
            //variable der gemmer slut resultat i string
            string result = "";
            //loop der arbejder med vært enkelte arrey element som er string
            foreach (string binaryDel in binaryDeler)
            {
                //gemmer resultat af koveterede binær til decimal som integer
                int value = 0;

                //arbejder med vært enkelte element i octecten fra 0 til 7 | det er stadig string
                for (int i = 0; i < 8; i++)


                {
                    //(binaryDel[i] - '0'); koveterer vært enkelte element fra string til integer | value = value * 2 + holder styr hvor den er kommet til i octeten
                    value = value * 2 + (binaryDel[i] - '0');
                }
                //result gemmer og samler alle koveterede resultater som integer fra vært string/octet som er en del af arreyed
                result += value + ".";

            }

            //gemmer resultatet som string
            return result;

        }

    }
}
