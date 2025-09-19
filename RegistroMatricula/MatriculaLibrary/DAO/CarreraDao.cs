using MatriculaLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaLibrary.DAO
{
    internal class CarreraDao
    {
        public Carrera[] listado= new Carrera[5];
        public int posicion=0;
        public void Agregar(Carrera carrera) 
        {
            listado[posicion] = carrera;
            posicion++;
        }
            
    }
}
