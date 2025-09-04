using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DAL;

public class Feedback
{
    [Key]public int FeedbackId { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }
    
    public int ProductTable { get; set; }
    [ForeignKey("ProductTable")]public Product? Product { get; set; }
    
    public int UserTable { get; set; }
    [ForeignKey("UserTable")]public User? User { get; set; }
}