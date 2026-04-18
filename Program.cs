using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demobasedonnongenriccollecton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implementing list........
              List<int> numbers = new List<int>();

// Adding elements to the list  
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            Console.WriteLine("List Elements:");
// Display all elements
            foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }


//implementing dictionary.......
                Dictionary<int, string> students = new Dictionary<int, string>();

// Adding elements to the dictionary
                students.Add(1, "Satyam");
                students.Add(2, "Rahul");
                students.Add(3, "Amit");

// Access value using key
                Console.WriteLine("Student with ID 1: " + students[1]);

           

// Display all elements
                Console.WriteLine("\nDictionary Elements:");
                foreach (KeyValuePair<int, string> item in students)
                {
                    Console.WriteLine("ID: " + item.Key + ", Name: " + item.Value);
                }

        }
    }
}
