using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2
{
    internal class Task3
    {
        public void Run()
        {
            string filePath = @"C:\Users\Дмитрий\source\repos\OOP_LAB_2\OOP_LAB_2\Students.txt";
            string[] lines = new string[9];
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
                    Group = int.Parse(stringParts[4]),
                };
            });
            Console.WriteLine("Writing all students: ");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, is part of a Group{student.Group}");
            }
            Console.WriteLine("Grouping students by their group: ");
            var studentsByGroup = students.GroupBy(s => s.Group)
                                          .OrderBy(g => g.Key);
            Console.WriteLine("Students by group: ");
            foreach (var group in studentsByGroup)
            {
                Console.WriteLine("Група: {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine($"{student.Name} ");
                }
            }
        }
    }
}
