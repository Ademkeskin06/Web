using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.ConCreate
{
    public class Category : Heading
    {
        [Key]
        public int CategoryId { get; set; }
        public bool Status { get; set; }
        public List<Heading> headings { get; set; }

       


    }
}
