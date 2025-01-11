using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class Cast
{
    public int Id { get; set; }
    
    [Required(ErrorMessage= "Gender is required")]
    [Column(TypeName = "varchar(MAX)")]
    public string Gender { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    [Column(TypeName = "varchar(128)")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "ProfilePath is required")]
    [Column(TypeName = "varchar(2084)")]
    public string ProfilePath { get; set; }
    
    [Required (ErrorMessage = "TmdbUrl is required")]
    [Column(TypeName = "varchar(MAX)")]
    public string TmdbUrl { get; set; }
    
}