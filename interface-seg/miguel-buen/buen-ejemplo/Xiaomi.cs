namespace BuenEjemplo
{
    public class Xiaomi : TelefonoBasico, IDesbloqueoBiometrico
    {
        public Xiaomi(string marca, int modelo, int precio, int ram) : base(marca, modelo, precio, ram) { }


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


    }
}
