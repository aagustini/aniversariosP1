using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniversariosBLL
{
      public class AniversariosContext : DbContext
        {
            public AniversariosContext() : base("AnivConnectionString")
            {
            }
            public DbSet<Aniversario> Aniversarios{ get; set; }
    }
}
