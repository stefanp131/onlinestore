namespace OnlineStore.API.Models
{
    public class ProductForCreationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
        public string Properties { get; set; }
    }
}
