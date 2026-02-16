using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using file_organiser;
using file_organizer.data;
using file_organizer;

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
                        //if (Enum.Parse<OptionTypes>(chosen_option) in OptionTypes_values) 
                        //{
                        //    program obj = new program();
                        //    obj.process_option(path, chosen_option);
                        //}
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
