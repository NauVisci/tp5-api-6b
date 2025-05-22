using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public decimal Precio { get; set; }

        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

        // public List<Imagen> Imagenes { get; set; }
        
        // No creo que haga falta tener la lista de imagenes en la clase del Articulo,
        // Ya que las imagenes estan guardadas en su propia tabla y su estructura es algo como:
        // Imagen = {IdArticulo, UrlImagen}
        // Por ende podemos tener cuantas imagenes quisieramos, solo deben tener el IdArticulo
        // Entonces el mismo Articulo queda despegado de siempre tener que tener la lista de imagenes...

        public Articulo()
        {
            // Imagenes = new List<Imagen>();
        }
    }
}