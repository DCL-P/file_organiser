using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using file_organizer;
using main;

namespace file_organiser.program
{
    public class process_option
    {
        public string Path;
        public OptionTypes Option;

        public void constructor(string path, OptionTypes option)
        {
            Path = path;
            Option = option;
        }

        public string process(string path, string option)
        {
            var CLEAN = Enum.Parse<OptionTypes>("CLEAN");
            var MOVE = Enum.Parse<OptionTypes>("MOVE");
            var ORGANISE = Enum.Parse<OptionTypes>("ORGANISE");

            if (option is CLEAN)
            {
                return "bam";
            }

            return "the given option is not available. Please try again";
        }
    }
}
