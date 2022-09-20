using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraHerencia
{
    class Multiplicacion : Operacion //Herencia de la clase Operación
    {
        //Método
        public double operar(double va1, double va2)
        {
            //Se puede acceder a los atributos directamente por la relación de herencia
            Val1 = va1; 
            Val2 = va2;

            //Se hace el calculo
            Result = Val1 * Val2;

            //Devuelve el valor
            return Result; 

        }
    }
}
