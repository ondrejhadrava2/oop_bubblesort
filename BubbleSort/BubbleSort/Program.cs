using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] inputField = new int[10];
            for (int i = 0; i < inputField.Length; i++)
            {
                inputField[i] = random.Next(1, 100);
            }
            Sort a = new Sort(inputField);
            a.Initialize();
            Console.ReadKey();
        }
    }
}
