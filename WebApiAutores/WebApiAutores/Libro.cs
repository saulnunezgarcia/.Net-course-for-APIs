using WebApiAutores.Entidades;

namespace WebApiAutores
{
    public class Libro
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
