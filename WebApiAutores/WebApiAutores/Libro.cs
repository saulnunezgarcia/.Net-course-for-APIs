using WebApiAutores.Entidades;
using WebApiAutores.Validaciones;

namespace WebApiAutores
{
    public class Libro
    {
        public int id { get; set; }
        [PrimeraLetraMayuscula]
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
