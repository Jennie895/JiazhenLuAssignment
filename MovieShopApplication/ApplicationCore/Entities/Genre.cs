using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class Genre
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Genre Name is required")]
    [Column(TypeName = "varchar(24)")]
    public string Name { get; set; }
}