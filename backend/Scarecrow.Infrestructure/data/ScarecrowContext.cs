using Microsoft.EntityFrameworkCore;
using Scarecrow.Core;

namespace Scarecrow.Infrestructure {

        public class ScarecrowContext : DbContext {

        public ScarecrowContext(DbContextOptions<ScarecrowContext> options) 
        : base (options) {

        }
        public DbSet<Registro>Registro{ get;set;}
        
        public DbSet<Arduino>Datos{ get;set;}

    }
}