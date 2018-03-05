using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Car
    {

        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Brand { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Model { get; set; }

        [Range(1, 2018)]
        [Required]
        public int Year { get; set; }

        [Range(1, 1500)]
        public int Hk { get; set; }

        [Range(1, 2000000)]
        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }



    }
}
