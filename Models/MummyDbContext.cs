using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex_group1_8.Models
{
    public class MummyDbContext : DbContext
    {
        public MummyDbContext (DbContextOptions<MummyDbContext> options) : base (options) { }
    }
}
