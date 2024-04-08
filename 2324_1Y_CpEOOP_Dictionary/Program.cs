using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_CpEOOP_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaration of a dictionary
            Dictionary<int, string> dicSample = new Dictionary<int, string>();
            Dictionary<string, string> krizan = new Dictionary<string, string>();
            string temp = "";
            string temp2 = "";

            // adding things to a dictionary
            krizan["20"] = "The first sample";
            krizan["23-0116c"] = "Krizan Singh";

            // display
            Console.WriteLine(krizan["20"]);
            Console.WriteLine(krizan["23-0116c"]);

            // overwrite
            krizan["20"] = "Changing the sample";

            // display
            Console.WriteLine(krizan["20"]);

            Console.Write("\n\nWhat word would you like to add to the dictionary? ");
            temp = Console.ReadLine();
            if(krizan.ContainsKey(temp)) 
            {
                Console.WriteLine($"The word {temp} already exists and has the following meaning:" +
                    $"\n{krizan[temp]}");
                Console.WriteLine("What would you like to change it to? (Leave this blank if you would like to retain old meaning)");
                temp2 = Console.ReadLine();
                if (temp2.Length > 0)
                {
                    krizan[temp] = temp2;
                    Console.WriteLine("Change implemented");
                }
                else
                    Console.WriteLine("No Change");
            }
            else
            {
                Console.WriteLine($"What would you like the {temp} to mean?");
                krizan[temp] = Console.ReadLine();
                Console.WriteLine("Word added.");
            }

            foreach(KeyValuePair<string, string> k in krizan)
            {
                Console.WriteLine($"{k.Key} => {k.Value}");
            }

            Console.ReadKey();
        }
    }
}
