using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using file_organiser;
using file_organizer.data;
using file_organizer;
using System.Runtime.InteropServices;

namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(art.intro_text_banner());

            Console.WriteLine();
            Console.WriteLine("welcome to file organiser!");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Please enter a path to organise:");
                var path = Console.ReadLine();

                if (Directory.Exists(path))
                {
                    Console.WriteLine("nice");

                    Console.WriteLine("options:");
                    var OptionTypes_values = Enum.GetValues(typeof(OptionTypes));
                    foreach (OptionTypes enum_option in OptionTypes_values)
                    {
                        Console.WriteLine(enum_option.ToString());
                    }

                    var chosen_option = Console.ReadLine();

                    if (chosen_option != null)
                    {
                        //tryparse statement is for comparing readlines with enum values through letters
                        if (Enum.TryParse(chosen_option, ignoreCase: true, out OptionTypes result))
                        {
                            Console.WriteLine("log: option is valid!!");
                        }
                        else 
                        {
                            Console.WriteLine("log: option is invalid!!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("this path doesn't exist, please try again");
                }
            }
        }
    }
}
