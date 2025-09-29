namespace malEjemplo
{

    public class Xiaomi : Telefono
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

        public override void pagarConNfc()
        {
            Console.WriteLine("Este dispositivo no tiene acceso a esta funcion");
        }

        public override void usarAsistenteVirtual()
        {
            Console.WriteLine("Este dispositivo no tiene acceso a esta funcion");
        }

        public override void desbloquearConHuella()
        {
            Console.WriteLine($"Desbloqueando mi ${marca} con huella");
        }



    }

}
