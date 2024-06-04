using EvidencijaRacunarskeOpreme.Tehnoloska.Podaci;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaRacunarskeOpreme.Tehnoloska.RadSaPodacima
{
    public class DbContextBaza:DbContext
    {
        public DbContextBaza(DbContextOptions<DbContextBaza> opcije):base(opcije)
        {
            
        }
        public DbSet<RacunarskaOprema> racunarskaOprema { get; set; }
        
    }
}
