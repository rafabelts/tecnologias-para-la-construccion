namespace BuenEjemplo
{
    public class Zte : TelefonoBasico
    {
        public Zte(string marca, int modelo, int precio, int ram) : base(marca, modelo, precio, ram) { }

        public override void escribir()
        {
            Console.WriteLine($"Escribiendo desde mi {marca}");
        }

        public override void llamar()
        {
            Console.WriteLine($"Llamando desde mi {marca}");

        }
    }
}
