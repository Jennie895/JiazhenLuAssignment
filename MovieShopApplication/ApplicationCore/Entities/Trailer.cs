using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class Trailer
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Trailer name is required")]
    [Column(TypeName = "VARCHAR(2084)")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Trailer Url is required")]
    [Column(TypeName = "VARCHAR(2084)")]
    public string TrailerUrl { get; set; }
}