using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaJeanvaes.Datos.Modelo
{
    public class Estudiante
    {
        [Key]
        public int Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Programa { get; set; }
        public int Edad { get; set; }
        public int TiempoPrestamo { get; set; }
    }
}
