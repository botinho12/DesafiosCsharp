namespace DESAFIOS.Entities
{
    public class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public Calculadora(double numero1, double numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public double Soma()
        {
            return Numero1 + Numero2;
        }

        public double Subtract()
        {
            return Numero1 - Numero2;
        }

        public double Divisao()
        {
            return Numero1 / Numero2;
        }

        public double multiplicacao()
        {
            return Numero1 * Numero2;
        }
    }
}
