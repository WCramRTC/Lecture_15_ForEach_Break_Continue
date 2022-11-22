using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_15_ForEach_Break_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            



            Console.ReadKey();
        } // Main

        public static void ContinueExample()
        {
            for (int i = 0; i < 20; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            // 0 1 2 3 4 6
            Console.WriteLine("Past the for");
        }

        public static void ForEachExample()
        {

            string[] names = { "Jawan", "Ronda", "Hannah" };
            int[] values = RandomNumbers(4000, 45, 3000, false);

            // Foreach

            int sum = 0;

            foreach (int value in values)
            {
                sum += value;
            } // foreach

            Console.WriteLine(sum);
        }

        public static int[] RandomNumbers(int count , int min, int max, bool inOrder)
        {
            int[] values = new int[count];
            Random rand = new Random();

            for (int i = 1; i <= values.Length - 1; i++)
            {
                if (inOrder)
                {
                    values[i] = i;
                }
                else
                {
                    values[i] = rand.Next(min, max);

                }
            }

            return values;
        }

        // ForEach
        // What is the syntax
        // array type - variable name - keyword in - collection

        // Unlike a for loop, a ForEach does not need a index to access an arrays elements.

        // Because of that you cannot reassign values in an array.


        // Also you could not easily return a _______ from a linear search


        // Continue
        // We use continue when we want our loop to _______

        // Break
        // We use break when we want to break out of our loop

    } // class

} // namespace
