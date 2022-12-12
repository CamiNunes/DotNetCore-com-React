using System.ComponentModel.DataAnnotations;

namespace Alunos.WebApi.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        public int Idade { get; set; }
    }
}
