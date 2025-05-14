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

            //l�ser det der bliver intastet og sender det vidre ind i funktion 'ConvertBinaryToDecimal' og f�r resultatet tilbage hvor det bliver gemt i DecIP
            string DecIP = ConvertBinaryToDecimal(Console.ReadLine());
            //udskriver resultatet
            Console.WriteLine("IP: " + DecIP);

        }
        //skriver ip som string med binary og koveterer til string i decimal
        public static string ConvertBinaryToDecimal(string binary)
        {
            //string arrey det heder binaryDeler | binary.split deler vores string ved v�rt punktum '.' 
            string[] binaryDeler = binary.Split('.');
            //variable der gemmer slut resultat i string
            string result = "";
            //loop der arbejder med v�rt enkelte arrey element som er string
            foreach (string binaryDel in binaryDeler)
            {
                //gemmer resultat af koveterede bin�r til decimal som integer
                int value = 0;

                //arbejder med v�rt enkelte element i octecten fra 0 til 7 | det er stadig string
                for (int i = 0; i < 8; i++)


                {
                    //(binaryDel[i] - '0'); koveterer v�rt enkelte element fra string til integer | value = value * 2 + holder styr hvor den er kommet til i octeten
                    value = value * 2 + (binaryDel[i] - '0');
                }
                //result gemmer og samler alle koveterede resultater som integer fra v�rt string/octet som er en del af arreyed
                result += value + ".";

            }

            //gemmer resultatet som string
            return result;

        }

    }
}
