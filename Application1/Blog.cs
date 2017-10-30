using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual List<Post> Posts { get; set; }

        public string UserName { get; set; }
        public virtual User User { get; set; }
    }
}
