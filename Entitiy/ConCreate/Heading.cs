using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.ConCreate
{
    public class Heading
    {
        [Key]
        public int ProductId { get; set; }
        [Required,StringLength(50)]
        public string ProductName { get; set; }
        [Required,StringLength(50)]
        public string Description { get; set; }
        [Required]
        public DateTime ProductTime { get; set; }
        [StringLength(200)]
        public virtual comment comment { get; set; }
        public virtual Category Category { get; set; }
        public virtual Content Content { get; set; } 
        public virtual User User { get; set; }
        public List<Category> Categorys  {  get; set; }
        public List<Content> Contents { get; set; }
        public List<User> Users { get; set; }
    }
}
