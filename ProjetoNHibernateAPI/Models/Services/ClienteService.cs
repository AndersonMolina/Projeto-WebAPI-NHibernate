using Projeto_WebAPI_NHibernate.Models.Domain.Entities;
using Projeto_WebAPI_NHibernate.Models.Infra.Data.Repositories;

namespace Projeto_WebAPI_NHibernate.Models.Services
{
    public class ClienteService : IClienteService
    {
        private readonly iClienteRepository _clienteRepository;

        public ClienteService(iClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
 
        public async Task Atualizar(Cliente entidade)
        {
            await _clienteRepository.Atualizar(entidade);
        }

        public async Task Cadastrar(Cliente entidade)
        {
            await _clienteRepository.Cadastrar(entidade);   
        }

        public async Task Excluir(int id)
        {
            await _clienteRepository.Excluir(id);
        }

        public List<Cliente> Listar()
        {
            var result = _clienteRepository.Listar();

            return result;
        }

        public Cliente PesquisaPorID(int id)
        {
            var result = _clienteRepository.PesquisaPorID(id);
            return result;

        }
    }
}
