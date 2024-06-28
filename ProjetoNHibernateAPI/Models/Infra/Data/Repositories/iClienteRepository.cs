using Projeto_WebAPI_NHibernate.Models.Domain.Contracts;
using Projeto_WebAPI_NHibernate.Models.Domain.Entities;

namespace Projeto_WebAPI_NHibernate.Models.Infra.Data.Repositories
{
    public interface iClienteRepository : IgenericRepoService<Cliente, int>
    {

    }
}
