using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PreAceleracion.Entities
{
    public class Comments
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }
        [Required]
        public Users User { get; set; }

    }
}
