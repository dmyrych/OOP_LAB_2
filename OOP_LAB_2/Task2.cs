using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2
{
    internal class Task2
    {
        public void Run()
        {
            string filePath = @"C:\Users\Дмитрий\source\repos\OOP_LAB_2\OOP_LAB_2\Students.txt";
            string[] lines = new string[3];
            StreamReader streamReader = new StreamReader(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = streamReader.ReadLine();
            }
            var students = lines.Select(line =>
            {
                string[] stringParts = line.Split(',');
                return new Student
                {
                    Name = stringParts[0],
                    Grade1 = int.Parse(stringParts[1]),
                    Grade2 = int.Parse(stringParts[2]),
                    Grade3 = int.Parse(stringParts[3]),
                };
            });
            // Sort students by average grade using lambda expression
            var sortedStudents = students.ToArray();
            Array.Sort(sortedStudents, (Student x, Student y) => x.AverageGrade().CompareTo(y.AverageGrade()));
            // Output sorted student data
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.Name + ": " + student.AverageGrade());
            }
            Console.ReadKey();
        }
    }
}
