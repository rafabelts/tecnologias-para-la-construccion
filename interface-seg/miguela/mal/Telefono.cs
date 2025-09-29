namespace malEjemplo
{
    public abstract class Telefono
    {
        public string marca;
        public int modelo;
        public int precio;
        public int ram;

        public Telefono(string marca, int modelo, int precio, int ram)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.ram = ram;
        }

        public abstract void escribir();
        public abstract void llamar();
        public abstract void pagarConNfc();
        public abstract void usarAsistenteVirtual();
        public abstract void desbloquearConHuella();
    }
}
