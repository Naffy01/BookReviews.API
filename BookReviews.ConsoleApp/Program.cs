using System;

namespace BookReviews.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            var student = new Student();
            var studentResult = student.AddNumbers(a, b);
            var asa = student.Sample;

            Console.WriteLine($"Student = {studentResult}");

            var teacherResult = Teacher.AddNumbers(a, b);
            Console.WriteLine($"Teacher = {teacherResult}");

            var res1 = Teacher.ToTitle("Ana", true);
            var res2 = "Agroni".ToTitleExtensionMethod(false);
            var res3 = "ImYmOkIj".ToLower();
            Console.WriteLine($"res1 = {res1}");
            Console.WriteLine($"res2 = {res2}");
            Console.WriteLine($"res3 = {res3}");


            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
