using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class Purchase
{
    [Required(ErrorMessage = "The purchase time is required")]
    [Column(TypeName = "datetime2")]
    public DateTime PurchaseDateTime { get; set; }
    
    [Required(ErrorMessage = "The purchase number is required")]
    [Column(TypeName = "uniqueidentifier")]
    public String PurchaseNumber { get; set; }
    
    [Required(ErrorMessage = "The price is required")]
    [Column(TypeName = "decimal(5,2)")]
    public decimal TotalPrice { get; set; }
}