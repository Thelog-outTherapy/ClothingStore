using System.ComponentModel.DataAnnotations;
using Clothing_store.Enums;

namespace Models.DAL;

public class User
{
    [Key]public int UserId { get; set; }
    
    public string Username { get; set; }
    public string Password { get; set; }
    public string PasswordConfirm { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    
    public int Balance { get; set; }
    public AccessLevel AccessLevel { get; set; }
}