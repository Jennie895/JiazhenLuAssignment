using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace ApplicationCore.Entities;

public class Movie
{
    public int Id { get; set; }
    
    [Column(TypeName = "VARCHAR(2084)")]
    public string BackdropUrl { get; set; }
    
    [Column(TypeName = "decimal(18,4)")]
    public decimal Budget { get; set; }
    
    [Column(TypeName = "varchar(MAX)")]
    public string CreatedBy { get; set; }
    
    [Column(TypeName = "datetime2")]
    public DateTime CreatedDate { get; set; }
    
    [Column(TypeName = "varchar(2084)")]
    public string ImdbUrl { get; set; }
    
    [Column(TypeName = "varchar(64)")]
    public string OriginalLauguage { get; set; }
    
    [Column(TypeName = "varchar(MAX)")]
    public string Overview { get; set; }
    
    [Column(TypeName = "varchar(2084)")]
    public string PosterUrl { get; set; }
    
    [Column(TypeName = "decimal(5,2)")]
    public decimal Price { get; set; }
    
    [Column(TypeName = "datetime2")]
    public DateTime ReleaseDate { get; set; }
    
    [Column(TypeName = "decimal(18,4)")]
    public decimal Revenue { get; set; }
    
    [Column(TypeName = "int")]
    public int Runtime { get; set; }
    
    [Column(TypeName = "varchar(512)")]
    public string Tagline { get; set; }
    
    [Column(TypeName = "varchar(256)")]
    public string Title { get; set; }
    
    [Column(TypeName = "varchar(2084)")]
    public string TmdbUrl { get; set; }
    
    [Column(TypeName = "varchar(MAX)")]
    public string UpdatedBy { get; set; }
    
    [Column(TypeName = "datetime2")]
    public DateTime UpdatedDate { get; set; }
}