using WebComplejoDeportivo_MCV.Models;

namespace WebComplejoDeportivo_MCV.Data
{
    public static class DbSeeder
    {


        public static void Seed(ComplejoDbContext complejoDbContext)
        {

            // Verifica/crea la base de datos si fuera necesario
            complejoDbContext.Database.EnsureCreated();

            // Si ya existen tipos de cancha, no vuelve a cargarlos
            if (complejoDbContext.TiposCancha.Any())
            {
                return;
            }

            // Datos iniciales de tipos de cancha
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

            // Agrega todos los tipos al DbContext
            complejoDbContext.TiposCancha.AddRange(tiposCancha);

            // Guarda los datos en SQL Server
            complejoDbContext.SaveChanges();



        }
           



    }
}
