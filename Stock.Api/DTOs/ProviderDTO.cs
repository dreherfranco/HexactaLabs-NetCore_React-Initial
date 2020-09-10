using Stock.Model.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stock.Api.DTOs
{
    public class ProviderDTO
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        public List<Product> OfferedProducts { get; set; }
    }
}