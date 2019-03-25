using StudyProject.Core.Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Core.Business.Business.Interfaces
{
    public interface IPessoaBusiness
    {
        bool CadastrarPessoa(PessoaDto args);
    }
}
