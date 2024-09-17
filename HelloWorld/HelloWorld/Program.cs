

using HelloWorld2;

namespace NuGet_test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Írjon be egy számot: ");
                string userInput = Console.ReadLine();
                int number;
                if (int.TryParse(userInput, out number))
                {
                    number=int.Parse(userInput);
                    var magician = new DummyClass(number);

                    Console.Write("A kapott számból előálló mágikus szám: ");
                    Console.WriteLine(magician.CalculateMagicNumber());
                }
                else
                {
                    Console.WriteLine("Rossz input, csak egész számot vár a program.");
                }
                Console.WriteLine();

                
            }
        }
    }
}
