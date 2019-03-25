using StudyProject.Core.Business.Business.Interfaces;
using StudyProject.Core.Business.Dto;
using StudyProject.Infra.Data.Entities;
using StudyProject.Infra.Data.Repositories.Interfaces.Entities;

namespace StudyProject.Core.Business.Business
{
    internal class PessoaBusiness: IPessoaBusiness
    {
        protected IPessoaRepository _pessoaRepository;
        public PessoaBusiness(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        } 

        public bool CadastrarPessoa(PessoaDto args) => _pessoaRepository.SalvarPessoa( new Pessoa { });
    }
}
