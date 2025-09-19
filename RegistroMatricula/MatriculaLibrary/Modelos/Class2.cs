using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaLibrary.Modelos
{
    public class Estudiante
    {
        public String CIF {  get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public Carrera Carrera { get; set; }
        public DateTime FechaNac {  get; set; }
    }
}
