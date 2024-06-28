namespace Projeto_WebAPI_NHibernate.Models.Domain.Contracts
{
    public interface IgenericRepoService <T, Y>
    {
        Task Cadastrar(T entidade);

        Task Atualizar(T entidade);

        Task Excluir(Y id);

        T PesquisaPorID(Y id);

        List<T> Listar();

    }
}
