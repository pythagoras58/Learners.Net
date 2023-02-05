﻿
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
            Console.WriteLine("Data Structure - Arrays");
            string[] food = new string[2];
            food[0] = "Banku";
            food[1] = "Tilapia";

            foreach (var foodItem in food)
            {
                var reducers = foodItem.Substring(0, 2);
                Console.WriteLine(foodItem);
                Console.WriteLine(reducers);
            }
            
            Console.WriteLine("Data Structure - List");
            List<string> petList = new List<string>();
            petList.Add("Pango");
            petList.Add("Killer");
            petList.Add("Destiny");
            petList.Add("Strike");

            foreach (var pet in petList)
            {
                Console.WriteLine(pet);
            }
            
            Console.WriteLine("Data Structure - IEnumerable");
            IEnumerable<string> myBooks = petList;
            
            Console.WriteLine(myBooks.FirstOrDefault(c=> c.ToString() == "Killer"));
            
            Console.WriteLine("Data Structure - Dictionary");
            Dictionary<int, string> myStudents = new Dictionary<int, string>()
            {
                {12, "Solomon"},
                {13, "Forgive"},
                {14, "Jeffery"},
                {15, "Albert"},
                {16, "Cedric"}
            };
            
            Console.WriteLine(myStudents[12]);

            Dictionary<string, string[]> Lecturers = new Dictionary<string, string[]>()
            {
                {"FESAC", new []{"Sheela","Totimeh", "Helen"}},
                {"FBA", new []{"Henry","Isaac", "Daniel"}}
            };
            
            Console.WriteLine(Lecturers["FBA"]);
        }
    }
}