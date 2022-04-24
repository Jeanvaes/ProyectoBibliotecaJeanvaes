using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaJeanvaes.Datos.Modelo
{
    public class Prestamo
    {
        [Key]
        public int Identificacion { get; set; }
        public string NumeroLibros { get; set; }
        public string Seccion { get; set; }
        public string Prestador { get; set; }
        public int TiempoPrestamo { get; set; }
    }
}
