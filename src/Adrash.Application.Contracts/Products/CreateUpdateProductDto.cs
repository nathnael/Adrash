using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Adrash.Products
{
    public class CreateUpdateProductDto
    {
        [Required]
        [StringLength(128)]
        public string Brand { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }
                
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
