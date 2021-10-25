using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PreAceleracion.Entities
{
    public class Posts
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }
        [Required]
        public Users User { get; set; }
    }
}
