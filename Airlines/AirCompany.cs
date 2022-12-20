using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airlines;

[Table("air_companies")]
public class AirCompany
{
    [Key]
    [Required]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name_en")]
    public string NameEn { get; set; }
        
    [Column("icao_code")]
    public string IcaoCode { get; set; }
    
    [Column("iata_code")]
    public string IataCode { get; set; }
}