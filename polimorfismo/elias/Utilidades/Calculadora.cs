namespace TiposdePolimorfismo.Utilidades
{
    public class Calculadora
    {
        public double sumar(double a, double b)
        {
            return a + b;
        }

        public static sumar operator +(numero1, numero2)
        {
            return numero1 + numero2;
        }
    }
}
