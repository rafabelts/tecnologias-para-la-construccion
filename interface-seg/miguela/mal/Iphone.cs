namespace malEjemplo
{

    public class Iphone : Telefono
    {

        public Iphone(string marca, int modelo, int precio, int ram) : base(marca, modelo, precio, ram) { }

        public override void escribir()
        {
            Console.WriteLine($"Escribiendo desde mi {marca}");
        }

        public override void llamar()
        {
            Console.WriteLine($"Llamando desde mi {marca}");
        }

        public override void pagarConNfc()
        {
            Console.WriteLine($"Pagando desde  mi {marca}");
        }

        public override void usarAsistenteVirtual()
        {
            Console.WriteLine($"Usando asistente virtual de mi {marca}");
        }

        public override void desbloquearConHuella()
        {
            Console.WriteLine($"Desbloqueando mi ${marca} con huella");
        }

    }

}
