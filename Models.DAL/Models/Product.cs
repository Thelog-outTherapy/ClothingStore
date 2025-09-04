using System.ComponentModel.DataAnnotations;
using Clothing_store.Enums;

namespace Models.DAL;

public class Product
{
    [Key]public int ProductId { get; set; }
    
     public Categories Category { get; set; }
     public ProductTypes ProductType { get; set; }
     public Colors Color { get; set; }
     public Sex Sex { get; set; }
    
     public string ProductName { get; set; }
     public string Description { get; set; }
     public string Brand { get; set; }
     public string ImageUrl { get; set; }
    
     public decimal Price { get; set; }
     public int Size { get; set; }
}