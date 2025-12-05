namespace poliforfismoElias.Unidades
{
    public class Metro
    {
        private double Valor
        {
            set; get;
        }
        public Metro(double valor)
        {
            this.Valor = valor;
        }

        public static implicit operator double(Metro m)
        {
            return m.Valor;
        }

        public static explicit operator Metro(double d)
        {
            return new Metro(d);
        }
    }
}