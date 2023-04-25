using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP.Data.Models
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }
        public string? AdresBilgisi { get; set; }
        [Required]
        public string City { get; set; }
        public string? Town { get; set; }

    }
}
