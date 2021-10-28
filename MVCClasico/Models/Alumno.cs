using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCClasico.Models
{
    public class Alumno
    {

        public int id { get; set; }

        public string alias { get; set; }

        public string nombreCompleto { get; set; }

        public string dni { get; set; }

        public string mail { get; set; }

        public int edad { get; set; }

        [Display(Name = "Fecha inscripción")]
        public DateTime FechaInscripto { get; set; }
        [EnumDataType(typeof(Deporte))] //despues ponemos nuestras categorias
        public Deporte DeporteFavorito { get; set; }
    }
}
