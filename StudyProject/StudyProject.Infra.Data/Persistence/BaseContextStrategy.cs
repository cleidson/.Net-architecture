using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Infra.Data.Persistence
{
    internal class BaseContextStrategy : DbContext
    {
        private readonly DbContext Context;
        public BaseContextStrategy(DbContext context):base()
        {
            Context = context;
            ConfigurationEntity(context);
        }

        private void ConfigurationEntity(DbContext context)
        {
            context.Configuration.LazyLoadingEnabled = false;
            context.Configuration.ProxyCreationEnabled = false;
        }
    }
}
