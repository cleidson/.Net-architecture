using StudyProject.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Infra.Data.SqlSever.Mappings
{
    internal class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            this.ToTable("PESSOA");
            this.HasKey(t => t.Id);

            this.Property(t => t.Nome).HasColumnName("NOME").HasColumnType("varchar").HasMaxLength(255);
            this.Property(t => t.SobreNome).HasColumnName("SOBRENOME").HasColumnType("varchar").HasMaxLength(255);
            this.Property(t => t.DataNascimento).HasColumnName("DT_NASCIMENTO").HasColumnType("datetime");
        }
    }
}
