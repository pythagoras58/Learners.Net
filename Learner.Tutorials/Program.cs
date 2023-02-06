
namespace Learner.Tutorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Pythagoras");
            
            // variables:
           /* string myString = "Pythagoras";
            decimal myDecimal = 12.23M;
            bool myBool = true;
            
            Console.WriteLine(myString.GetType());
            Console.WriteLine(myDecimal.GetType());
            Console.WriteLine(myBool.GetType());*/
            
            // Data Structures
           /* Console.WriteLine("Data Structure - Arrays");
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
            
            Console.WriteLine(Lecturers["FBA"][1]); */
           
           /*string myFirstValue = "some words";
           string mySecondValue = "Some Words";

           if(myFirstValue == mySecondValue)
           {
               Console.WriteLine("equal");
           }
           else if(!myFirstValue.Equals(mySecondValue))
           {
               Console.WriteLine("equal without case sensitivity");
           }
           else
           {
               Console.WriteLine("not equal");
           }*/
           
           
           //LOOPS
           int[] intsToCompress = new[] { 1, 23, 34, 34, 5, 65, 4, 3 };
           int sum = 0;
           foreach (var i in intsToCompress)
           {
               sum += i;
           }
           Console.WriteLine(sum);
           
           /*Console.WriteLine("====Exercise===");
           List<int> myNumberList = new List<int>(){
               2, 3, 5, 6, 7, 9, 10, 123, 324, 54
           };

           foreach (var i in myNumberList)
           {
               if (i % 2 == 0)
               {
                   Console.WriteLine(i);
               }
           }*/

           // functions
           //Console.WriteLine(totalValueVult(intsToCompress));
           
           // distinct
           List<int> myListings = new List<int>() { 1,2,3,2,1,2,3,4,5,6,7};
           
           DisplaySet(myListings);

        }

        private static int totalValueVult(int[] arr)
        {
            int summation = 0;
            foreach (var i in arr)
            {
                summation += i;
            }
            return summation;
        }

        private static void DisplaySet(List<int> arr)
        {
            HashSet<int> mySet = new HashSet<int>();
            foreach (var i in arr) 
            {
                mySet.Add(i);
            }


            foreach (var d in mySet)
            {
                Console.WriteLine(d);
            }
        }
    }
}