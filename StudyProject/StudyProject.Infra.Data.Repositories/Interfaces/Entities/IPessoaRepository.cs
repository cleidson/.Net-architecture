using StudyProject.Infra.Data.Entities;

namespace StudyProject.Infra.Data.Repositories.Interfaces.Entities
{
    internal interface IPessoaRepository
    {
        bool SalvarPessoa(Pessoa pessoa);
        void ExcluirPessoa(Pessoa pessoa);
    }
}