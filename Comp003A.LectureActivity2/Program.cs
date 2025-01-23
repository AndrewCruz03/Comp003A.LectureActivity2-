// Author: {Andrew Cruz Pacheco
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: A Program, demonstrating statements, Variables,  and operators.
namespace Comp003A.LectureActivity2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // First we Declare our variables to get them to work
            String username;
            String username2;
            int userage;
            double productprice;
            double productprice2;
            bool isStudent;

            // This initalizes the variables
            Console.WriteLine("Enter Your first name:");
            username = Console.ReadLine();

            Console.WriteLine("Enter Your Last name");
            username2 = Console.ReadLine();

            Console.Write("Enter your age:");
            userage=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price of a product:");
            productprice = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price of a product:");
            productprice2 = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false):  ");
            isStudent = bool.Parse(Console.ReadLine());

            // does calculations, checks age in 5years and checks if age is over 60
            int futureAge = userage  + 5;
            bool isAdult = userage >= 60;
            double StudentDiscount = (productprice * .90);
            double ElderDiscount = (productprice2 * .80);
            bool isAdultStudent = isStudent && isAdult;

            // Displays data after inputs
            Console.WriteLine($"\nHello, {username} {username2}!");
            Console.WriteLine($"You are currently {userage} years old.\n In 5 years you will be {futureAge}.");
            Console.WriteLine($"The Student discount is {StudentDiscount}");
            Console.WriteLine($"The ElderDiscount is {ElderDiscount}");


        }
    }
}