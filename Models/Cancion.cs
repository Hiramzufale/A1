namespace webApplication1.Models
{
    public class Cancion
    {
        public int Id { get; set; }     // Clave primaria
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public int DuracionSegundos { get; set; }
    }
}
