using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.ConCreate
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string SurName { get; set;}
        [StringLength(50)]
        public string Mail { get; set;}
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(100)]
        public string UserImage { get; set; }
        public List<Heading> headings { get; set; }
        public List<Content> contents { get; set; }

    }
}
