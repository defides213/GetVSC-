using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchif.Folder
{
    internal class Ifs
    {
        public int inputs()
        {
            Console.WriteLine("- input a number");
            string inputNumber = Console.ReadLine();
            int numberParsed = int.Parse(inputNumber);

            return numberParsed;
        }
        public void returnTrue()
        {
            int number1 = inputs();
            int number2 = inputs();
            Console.WriteLine($"- returned {number1 == number2}");
        }
        public void differentOrSame()
        {
            int sum;
            int number1 = inputs();
            int number2 = inputs();
            if( number1 != number2 ) { sum = number1 + number2; }
            else { sum = number1 * number2; }
            Console.WriteLine($"- returned {sum}");
        }
        public void equalToTrue()
        {
            int sum;
            int number1 = inputs();
            int number2 = inputs();
            sum = number1 + number2;
            Console.WriteLine($"- returned {sum == 30}");
        }
        
    }
}
