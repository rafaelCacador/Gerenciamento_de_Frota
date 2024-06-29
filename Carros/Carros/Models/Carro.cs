using System.ComponentModel.DataAnnotations;

namespace Carros.Models
{
    public class Carro
    {
        public int Id { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Preço deve ser um valor positivo.")]
        public decimal Preco { get; set; }
    }
}
