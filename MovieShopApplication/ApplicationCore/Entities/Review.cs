using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class Review
{
    [Required(ErrorMessage = "Create date is required")]
    [Column(TypeName = "datetime2")]
    public DateTime CreateDate { get; set; }
    
    [Required(ErrorMessage = "Rating is required")]
    [Column(TypeName = "decimal(3,2)")]
    public decimal Rating { get; set; }
    
    [Required(ErrorMessage = "Comment is required")]
    [Column(TypeName = "varchar(MAX)")]
    public string ReviewText { get; set; }
}