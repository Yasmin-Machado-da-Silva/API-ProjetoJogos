using ProjetoDeJogos.Contexts;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;

namespace ProjetoDeJogos.Repositories
{
    public class UsuariosRepository : IUsuarioRepository
    {
        private readonly ProjetoJogosContext _context;

        public UsuariosRepository(ProjetoJogosContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid idDoUsuario, Usuario usuarioAtualizado)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuarios.Find(idDoUsuario)!;

                if (usuarioBuscado != null)
                {
                    usuarioBuscado.Nome = usuarioAtualizado.Nome;
                }

                _context.Usuarios.Update(usuarioBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void Cadastrar(Usuario Usuarios)
        {
            try
            {
                Usuarios.UsuarioID = Guid.NewGuid();

                _context.Usuarios.Add(Usuarios);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuarios.Find(id)!;

                if (usuarioBuscado != null)
                {
                    _context.Usuarios.Remove(usuarioBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuario> Listar()
        {
            try
            {
                return _context.Usuarios.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}