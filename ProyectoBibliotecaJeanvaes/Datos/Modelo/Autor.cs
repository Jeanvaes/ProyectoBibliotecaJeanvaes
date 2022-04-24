using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaJeanvaes.Datos.Modelo
{
    public class Autor
    {
        [Key]
        public string Pais { get; set; }
        public string Nombres { get; set; }
        public string Genero { get; set; }
        public string Edad { get; set; }
        public int NumeroLibros { get; set; }
    }
}
