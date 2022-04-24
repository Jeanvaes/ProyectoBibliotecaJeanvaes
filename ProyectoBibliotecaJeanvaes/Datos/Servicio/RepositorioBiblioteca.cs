using Microsoft.EntityFrameworkCore;
using ProyectoBibliotecaJeanvaes.Datos.Modelo;

namespace ProyectoBibliotecaJeanvaes.Datos.Servicio
{
    public class RepositorioBiblioteca:DbContext
    {
        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca> options):base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; }
        //crear otras 3 propiedades restantes(autor, estudiantes, prestamo)
    }
}
