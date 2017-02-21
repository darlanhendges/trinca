using System.Data.Entity;

namespace DAB.DTO
{
    public class Model : System.Data.Entity.DbContext
    {
        public Model()
            : base("name=Modelo")
        {
        }

        public virtual DbSet<Churrasco> Churrasco { get; set; }
        public virtual DbSet<ChurrascoParticipante> ChurrascoParticipante { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
