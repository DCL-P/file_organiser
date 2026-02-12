using file_organizer;
using main;
using System;
using System.Collections.Generic;
using System.Text;

namespace file_organiser
{
    public class program
    {
        private string path;
        private OptionTypes option;

        public string process_option(string path, OptionTypes option)
        {
            if (option is OptionTypes)
            {
                return "bam";
            }

            return "the given option is not available. Please try again";
        }
    }
}
