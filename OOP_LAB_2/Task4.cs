using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2
{
    internal class Task4
    {
        public delegate int stringLength(string str);
        public void Run()
        {
            List<string> stringList = new List<string>() {"333", "Subjucation", "Java is the best!", "Michailo is the best friend" };

            stringLength lengthDelegate = str => str.Length;

            foreach (string str in stringList)
            {
                int length = lengthDelegate(str);
                Console.WriteLine($"the length of '{str}' is {length}.");
            }
        }
    }
}
