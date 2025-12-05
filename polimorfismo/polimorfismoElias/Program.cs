using System;
using poliforfismoElias.Figuras;
using poliforfismoElias.Genericos;
using poliforfismoElias.Utilidades;
using poliforfismoElias.Unidades;

class Program
{
    public static void Main(string[] args)
    {
        List<Figura> figuras = new List<Figura>()
        {
            new Circulo(5),
            new Rectangulo(4, 6),
        };

        foreach (var figura in figuras)
        {
            f.dibujar();
            Console.WriteLine($"Área: {f.calcularArea()}");
        }

        Caja<int> caja1 = new Caja<string>();
        caja1.Guardar("Hola Mundo");
        Console.WriteLine($"Contenido de la caja1: {caja1.Abrir()}");

        Caja<int> caja2 = new Caja<int>();
        caja2.Guardar(123);
        Console.WriteLine($"Contenido de la caja2: {caja2.Abrir()}");

        Calculadora calc = new Calculadora();
        Console.WriteLine($"Suma: {calc.Sumar(5, 10)}");
        Console.WriteLine($"Suma de Decimales: {calc.Sumar(5.5, 10.3)}");

        Metro metro = 10;
        double d = (double)metro;
        Console.WriteLine($"Metros: {metro}, Decimales: {d}");
    }
}