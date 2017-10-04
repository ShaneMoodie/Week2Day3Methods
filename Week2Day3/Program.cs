using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Add(5, 7);

            Console.WriteLine(answer);

            RobotWarning("Shane Moodie");
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;

            return sum;
        }
        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name);
        }

        public static string AllCaps(string word)
        {
            return word.ToUpper();
        }
    }
}
