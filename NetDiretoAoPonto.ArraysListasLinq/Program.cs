using System;
using System.Collections.Generic;
using System.Linq;

namespace NetDiretoAoPonto.ArraysListasLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numbersCopy = new int[10];

            // 0-based

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersCopy[i] = numbers[i];
            }

            var numberString = "0 1 2 3 4 5 6 7 8 9";
            var numbersArray = numberString.Split(' ');
            var numbersConvertedFromString = Array.ConvertAll(numbersArray, Convert.ToInt32);

            #endregion

            #region Listas

            //var list = new List<int>(); 
            var list = new List<int> { 0, 1, 2, 3, 4 };
            var listFromArray = new List<int>(numbers);

            list.Add(5);
            list.AddRange(new List<int> { 6, 7 });
            list.AddRange(new int[] { 8, 9 });

            var count = list.Count;

            var contains14 = list.Contains(14);
            var contains2 = list.Contains(2);

            Console.WriteLine("Lista Reversa: ");
            list.Reverse();
            list.ForEach(l => Console.WriteLine(l));

            Console.WriteLine("Lista Ordenada: ");
            list.Sort();
            list.ForEach(l => Console.WriteLine(l));

            list.Remove(4);
            list.RemoveAll(l => l > 5);

            list.Clear();


            #endregion

            #region LINQ

            var students = new List<Student>
            {
                new Student(1, "Luis", "12345678910", 100),
                new Student(2, "Roberto", "98765432110", 35),
                new Student(3, "Bianca", "32165498701", 85),
                new Student(4, "Helena", "78945612301", 70),
                new Student(5, "Luis", "43265487699", 75)
            };


            // Any

            var any = students.Any();
            var any100 = students.Any(s => s.Grade == 100);

            // Single, SingleOrDefault

            var single = students.Single(s => s.Id == 1);
            var singleOrDefault = students.SingleOrDefault(s => s.Grade == 0);
            var singleOrDefaultDocument = students.SingleOrDefault(s => s.Document == "12345678910");

            // First, FirstOrDefault

            var first = students.First(s => s.FullName == "Luis");
            var firstOrDefault = students.FirstOrDefault(s => s.Grade == 0);

            // OrderBy, OrderByDescending

            var orderedByGrade = students.OrderBy(s => s.Grade);
            var orderedByGradeDescending = students.OrderByDescending(s => s.Grade);

            // Where

            var approvedStudents = students.Where(s => s.Grade >= 70);

            // Select, SelectMany

            var grades = students.Select(s => s.Grade);
            var phoneNumbers = students.SelectMany(s => s.PhoneNumbers);

            // Sum, Min, Max, Count

            var sum = students.Sum(s => s.Grade);
            var min = students.Min(s => s.Grade);
            var max = students.Max(s => s.Grade);
            var countStudents = students.Count;

            #endregion LINQ

            Console.ReadKey();
        }
    }

    public class Student
    {
        public Student(int id, string fullName, string document, int grade)
        {
            Id = id;
            FullName = fullName;
            Document = document;
            Grade = grade;

            PhoneNumbers = new List<string> { "1234545454", "5415465545", "46546546546" };
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Document { get; set; }
        public int Grade { get; set; }
        public List<string> PhoneNumbers { get; set; }

    }
}
