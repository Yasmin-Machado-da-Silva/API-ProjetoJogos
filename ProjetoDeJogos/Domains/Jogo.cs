using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

//Onde a classe jogos se encontra (caminho da classe jogo - namespace)
namespace ProjetoDeJogos.Domains
{
    [Table("Jogo")]
    //Faz com que um atributo NÃO se repita (ex: Faz com que o NomeDoJogo n se repita)
    [Index(nameof(NomeDoJogo), IsUnique = true)]
    //Cria uma classe publica - Public Class
    public class Jogo
    {
        //Preencher as atributos
        [Key]
        public Guid JogoID { get; set; }
        
        [Column(TypeName = "VARCHAR(50)")]
        //O required faz com que seja obrigatorio preencher o campo do
        //atributo (ex: Faz com que o campo de NomeDoJogo seja obrigatorio)
        [Required(ErrorMessage = "O nome do jogo é obrigatório")]
        public string? NomeDoJogo {  get; set; }
        
        [Column(TypeName = "VARCHAR(50)")]
        public string? Plataforma { get; set; }

    }
}
