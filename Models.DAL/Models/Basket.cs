using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DAL;

public class Basket
{
    [Key]public int ProductId { get; set; }
    public int Quantity { get; set; }
    
    public int ProductTable { get; set; }
    [ForeignKey("ProductTable")]public Product? Product { get; set; }
}