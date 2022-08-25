namespace MethodOverloadingExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Lets add together two integers. Give me the first number.");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Give me a second number to add to the first.");
            var y = int.Parse(Console.ReadLine());

            //Method Recall
            Console.WriteLine("");
            Console.WriteLine(Add(x, y));
            Console.WriteLine("");

            Console.WriteLine("Lets add together two decimals. Give me the first decimal.");
            var w = decimal.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Give me a second decimal to add to the first.");
            var z = decimal.Parse(Console.ReadLine());

            //Method Recall
            Console.WriteLine("");
            Console.WriteLine(Add(w, z));
            Console.WriteLine("");

            Console.WriteLine("Lets see how much money we have together. How much money do you have?");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Great, I have...");
            var b = double.Parse(Console.ReadLine());

            //Method Recall
            Console.WriteLine("");
            Console.WriteLine($"Together we have {Add(a, b, false)}");
            Console.WriteLine("");

        }
        //Create an Add method:
        //This Add method takes 2 integer parameters
        public static int Add(int x, int y)
        {
            return x + y;
        }
        //Create an overload of the Add method:
        //This Add method needs to have 2 decimal parameters
        public static decimal Add(decimal w, decimal z)
        {
            return w + z;
        }
        /*
          Create another overload of the Add method:
          This Add method returns a string
          And this Add method takes 3 parameters
          2 integer parameters
          1 boolean parameters
        */
        public static string Add(double a, double b, bool i)
        {
            i = false;
            if ((a + b == 1) && (i = true))
            {
                return ($"{a + b} dollar");
            }
            else if ((a + b > 1) && (i = true))
            {
                return ($"{a + b} dollars");
            }
            else if ((a + b < 1) && (i = true))
            {
                return ($"{a + b} dollar");
            }
            else 
            return (a + b).ToString();
        }
    }
}