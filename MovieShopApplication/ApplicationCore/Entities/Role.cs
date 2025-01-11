using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class Role
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    [Column(TypeName = "VARCHAR(20)")]
    public string Name { get; set; }
}