using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O titulo do filme é obrigatório!")]
        public String Titulo { get; set; }
        [Required(ErrorMessage = "O Genero do filme é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O tamanho de genero não pode exceder 50 caracteres")]
        public String Genero { get; set; }
        [Required(ErrorMessage = "A duração do filme é obrigatória.")]
        [Range(70, 600, ErrorMessage = "A Duração deve ser entre 70 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
