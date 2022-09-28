using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Actividad5
{
    public class Actividad5
    {
        static void Main(string[] args)
        {
            Console.WriteLine(contarPalabras("Dabale arroz a la zorra el abad"));
        }

        public static string devolverString(string[] vs)
        {
            //TODO

            string result = string.Join("", vs);

            return result;
                
            throw new NotImplementedException();
        }

        public static string devolverStringOrdenado(string[] vs)
        {

            //TODO

          string[] sr = vs.OrderBy(o => o).ToArray();


            return devolverString(sr);

            throw new NotImplementedException();
        }

        public static int contarCaracter(string[] vs, char v)
        {
            //TODO

            int count = 0;
            foreach (var word in vs)
                foreach (char character in word)
                    if (character == v)
                        count++;
            return count;

            throw new NotImplementedException();
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {

            //TODO
            int[] arr = new int[vs1.Length];

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i]  = vs1[i] + vs2[i];
            }

            return arr;

            throw new NotImplementedException();
        }

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            //TODO

            int[] arr = new int[vs1.Length];

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = vs1[i] * vs2[i];
            }

            return arr;


            throw new NotImplementedException();
        }

        public static bool isPalindromo(string entrada)
        {
            //TODO

           var word1 = new String[entrada.Length];



            int length = entrada.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (entrada[i] != entrada[length - i - 1])
                    return false;
            }
            return true;

            throw new NotImplementedException();


        }

        public static int contarPalabras(string entrada)
        {
            //TODO
            int countWords = entrada.Split().Length;
            return countWords;
            throw new NotImplementedException();
        }

        public static int contarCaracteres(string entrada)
        {
            //TODO

            return entrada.Length;

            throw new NotImplementedException();
        }
    }
}
