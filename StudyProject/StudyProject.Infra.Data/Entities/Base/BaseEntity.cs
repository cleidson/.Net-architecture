using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Infra.Data.Entities.Base
{
    internal class BaseEntity<TKey> where TKey : struct
    {
        public TKey Id { get; set; }
    }
}
