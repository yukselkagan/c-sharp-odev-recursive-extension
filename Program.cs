using System;

namespace c_sharp_odev_recursive_extension
{
    class Program
    {
        static void Main(string[] args)
        {


            Operations operations = new();
            Console.WriteLine(operations.Exponentiation(3, 4));


            string text = "Hello World";


            Console.WriteLine( text.CheckSpaces() );
            Console.WriteLine( text.RemoveWhiteSpaces() );
            Console.WriteLine( text.MakeUpperCase() );
            Console.WriteLine( text.MakeLowerCase() );

            int[] array1 = { 5, 1, 30, 100, 4, 3, 12 };
            string[] array2 = { "hello", "world", "123" };

            array1.SortArray();
            array1.WriteArray();

            int number1 = 6;
            Console.WriteLine( number1.IsEvenNumber() );

            Console.WriteLine( text.GetFirstCharacter() );



            
        }
    }




    public class Operations
    {
        public int Exponentiation(int number, int exponent)
        {
            if(exponent <= 1)
            {
                return number;
            }
            return Exponentiation(number, exponent - 1) * number;

        }
    }




    public static class Extension
    {

        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] parts = param.Split(" ");
            return string.Join("", parts);
        }


        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void WriteArray(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);            
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }


        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }




    }














}
