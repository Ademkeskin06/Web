using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.ConCreate
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        public List<User> users { get; set; }
        [StringLength(1000)]
        public string Message { get; set; }
        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }   
}
