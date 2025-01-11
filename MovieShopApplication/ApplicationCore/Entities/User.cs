using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class User
{
    public int Id { get; set; }
    
    [Column(TypeName = "datetime2")]
    public DateTime DateOfBirth { get; set; }
    
    [Required(ErrorMessage = "Email is required")]
    [Column(TypeName = "varchar(256)")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "First name is required")]
    [Column(TypeName = "varchar(128)")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Password is required")]
    [Column(TypeName = "varchar(1024)")]
    public string HashedPassword { get; set; }
    
    [Column(TypeName = "bit")]
    public int IsBlocked { get; set; }
    
    [Required(ErrorMessage = "Last name is required")]
    [Column(TypeName = "varchar(128)")]
    public string LastName { get; set; }
    
    [Column(TypeName = "varchar(16)")]
    public string PhoneNumber { get; set; }
    
    [Column(TypeName = "varchar(MAX)")]
    public string ProfilePictureUrl{ get; set; }
    
    [Required(ErrorMessage = "Salt is required")]
    [Column(TypeName = "varchar(1024)")]
    public string Salt { get; set; }
}