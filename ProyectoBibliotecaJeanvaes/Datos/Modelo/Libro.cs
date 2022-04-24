using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaJeanvaes.Datos.Modelo
{
    public class Libro
    {
        [Key]
        public int Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Categoria { get; set; }
        public string Autor { get; set; }
        public int NumeroPagina { get; set; }
    }
}
