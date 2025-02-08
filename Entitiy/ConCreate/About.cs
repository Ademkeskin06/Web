﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.ConCreate
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Details1 { get; set; }
        [StringLength(1000)]
        public string Details2 { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        [StringLength(100)]
        public string Image2 { get; set; }

    }
}
