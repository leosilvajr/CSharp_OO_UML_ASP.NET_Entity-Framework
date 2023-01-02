using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["User"] = "Maria";
            cookies["Email"] = "maria@gmail.com";
            cookies["Phone"] = "997255687";
            cookies["Phone"] = "984984896"; //Sobescreve o valor anterior

            Console.WriteLine(cookies["Email"]);
            Console.WriteLine(cookies["Phone"]);

            cookies.Remove("Email");

            if (cookies.ContainsKey("Email"))
            {
                Console.WriteLine(cookies["Email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' Key");
            }

            Console.WriteLine();
            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine();
            Console.WriteLine("ALL COOKIES");
            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine(item.Key+": " + item.Value);
            }

        }
    }
}
