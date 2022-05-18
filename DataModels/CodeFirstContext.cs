using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext(): base("ArtifactDatabase")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CodeFirstContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<CodeFirstContext>());
        }


        public virtual DbSet<User> Users { get; set; }

    }
}
