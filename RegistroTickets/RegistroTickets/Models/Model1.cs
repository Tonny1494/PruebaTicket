using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RegistroTickets
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Tickets")
        {
        }

        public virtual DbSet<Historial_Atencion> Historial_Atencion { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Historial_Atencion>()
                .Property(e => e.coment_realizado)
                .IsFixedLength();

            modelBuilder.Entity<Ticket>()
                .Property(e => e.asunto)
                .IsFixedLength();

            modelBuilder.Entity<Ticket>()
                .Property(e => e.descrip_incidencia)
                .IsFixedLength();
        }
    }
}
