using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Interfaces
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogoNovo);
        void Deletar(Guid idDoJogo);
        List<Jogo> Listar();
        void Atualizar(Guid idDoJogo,Jogo jogoAtualizado);
    }
}
