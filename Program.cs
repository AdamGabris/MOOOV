using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace MOOOV
{
    public class Program
    {

       public static ArrayList testing = new ArrayList();
        



        public static void Main()
        {

            testing.Add("hei");
            foreach(string test in testing)
            {
                Console.WriteLine(test);
            }
            

        }

            /*
            string[] colors = { "black", "yellow", "red", "blue", "green" };
            string randomColor;

            

            List<string> sequence = new List<string>();

            do
            {
                randomColor = FetchColor(colors, sequence);
                sequence.Add(randomColor);
                Console.WriteLine(randomColor);
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        public static string FetchColor(string[] colors, List<string> sequence)
        {
            int index;
            string randomColor;

            do
            {
                index = new Random().Next(colors.Length);
                randomColor = colors[index];
            } while (sequence.Count > 0 && sequence[sequence.Count - 1] == randomColor);

            return randomColor;
        }*/
    }
}
