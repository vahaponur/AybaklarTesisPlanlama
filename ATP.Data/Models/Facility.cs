using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP.Data.Models
{
    public  class Facility
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public virtual Adress? Adress { get; set; }
        /// <summary>
        /// The cost to start of the facility. One time cost like building, field, machines etc.
        /// </summary>
        public decimal? InitialInvCost { get; set; }
     public decimal? YearlyCost { get; set; }
    public decimal?  YearlyAverageProfit{ get; set; }
        public bool Rented { get; set; }
        public decimal? YearlyRentCost { get; set;}

    }
}
