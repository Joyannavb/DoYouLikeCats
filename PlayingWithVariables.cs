using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithVariablesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool youLikeCats = true;
            string friendName = "Sarah";
            char me = 'I';
            int numberCats = 2;
            double catAge1 = +7.5;
            decimal catAge2 = 1.5m;

            Console.WriteLine($"{friendName} said {me} likes cats? That's {youLikeCats}. " +
                $"I have {numberCats} cats. They are {catAge1} and {catAge2} years old.");
        }
    }
}
