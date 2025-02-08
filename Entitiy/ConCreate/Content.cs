using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.ConCreate
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Name { get; set; }// içerik adı
        [StringLength(100)]
        public string Description { get; set; }// açıklama 
        public DateTime CreatedDate { get; set; }// oluşturma tarihi
        public int HeadingId { get; set; } 
        public string CommetId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual Heading Heading { get; set; }
        public List<Heading> headings { get; set; }
        public List<User> users { get; set; }
    }
}
