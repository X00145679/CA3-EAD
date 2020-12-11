using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA3
{
    public class Resource
    {
        public string type { get; set; }
        public string src { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string credit { get; set; }

    }
   
    public class Results
    {
        public string display_name { get; set; }
        public string sort_name { get; set; }
        public string status { get; set; }
        public string bio { get; set; }
        public string seo_name { get; set; }
        public Multimedia multimedia { get; set; }

    }
    public class Reviewer
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public int num_results { get; set; }
        public IList<Results> results { get; set; }

        public class Multimedia
           {
               public Resource resource { get; set; }

           }
    }
}
