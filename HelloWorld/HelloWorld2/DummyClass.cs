using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    public class DummyClass
    {
        private int userInput;

        public DummyClass(int userInput)
        {
            this.userInput = userInput;
        }

        public double CalculateMagicNumber()
        {
            try
            {
                return 1024 / (userInput - 42);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Nem támogatott mágikus szám");
                return 0;
            }
        }
    }
}
