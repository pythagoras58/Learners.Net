
namespace Learner.Tutorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pythagoras");
            
            // variables:
            string myString = "Pythagoras";
            decimal myDecimal = 12.23M;
            bool myBool = true;
            
            Console.WriteLine(myString.GetType());
            Console.WriteLine(myDecimal.GetType());
            Console.WriteLine(myBool.GetType());
            
            // Data Structures
            Console.WriteLine("Data Structure");
            string[] food = new string[2];
            food[0] = "Banku";
            food[1] = "Tilapia";

            foreach (var foodItem in food)
            {
                Console.WriteLine(foodItem);
            }
            
        }
    }
}