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
            int userage;
            double productprice;
            bool isStudent;

            // This initalizes the variables
            Console.WriteLine("Enter Your name:");
            username = Console.ReadLine();

            Console.Write("Enter your age:");
            userage=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price of a product:");
            productprice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false):  ");
            isStudent = bool.Parse(Console.ReadLine());

            // does calculations, checks age in 5years and checks if age is over 18
            int futureAge = userage  + 5;
            bool isAdult = userage >= 18;
            bool isAdultStudent = isStudent && isAdult;

            // Displays data after inputs
            Console.WriteLine($"\nHello, {username}!");
            Console.WriteLine($"You are currently {userage} years old. In 5 years you will be {futureAge}.");
            Console.WriteLine($"Are you 18 or older? {isAdult}");
            Console.WriteLine($"Are you both a student and 18 or older? {isAdultStudent}");
          
        }
    }
}