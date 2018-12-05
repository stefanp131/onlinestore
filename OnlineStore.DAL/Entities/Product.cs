using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
        public string Properties { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
