using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebProject.Models
{
    public class AboutViewModel
    {
        public string Info { get; set; }
        public string Description { get; set; }

    }

    public class Figure
    {
        public string Name  { get; set; }

        public int Row { get; set; }

        public string Column { get; set; }

        public void Position(int row, string column)
        {
            
        }
    }
}
