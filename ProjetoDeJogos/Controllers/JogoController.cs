using Microsoft.AspNetCore.Mvc;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;
using ProjetoDeJogos.Repositories;

namespace ProjetoDeJogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]

    public class JogoController : ControllerBase
    {
        private readonly IJogoRepository _jogoRepository;
        public JogoController(JogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_jogoRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        public IActionResult Post(Jogo jogo)
        {
            try
            {
                _jogoRepository.Cadastrar(jogo);

                return StatusCode(201, jogo);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Jogo jogo)
        {
            try
            {
                _jogoRepository.Atualizar(id, jogo);

                return StatusCode(204, jogo);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _jogoRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
