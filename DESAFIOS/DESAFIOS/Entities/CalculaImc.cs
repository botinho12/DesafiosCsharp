namespace DESAFIOS.Entities
{
    public class CalculaImc
    {
        public double Altura { get; set; }
        public double Peso { get; set; }


        public CalculaImc(double altura, double peso)
        {
            Altura = altura;
            Peso = peso;    
        }


        public double calculaImc()
        {
            double imc = Peso / (Altura * Altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
                Console.WriteLine("Classificação: Abaixo do peso");
            else if (imc < 25)
                Console.WriteLine("Classificação: Peso normal");
            else if (imc < 30)
                Console.WriteLine("Classificação: Sobrepeso");
            else
                Console.WriteLine("Classificação: Obesidade");

            Console.ReadKey();
            return imc;
        }

    }
}
