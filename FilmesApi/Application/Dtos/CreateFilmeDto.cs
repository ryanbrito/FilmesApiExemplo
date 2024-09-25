using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Application.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O titulo do filme é obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O Genero do filme é obrigatório!")]
        [StringLength(50, ErrorMessage = "O tamanho de genero não pode exceder 50 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "A duração do filme é obrigatória.")]
        [Range(70, 600, ErrorMessage = "A Duração deve ser entre 70 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
