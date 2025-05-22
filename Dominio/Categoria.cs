using System;

namespace Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Categoria () { }

        public Categoria (int idCategoria, string desc)
        {
            Id = idCategoria;
            Descripcion = desc;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}