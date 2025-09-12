using System;
using ConLSP.Interfaces;

namespace ConLSP.Comportamientos
{
    public class SinSalario : IRenumerado
    {

        public float calcularSueldo()
        {
            return 100;
        }

    }
}
