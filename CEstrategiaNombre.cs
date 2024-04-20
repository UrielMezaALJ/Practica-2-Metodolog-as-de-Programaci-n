using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    class CEstrategiaNombre : IEstrategiaDeComparacion
    {
        public bool sosIgual(Alumno a1, Alumno a2)
        {
            return a1.getNombre() == a2.getNombre();
        }
        public bool sosMayor(Alumno a1, Alumno a2)
        {
            return a1.getNombre().Length > a2.getNombre().Length;
        }
        public bool sosMenor(Alumno a1, Alumno a2)
        {
            return a1.getNombre().Length < a2.getNombre().Length;
        }
    }
}
