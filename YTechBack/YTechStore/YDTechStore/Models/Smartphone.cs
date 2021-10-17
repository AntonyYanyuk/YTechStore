using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YTechStore.Models
{
    public class Smartphone
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

    }
}
