namespace poliforfismoElias
{
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public static sumar operator +(Calculadora c1, Calculadora c2){
            return new Calculadora();
        }
    }
}