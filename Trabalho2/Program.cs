using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Trabalho Pratico - Teste Unitário
/// </summary>
namespace Trabalho2
{
    public class Program
    {
        static void Main(string[] args)
        {
            float resultado = Calculadora.CalcularSoma(2, 10, 5, 2.5f);
        }
    }

    public static class Calculadora
    {
        public static float CalcularSoma(params float[] valores)
        {
            return 0;
        }
    }

    public static class ConsoleConfig
    {

    }
}
