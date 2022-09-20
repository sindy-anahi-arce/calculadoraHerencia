using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraHerencia
{
    class Operacion
    {
        //Atributos
        double val1;
        double val2;
        double result;

        //Propiedades

        public double Val1 { get => val1; set => val1 = value; }
        public double Val2 { get => val2; set => val2 = value; }
        public double Result { get => result; set => result = value; }
    }
}
