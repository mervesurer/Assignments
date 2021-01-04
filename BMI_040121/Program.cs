using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_040121
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your mass (in kilograms): ");
                double mass = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your height (in meters): ");
                double height = Convert.ToDouble(Console.ReadLine());

                double BMI = mass / (height * height);

                Console.WriteLine($"Your body measure index is; {BMI}");

                if (BMI <= 18.4)
                    Console.WriteLine("Your situation is under weight!");
                else if (18.5 <= BMI && BMI <= 24.9)
                    Console.WriteLine("Your situation is normal weight!");
                else if (25 <= BMI && BMI <= 29.9)
                    Console.WriteLine("Your situation is over weight!");
                else if (30 <= BMI && BMI <= 34.9)
                    Console.WriteLine("Your situation is obesity (Class 1)!");
                else if (35 <= BMI && BMI <= 39.9)
                    Console.WriteLine("Your situation is obesity (Class 2)!");
                else
                    Console.WriteLine("Your situation is obesity (Class 3)!");
            }
            catch (FormatException)
            {

                Console.WriteLine("Enter a numerical value!!");
            }

            catch (Exception ex)
            {
                Console.WriteLine("There is an error " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
