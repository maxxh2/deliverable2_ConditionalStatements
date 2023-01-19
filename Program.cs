/* Name: Maxx Hernandez
   Date: 01/19/2023
   Description: C# Deliverable2 Grade Calculator with conditional statements
*/

namespace deliverable2_conditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the grade you expect to get in ISM 4300: ");
            try
            {
                string input = Console.ReadLine();

                int grade = int.Parse(input);

                if (grade <= 59)
                {
                    Console.WriteLine("Your final grade is a F.");
                }
                else if (grade >= 60 && grade < 62)
                {
                    Console.WriteLine("Your final grade is a D-.");
                }
                else if (grade >= 62 && grade < 68)
                {
                    Console.WriteLine("Your final grade is a D.");
                }
                else if (grade >= 68 && grade < 70)
                {
                    Console.WriteLine("Your final grade is a D+.");
                }
                else if (grade >= 70 && grade < 72)
                {
                    Console.WriteLine("Your final grade is a C-.");
                }
                else if (grade >= 72 && grade < 78)
                {
                    Console.WriteLine("Your final grade is a C.");
                }
                else if (grade >= 78 && grade < 80)
                {
                    Console.WriteLine("Your final grade is a C+.");
                }
                else if (grade >= 80 && grade < 82)
                {
                    Console.WriteLine("Your final grade is a B-.");
                }
                else if (grade >= 82 && grade < 88)
                {
                    Console.WriteLine("Your final grade is a B.");
                }
                else if (grade >= 88 && grade < 90)
                {
                    Console.WriteLine("Your final grade is a B+.");
                }
                else if (grade >= 90 && grade < 92)
                {
                    Console.WriteLine("Your final grade is a A-.");
                }
                else if (grade >= 92 && grade < 98)
                {
                    Console.WriteLine("Your final grade is a A.");
                }
                else
                {
                    Console.WriteLine("Your final grade is a A+.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer (Whole Number).");
            }
        }
    }
}