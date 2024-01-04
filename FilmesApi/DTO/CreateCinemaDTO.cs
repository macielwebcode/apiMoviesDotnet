using FilmesApi.Models;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.DTO
{
    public class CreateCinemaDTO
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório.")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<Sessao> Sessoes { get; set; }
    }
}
