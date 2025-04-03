using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuarioNovo);
        void Deletar(Guid idDoUsuario);
        List<Usuario> Listar();
        void Atualizar(Guid idDoUsuario, Usuario usuarioAtualizado);
    }
}
