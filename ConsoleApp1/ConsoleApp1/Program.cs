using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();
            
            string answer;

            do
            {
                Console.WriteLine("Enter your exam grade. >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                examGrades.Add(grade);

                Console.WriteLine("Do you have another exam score, y or n?>>");
                answer = Console.ReadLine();

            } while (answer == "y");

            int exams = (examGrades.Count);
            double sum = 0;
            double max = 0;
            double min = 100;

            for (int i = 0; i < exams; i++)
            {
                sum = sum + examGrades[i];
                if (examGrades[i]>max)
                {
                    max = examGrades[i];
                }
                if (examGrades[i]<min)
                {
                    min = examGrades[i];
                }
            }
            double average = sum / exams;

            Console.WriteLine($"Your average exam score is {average}");
            Console.WriteLine($"Your maximum exam score is {max}");
            Console.WriteLine($"Your minimum exam score is {min}");

            Console.ReadKey();
        }
    }
}
