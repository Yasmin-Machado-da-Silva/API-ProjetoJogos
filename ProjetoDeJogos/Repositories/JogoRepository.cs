using ProjetoDeJogos.Contexts;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;

namespace ProjetoDeJogos.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly ProjetoJogosContext _context;

        public JogoRepository(ProjetoJogosContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid idDoJogo, Jogo jogoAtualizado)
        {
            try
            {
                Jogo jogoBuscado = _context.Jogos.Find(idDoJogo)!;

                if (jogoBuscado != null)
                {
                    jogoBuscado.NomeDoJogo = jogoAtualizado.NomeDoJogo;
                }

                _context.Jogos.Update(jogoBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void Cadastrar(Jogo jogoNovo)
        {
            try
            {
                jogoNovo.JogoID = Guid.NewGuid();

                _context.Jogos.Add(jogoNovo);

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
                Jogo jogoBuscado = _context.Jogos.Find(id)!;

                if (jogoBuscado != null)
                {
                    _context.Jogos.Remove(jogoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Jogo> Listar()
        {
            try
            {
                return _context.Jogos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}