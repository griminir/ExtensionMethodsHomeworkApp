using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsHomwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel();
            person.FirstName = "What is your first name: ".RequestString();

            person.LastName = "What is your last name: ".RequestString();

            person.Age = "what is your age: ".RequestInt(0, 120);

            Console.ReadLine();
        }
    }
}
