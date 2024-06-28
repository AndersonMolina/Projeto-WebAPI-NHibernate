using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_WebAPI_NHibernate.Models.Domain.Entities;
using Projeto_WebAPI_NHibernate.Models.Services;

namespace Projeto_WebAPI_NHibernate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(int? id, string nome, string email, string fone)
        {
            Cliente cliente = new Cliente() { Id = Convert.ToInt32(id), Nome = nome, Email = email, Fone = fone };
            await _clienteService.Cadastrar(cliente);
            return Ok("Cadastro realizado");
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(int? id, string nome, string email, string fone)
        {
            Cliente cliente = new Cliente() { Id = Convert.ToInt32(id), Nome = nome, Email = email, Fone = fone };
            await _clienteService.Atualizar(cliente);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoverCliente(int id)
        {
            await _clienteService.Excluir(id);
            return Ok();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var clientes = _clienteService.Listar();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public IActionResult PesquisaPorId(int id)
        {
            var cliente = _clienteService.PesquisaPorID(id);
            if (cliente == null)
                return NotFound();
            return Ok(cliente); 
        }
    }
}
