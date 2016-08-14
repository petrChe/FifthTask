using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector firstVector = new Vector(2, 8, 1);
            Vector secondVector = new Vector(4, 16, 2);
            Console.WriteLine((firstVector + secondVector).ToString());
            Console.WriteLine((firstVector - secondVector).ToString());
            Console.WriteLine((firstVector * 2).ToString());
            Console.WriteLine((firstVector * secondVector).ToString());
            Console.WriteLine((firstVector == secondVector));
            Console.WriteLine((firstVector != secondVector));
            Console.WriteLine(firstVector.FindLength());
            Console.ReadKey();
        }
    }
}
