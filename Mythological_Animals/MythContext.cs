using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mythological_Animals
{
    class MythContext : DbContext
    {
        public DbSet<GodModel> listOfGods { get; set; }
        public DbSet<MythModel> listOfMyths { get; set; }
    }
}

