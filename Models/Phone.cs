using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Martin_Manuel_proiect.Models
{
    public class Phone
    {
        public int ID { get; set; }
        [Display(Name = "Phone name")]
        public string Model { get; set; }
        public string Brand { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int Supplier { get; set; }
        
    }
}
