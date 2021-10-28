using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalNT
{
    public class Curso
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public Categoria categoria { get; set; }
        
        
        //puede haber una lista de alumnos
        
        
        
        
        
        
        
        
        
        
        
        
        public Curso(int id, String nombre, Categoria categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.categoria = categoria;
        }
    }
}
