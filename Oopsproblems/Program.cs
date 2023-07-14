namespace Oopsproblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the oops problems");
            Console.WriteLine("Select the program given below");
            Console.WriteLine("\n1:Duplicatenumber\n2:FindMaxmin\n3:FirstletterCapital");
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
                case 3:
                    FirstletterCapital myObj2 = new FirstletterCapital();
                    myObj2.FirstLetterCapitalFunction();
                    break;
            }
        }
    }
}