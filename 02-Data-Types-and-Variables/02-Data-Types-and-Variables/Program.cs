using System;

namespace DataTypesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student Registration Syste*/

            // 1. (Constants)
            const string UNIVERSITY_NAME = "\"Faculty of Computer Science\"";

            // 2. (\n, \t) 
            Console.WriteLine("Welcome to " + UNIVERSITY_NAME);
            Console.WriteLine("--------------------------------------------------\n");

            // 3. String & ReadLine
            Console.Write("Enter your full name: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");

            // 4. int & int.Parse()
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");

            // 5. long & long.Parse()
            Console.Write("Enter your National ID (14 digits): ");
            long nationalId = long.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");

            // 6. float & float.Parse()
            Console.Write("Enter your High School percentage : ");
            float highSchoolScore = float.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");

            // 7. double & double.Parse()
            Console.Write("Enter your Target GPA : ");
            double targetGpa = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");

            // 8. char & char.Parse()
            Console.Write("Enter your section (A, B, or C): ");
            char section = char.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");

            // 9. bool & bool.Parse()
            Console.Write("Are you a full-time student? (true/false): ");
            bool isFullTime = bool.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");


            // // // single-line comment
            float minPassingScore = 50.0F;
            long maxStudentsAllowed = 10000000000L;

            // 10. (Output)
            Console.WriteLine("\n======================================");
            Console.WriteLine("Registration Summary for: " + studentName);
            Console.WriteLine("======================================");

            Console.WriteLine("Age:\t\t" + age);
            Console.WriteLine("National ID:\t" + nationalId);
            Console.WriteLine("HS Score:\t" + highSchoolScore + "% (Minimum required: " + minPassingScore + "%)");
            Console.WriteLine("Target GPA:\t" + targetGpa);
            Console.WriteLine("Section:\t" + section);
            Console.WriteLine("Full-Time:\t" + isFullTime);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\nRegistration completed successfully!");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
