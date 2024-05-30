using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsHomwork
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";


            while (string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine(message);
                output = Console.ReadLine();
            }

            return output;
        }
    }
}
