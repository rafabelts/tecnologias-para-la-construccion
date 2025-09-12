using System;
using ConLSP.Interfaces;

namespace ConLSP.Comportamientos
{
    public class TrabajoPasante : ITrabajador
    {
        public void trabajar()
        {
            Console.WriteLine("Aprendiendo y apoyando en tareas");
        }
    }
}
