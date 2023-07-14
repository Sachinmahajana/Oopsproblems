namespace Oopsproblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the oops problems");
            Console.WriteLine("Select the program given below");
            Console.WriteLine("\n1:Duplicatenumber\n2:FindMaxmin");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Duplicatenumber myObj = new Duplicatenumber();
                    myObj.DuplicateFunction();
                    break;
                case 2:
                    FindMaxmin myObj1 = new FindMaxmin();
                    myObj1.FindMaxMinFunction();
                    break;
            }
        }
    }
}