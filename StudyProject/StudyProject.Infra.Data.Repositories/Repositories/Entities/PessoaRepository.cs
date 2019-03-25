using StudyProject.Infra.Data.Entities;
using StudyProject.Infra.Data.Persistence;
using StudyProject.Infra.Data.Repositories.Interfaces.Entities;
using StudyProject.Infra.Data.Repositories.Repositories.Base;
using StudyProject.Infra.Data.SqlSever.Context;

namespace StudyProject.Infra.Data.Repositories.Repositories.Entities
{
    internal class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        private readonly BaseContextStrategy Context = new BaseContextStrategy(new ContextSQL());

        public PessoaRepository(BaseContextStrategy context) : base(context)
        {
            Context = context;
        }

        public bool SalvarPessoa(Pessoa args) => Add(new Pessoa(){ DataNascimento = args.DataNascimento, Nome = args.Nome,SobreNome = args.SobreNome});
        public void ExcluirPessoa(Pessoa args) => Delete(new Pessoa() { Id = args.Id, DataNascimento = args.DataNascimento, Nome = args.Nome, SobreNome = args.SobreNome });
    }
}