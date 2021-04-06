using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LastLab.Models
{
    public class StdGrade
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int CrsId { get; set; }

        public int Grade { get; set; }
    }
}