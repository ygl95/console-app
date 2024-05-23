using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get file
            //Console.WriteLine("File Path: ");
            //string path = Console.ReadLine();
            //FileExist(path);

            // determine range 0 - 1000
            //Console.Write("Input integer: ");
            //string num = Console.ReadLine();
            //DetermineInt(num);

            // determine range 0 - 1000
            //Console.Write("Input integer: ");
            //string num = Console.ReadLine();
            //DetermineInt(num);

            // test array
            Console.Write("Input integer separated by (,): ");
            string num = Console.ReadLine();

            var numList = num.Split(',').ToList();
            var numArr = new int[] { };
            int ctr = 0;

            while (ctr <= numList.Count)
            {
                
                numArr[ctr] = int.Parse(numList.ElementAt(ctr));

                ctr++;
            }

            //var num = new int[] {1, 2, 3, 4, 5};
            var avg = Queryable.Average(numArr.AsQueryable());
            Console.WriteLine(avg.ToString());


        }


        private static void DetermineInt(string num)
        {
            bool isNum = int.TryParse(num, out int val);

            if (isNum)
            {
                int parsedInt = int.Parse(num);

                if (!(parsedInt < 0))
                {
                    if (parsedInt > 1000)
                    {
                        Console.WriteLine($"Integer {parsedInt} is greater than 1000.");
                    }
                }
                else
                {
                    Console.WriteLine($"Integer {parsedInt} is less than 0.");
                }
            }
        }
        
        private static void FileExist(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException();
                }
                else
                {
                    Console.WriteLine("File exist!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
