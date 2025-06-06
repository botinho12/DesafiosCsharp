using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIOS.Entities
{
    public class SomaNumeros
    {
        public int somaNumeros() 
        {
            var soma = 0;
            for (int i = 1; i <= 10; i++)
            {
                var antigoValorSoma = soma;
                soma += i;
                Console.WriteLine("a soma de " + antigoValorSoma + " + " + i + " é igual a " + soma);


            }
             Console.ReadKey();
            return soma;
        }
    }
}
