
using Microsoft.AspNetCore.Mvc;

namespace ProyectoBibliotecaJeanvaes.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaController : ControllerBase
    {   //propiedad publica
        public string PropiedadBiblioteca { get; set; }

        public BibliotecaController() {
            //constructor
        }

        [HttpGet]
        public String ObtenerLibro() {
            //funcion 
            return "Se obtuvo el libro";

        }

        [HttpPost]
        public String AgregarLibro()
        {
            return "Hola mundo";
        }

        [HttpPut]
        public String ActualizarLibro()
        {
            return "actualizando...";
        }

        [HttpDelete]
        public String BorrarLibro()
        {
            return "Se borrara";
        }

        //-----------------------Autor--------------------


        [HttpGet]
        public String ObtenerAutor()
        {
            //funcion 
            return "Se vera el autor";

        }

        [HttpPost]
        public String AgregarAutor()
        {
            return "Leonardo";
        }

        [HttpPut]
        public String ActualizarAutor()
        {
            return "actualizando...Autor";
        }

        [HttpDelete]
        public String BorrarAutor()
        {
            return "Se borrara autor";
        }

        //-------------Estudiantes---------------


        [HttpGet]
        public String ObtenerEstudiante()
        {
            //funcion 
            return "Obtener estudiante";

        }

        [HttpPost]
        public String AgregarEstudiante()
        {
            return "Jeanvaes";
        }

        [HttpPut]
        public String ActualizarEstudiante()
        {
            return "actualizando...Estudiante";
        }

        [HttpDelete]
        public String BorrarEstudiante()
        {
            return "Se borrara estudiante";
        }

        //-------------prestamos------------


        [HttpGet]
        public String ObtenerPrestamo()
        {
            //funcion 
            return "Obtener prestamo";

        }

        [HttpPost]
        public String AgregarPrestamo()
        {
            return "Agregar prestamo";
        }

        [HttpPut]
        public String ActualizarPrestamo()
        {
            return "actualizando...Prestamo";
        }

        [HttpDelete]
        public String BorrarPrestamo ()
        {
            return "Se borrara Prestamo";
        }
    }
}
