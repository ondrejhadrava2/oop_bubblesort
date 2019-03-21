using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Sort
    {
        public int[] input;

        public Sort(int [] input)
        {
            this.input = input;
        }

        public void Initialize()
        {
            Console.WriteLine("Array before sorting: {0}", Visualize() + "\n");
            Sorting();
            Console.WriteLine("\nSorted array: {0}", Visualize());
        }

        private void Sorting()
        {
            bool unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        Switch(i);
                        Console.WriteLine(Visualize());
                        unsorted = true;
                    }
                }
            }
        }

        private void Switch(int i)
        {
            int temp;
            temp = input[i];
            input[i] = input[i + 1];
            input[i + 1] = temp;
        }

        private string Visualize()
        {
            string s = "";
            foreach (int i in input)
                s += String.Format("{0} ", i);
            return s;
        }


    }
}
