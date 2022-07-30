using Microsoft.EntityFrameworkCore;

namespace Evaluación_4.Models
{
    public class EFContext : DbContext
    {
        //Creación de un atributo que almacene la conexión a la BD
        private const string ConnectionString =
            "server=localhost;port=3306;database=videojuego_db;user=root;password=;Connect Timeout=5;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString,
                new MySqlServerVersion(new Version(8, 0, 11)));
        }

        //Definición de las clases que estaran conectadas a la Base de Datos 
        public DbSet<CompaniaDeVideojuego> CompaniaDeVideojuegos { get; set; }
        public DbSet<Videojuego> Videojuegos { get; set; }

        //Configuración de los modelos
        //Claves primarias
        //Definición de los valores por defecto

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Claves primarias
            modelBuilder.Entity<Videojuego>().HasKey(i => i.Id);
            modelBuilder.Entity<CompaniaDeVideojuego>().HasKey(j => j.Id);

            //Relaciones de uno a muchos : Compañia a Videojuego
            modelBuilder.Entity<Videojuego>()
                .HasOne<CompaniaDeVideojuego>(s => s.CompaniaDeVideojuegos)
                .WithMany(g => g.Videojuegos)
                .HasForeignKey(c => c.Compania_id);

            //Definiciones de los obligatorios
            //Videojuego
            modelBuilder.Entity<Videojuego>().Property(s => s.Compania_id).IsRequired();
            modelBuilder.Entity<Videojuego>().Property(s => s.NombreVideojuego).IsRequired();
            modelBuilder.Entity<Videojuego>().Property(s => s.CopiasVendidas).IsRequired();

            //Compañia de Videojuegos
            modelBuilder.Entity<CompaniaDeVideojuego>().Property(s => s.NombreCompania).IsRequired();
            modelBuilder.Entity<CompaniaDeVideojuego>().Property(s => s.Fundado)
                .HasDefaultValue(DateTime.Now) // Indica un valor por defecto
                .IsRequired();
            modelBuilder.Entity<CompaniaDeVideojuego>().Property(s => s.AnioIndustria).IsRequired();
            

        }

    }
}
