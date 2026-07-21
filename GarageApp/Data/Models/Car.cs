using System.ComponentModel.DataAnnotations;
using GarageApp.Data.Enums;
namespace GarageApp.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string Make { get; set; } = null!;
        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string Model { get; set; } = null!;
        [Range(1920, 2100)]
        public int Year { get; set; }
        public CarType Type {  get; set; }
        public bool IsAvailable { get; set; }
        public int GarageId { get; set; }
        public virtual Garage Garage { get; set; } = null!;
    }
}
