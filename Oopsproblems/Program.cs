namespace Oopsproblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the oops problems");
            Console.WriteLine("Select the program given below");
            Console.WriteLine("\n1:Pattern\n2:FindmaxminArray\n3:SumofDigits\n4:Reversestringeachword\n5:FindDuplicates");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Duplicatenumber myObj = new Duplicatenumber();
                    myObj.DuplicateFunction();
                    break;
            }
        }
    }
}