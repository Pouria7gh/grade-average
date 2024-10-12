using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeAverage.Input
{
    internal class DoubleInput
    {
        private static double _Input;
        public static double? Get() 
        {
            string Input = Console.ReadLine();
            while (!double.TryParse(Input,out _Input) || string.IsNullOrEmpty(Input))
            {
                Console.WriteLine("Wrong Format Please Try Again Or Enter \"E\" To Exit :");
                Input = Console.ReadLine();
                if (Input.Trim().ToLower() == "e")
                {
                    break;
                }
            }
            if (string.IsNullOrEmpty(Input))
                return null;
            else return _Input;
        }
    }
}
