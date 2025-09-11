using System.ComponentModel.DataAnnotations;
using Clothing_store.Enums;

namespace Models.DAL;

public class Product
{
    [Key]public int ProductId { get; set; }
    
     public string Category { get; set; }
     public string ProductType { get; set; }
     public string Color { get; set; }
     public string Sex { get; set; }
     public string Material { get; set; }
     public string ProductName { get; set; }
     public string Description { get; set; }
     public string Brand { get; set; }
     public string ImageUrl { get; set; }
    
     public decimal Price { get; set; }
    
}