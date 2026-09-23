using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebComplejoDeportivo_MCV.Models;
namespace WebComplejoDeportivo_MCV.Data
{
    public class ComplejoDbContext : IdentityDbContext<Usuario>
    {
        public ComplejoDbContext(DbContextOptions<ComplejoDbContext> options)
            : base(options)
        {







        }

        public DbSet<Cancha> Canchas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Complejo> Complejos { get; set; }

        public DbSet<HorarioDisponible> HorariosDisponibles { get; set; }

        public DbSet<Pago> Pagos { get; set; }
        public DbSet<PagoEfectivo> PagosEfectivo { get; set; }
        public DbSet<PagoMercadoPago> PagosMercadoPago { get; set; }
        public DbSet<PagoTransferencia> PagosTransferencia { get; set; }

        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Reservante> Reservantes { get; set; }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Suscripcion> Suscripciones { get; set; }
        public DbSet<TipoCancha> TiposCancha { get; set; }
        public DbSet<TipoSocio> TiposSocio { get; set; }
    }
}
