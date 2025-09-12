using System;

namespace SinLSP;

public class Pasante : Empleado
{
    public override decimal CalcularSalario()
    {
        throw new NotImplementedException("Los pasantes no tienen salario");
    }

    public override void Trabajar()
    {
        Console.WriteLine("Trabajando 4 horas diarias");
    }
}
