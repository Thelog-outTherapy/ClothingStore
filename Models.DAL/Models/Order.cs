using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Clothing_store.Enums;

namespace Models.DAL;

public class Order
{
    [Key]public int OrderId { get; set; }
    
    public int ProductTable { get; set; }
    [ForeignKey("ProductTable")]public Product? Product { get; set; }

    public int UserTable { get; set; }
    [ForeignKey("UserTable")]public User? User { get; set; }

    public int ProductsQuantityInOrder { get; set; }
    
    public TimeOnly OrderTime { get; set; }
    public DateOnly OrderDate { get; set; }
    
    public string CountryOfDelivery { get; set; }
    public string RegionOfDelivery { get; set; }
    public string LocalityOfDelivery { get; set; }
    public string StreetOfDelivery { get; set; }
    public int HouseNumberOfDelivery { get; set; }
    public int? FlatNumberOfDelivery { get; set; }

    public OrderStatus OrderStatus { get; set; }


}