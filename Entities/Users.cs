using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PreAceleracion.Entities
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public ICollection<Posts> Posts { get; set; }

        public ICollection<Comments> Comments { get; set; }
    }
}
