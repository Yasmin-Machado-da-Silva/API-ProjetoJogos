using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetoDeJogos.Domains
{
    [Table("Usuario")]
    [Index(nameof(Nome), IsUnique =true)]
    [Index(nameof(Nickname), IsUnique =true)]

    public class Usuario
    {
        [Key]
        public Guid UsuarioID { get; set; }

        [Column(TypeName = "VARCHAR(85)")]
        [Required(ErrorMessage = "O nome é obrigatorio")]
        public string? Nome { get; set; }
        
        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "O nickname é obrigatorio")]
        public string? Nickname { get; set; }
        
        public Guid JogoFavorito { get; set; }
        [ForeignKey("JogoFavorito")]
        public Jogo ? Jogos { get; set;}
    }
}