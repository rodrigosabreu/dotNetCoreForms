

using System.ComponentModel.DataAnnotations;

namespace dotNetCoreForms.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Id é obrigatório")]
        [Range(10,20, ErrorMessage = "Número de 10 a 20")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name é obrigatório")]
        [MinLength(3, ErrorMessage = "Minimo com 3 letras")]
        //[MaxLength(5)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price é obrigatório")]
        [Range(1,int.MaxValue, ErrorMessage = "Número de 1 a muito numero")]
        public int Price { get; set; }
    }
}