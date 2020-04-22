using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[5] { "one", "two", "three", "four", "five" };
            InOutUtils.PrintTValArray<string>(stringArray);

            Console.WriteLine(new string('-', 10));

            int[] intArray = new int[20];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
            }
            InOutUtils.PrintTValArrayBackwards<int>(intArray);

            Console.ReadKey();
        }
    }

    public static class InOutUtils
    {
        public static void PrintTValArray<Tval>(Tval[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintTValArrayBackwards<Tval>(Tval[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
