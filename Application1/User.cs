﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Description { get; set; }
        public virtual List<Blog> Blogs { get; set; }
    }
}
