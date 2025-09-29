namespace BuenEjemplo
{

    public abstract class TelefonoBasico
    {

        public string marca;
        public int modelo;
        public int precio;
        public int ram;


        public TelefonoBasico(string marca, int modelo, int precio, int ram)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.ram = ram;
        }

        public abstract void escribir();
        public abstract void llamar();

    }

}
