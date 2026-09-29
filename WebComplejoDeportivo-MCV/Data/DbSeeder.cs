using Microsoft.EntityFrameworkCore;
using WebComplejoDeportivo_MCV.Models;

namespace WebComplejoDeportivo_MCV.Data
{
    public static class DbSeeder
    {


        public static void Seed(ComplejoDbContext complejoDbContext)
        {
            complejoDbContext.Database.EnsureCreated();

            // ==========================
            // TIPOS DE CANCHA
            // ==========================

            if (!complejoDbContext.TiposCancha.Any())
            {
                var tiposCancha = new List<TipoCancha>
        {
            new TipoCancha
            {
                Nombre = "Fútbol 5",
                Descripcion = "Cancha para partidos de fútbol 5",
                CantidadJugadores = 10,
                DuracionTurnoMinutos = 60
            },

            new TipoCancha
            {
                Nombre = "Fútbol 7",
                Descripcion = "Cancha para partidos de fútbol 7",
                CantidadJugadores = 14,
                DuracionTurnoMinutos = 60
            },

            new TipoCancha
            {
                Nombre = "Fútbol 11",
                Descripcion = "Cancha para partidos de fútbol 11",
                CantidadJugadores = 22,
                DuracionTurnoMinutos = 90
            }
        };

                complejoDbContext.TiposCancha.AddRange(tiposCancha);
            }


            // ==========================
            // ROLES
            // ==========================

            if (!complejoDbContext.Roles.Any())
            {
                var roles = new List<Rol>
        {
            new Rol
            {
                Nombre = "Admin",
                Descripcion = "Administrador del complejo",
                Activo = true
            },

            new Rol
            {
                Nombre = "Empleado",
                Descripcion = "Empleado del complejo",
                Activo = true
            },

            new Rol
            {
                Nombre = "Cliente",
                Descripcion = "Cliente que realiza reservas",
                Activo = true
            }
        };

                complejoDbContext.Roles.AddRange(roles);
            }


            // GUARDA TODO JUNTO
            complejoDbContext.SaveChanges();
        }
    }
}
