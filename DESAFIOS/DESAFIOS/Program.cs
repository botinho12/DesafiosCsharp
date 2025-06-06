using DESAFIOS.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Seja Bem vindo a Área de desafios");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Digite 1 para desafio 1 - Somar Numero de 1 a 10");
        Console.WriteLine("Digite 2 para desafio 2 - Calcular o IMC");
        Console.WriteLine("Digite 3 para desafio 3 - Calculadora");
        Console.WriteLine("");
        Console.WriteLine("");

        int NumeroDigitado = int.Parse(Console.ReadLine());

        if (NumeroDigitado == 1)
        {
            var desafio = new SomaNumeros();
            desafio.somaNumeros();
        }
        else if (NumeroDigitado == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("Informe sua Altura");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Informe seu peso");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("");


            var desafio2 = new CalculaImc(altura,peso);
            desafio2.calculaImg();
        }


    }
}   