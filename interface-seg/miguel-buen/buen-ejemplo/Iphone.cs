namespace BuenEjemplo
{
    public class Iphone : TelefonoBasico, INfc, IAsistenteVirtual, IDesbloqueoBiometrico
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

        public void desbloquearConHuella()
        {
            Console.WriteLine($"Desbloqueando mi {marca} con huella");
        }

        public void usarAsistenteVirtual()
        {
            Console.WriteLine($"Usando el asistente virtual de mi {marca}");
        }

        public void pagarConNfc()
        {
            Console.WriteLine($"Pagando con NFC desde mi {marca}");
        }
    }
}
