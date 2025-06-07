using System.Globalization;
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


        try
        {
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
                string alturaStr = Console.ReadLine().Replace(',', '.');
                double altura = double.Parse(alturaStr, CultureInfo.InvariantCulture);

                Console.WriteLine("");
                Console.WriteLine("Informe seu peso");
                string pesoStr = Console.ReadLine().Replace(',', '.');
                double peso = double.Parse(pesoStr, CultureInfo.InvariantCulture);
                Console.WriteLine("");


                var desafio2 = new CalculaImc(altura, peso);
                desafio2.calculaImc();
            }
            else if (NumeroDigitado == 3)
            {
                Console.WriteLine("Digite qual operação deseja executar: Subtração (-), Adição (+), Divisão (/) ou Multiplicação (*)");
                string operador = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite dois números:");
                Console.Write("Primeiro número: ");
                string numero1Str = Console.ReadLine().Replace(',', '.');
                double numero1 = double.Parse(numero1Str, CultureInfo.InvariantCulture);

                Console.Write("Segundo número: ");
                string numero2Str = Console.ReadLine().Replace(',', '.');
                double numero2 = double.Parse(numero2Str, CultureInfo.InvariantCulture);

                var desafio3 = new Calculadora(numero1, numero2);
                double resultado;

                switch (operador)
                {
                    case "+":
                        resultado = desafio3.Soma();
                        Console.WriteLine($"Resultado da soma: {resultado}");
                        break;

                    case "-":
                        resultado = desafio3.Subtract();
                        Console.WriteLine($"Resultado da subtração: {resultado}");
                        break;

                    case "*":
                        resultado = desafio3.multiplicacao();
                        Console.WriteLine($"Resultado da multiplicação: {resultado}");
                        break;

                    case "/":
                        if (numero2 == 0)
                            Console.WriteLine("Erro: divisão por zero.");
                        else
                        {
                            resultado = desafio3.Divisao();
                            Console.WriteLine($"Resultado da divisão: {resultado}");
                        }
                        break;

                    default:
                        Console.WriteLine("Operador inválido.");
                        break;
                }
            }
        }
        catch
        {
            Console.WriteLine("Valor invalido");
        }
    }
}