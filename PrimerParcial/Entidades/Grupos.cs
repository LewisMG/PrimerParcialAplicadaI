using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PrimerParcial.Entidades
{
    public class Grupos
    {
        [Key]

        public int GrupoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int GruposDeseados { get; set; }
        public int Integrantes { get; set; }

        public Grupos()
        {
            GrupoId = 0;
            Fecha = DateTime.Now;
            Descripcion = String.Empty;
            Cantidad = 0;
            GruposDeseados = 0;
            Integrantes = 0;
        }
    }
}
