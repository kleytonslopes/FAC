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
            ///Variaveis de Testes utilizando os metodos da Calculadora
            float testSoma = Calculadora.CalcularSoma(2, 10, 5, 2.5f);
            float testMedia = Calculadora.CalcularMedia(2, 10, 5, 2.5f);
            Boolean testEPrimo1 = Calculadora.ePrimo(2);
            Boolean testEPrimo2 = Calculadora.ePrimo(5);
            Boolean testEPrimo3 = Calculadora.ePrimo(12);
            String testBinario = Calculadora.getBinario(20);
            Boolean testePalidromo1 = Calculadora.ePalidromo(7117);
            Boolean testePalidromo2 = Calculadora.ePalidromo(7127);
            Boolean testePalidromo3 = Calculadora.ePalidromo(3333);
            Int32 testgetNumerodeDigitos1 = Calculadora.getNumerodeDigitos(3201);
            Int32 testgetNumerodeDigitos2 = Calculadora.getNumerodeDigitos(321);
            ///...
            
            ///Testes passando o Tipo, Nome, Valor do retorno e Valor Esperado
            Teste.EstaIgual<float>("CalcularSoma", testSoma, 19.5f);
            Teste.EstaIgual<float>("CalcularMedia", testMedia, 4.875f);

            Teste.EstaIgual<Boolean>("ePrimo", testEPrimo1, true);
            Teste.EstaIgual<Boolean>("ePrimo", testEPrimo2, false);
            Teste.EstaIgual<Boolean>("ePrimo", testEPrimo3, true);

            Teste.EstaIgual<String>("getBinario", testBinario, "10100");

            Teste.EstaIgual<Boolean>("ePalidromo", testePalidromo1, true);
            Teste.EstaIgual<Boolean>("ePalidromo", testePalidromo2, false);
            Teste.EstaIgual<Boolean>("ePalidromo", testePalidromo3, true);

            Teste.EstaIgual<Int32>("getNumerodeDigitos", testgetNumerodeDigitos1, 4);
            Teste.EstaIgual<Int32>("getNumerodeDigitos", testgetNumerodeDigitos2, 3);
            ///...
            
            ///Print de resultados dos Testes
            ConsoleConfig.PrintLine("".PadRight(Console.BufferWidth - 1, '-'), TesteStatus.Nenhum);
            ConsoleConfig.PrintLine("Sucessos".PadRight(10, ' ') + ": " + Teste.Sucessos, TesteStatus.Nenhum);
            ConsoleConfig.PrintLine("Falhas".PadRight(10, ' ') + ": " + Teste.Falhas, TesteStatus.Nenhum);

            ///Esperando ação do Usuário
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Classe de Testes
    /// </summary>
    public static class Teste
    {
        /// <summary>
        /// Quantidade de Sucessos
        /// </summary>
        public static Int32 Sucessos = 0;
        /// <summary>
        /// QUantidade de Falhas
        /// </summary>
        public static Int32 Falhas = 0;

        /// <summary>
        /// Validação que compara dois valores
        /// </summary>
        /// <typeparam name="T">Tipo da Entrada</typeparam>
        /// <param name="metodo">Nome do Metodo testado</param>
        /// <param name="entrada">Valor da Entrada</param>
        /// <param name="valor">Valor esperado</param>
        /// <returns>Passou / Não Passou</returns>
        public static Boolean EstaIgual<T>(String metodo, T entrada, T valor)
        {
            ///Verifica se o valor de entrada esta igual ao valor esperado
            if (entrada.Equals(valor))
            {
                ///Incrementa +1 nos Sucessos
                ++Sucessos;
                ///Imprime Sucesso no Console
                ConsoleConfig.PrintLine($"{metodo} : Sucesso", TesteStatus.Sucesso);
                return true;
            }
            else
            {
                ///Incrementa +1 nas Falhas
                ++Falhas;
                ///Imprime Falha no Console
                ConsoleConfig.PrintLine($"{metodo} : Falha", TesteStatus.Falha);
                return false;
            }
        }
    }

    /// <summary>
    /// Classe da Calculadora
    /// </summary>
    public static class Calculadora
    {
        /// <summary>
        /// Soma todos os valores informado nos parametros do Metodo
        /// </summary>
        /// <param name="valores">Lista de Valores separados por , (1, 2, 3...)</param>
        /// <returns>A Soma de todos os Valores</returns>
        public static float CalcularSoma(params float[] valores)
        {
            ///Verifica se há valores
            if (valores != null && valores.Any())
                ///Soma todos os valores informados no parametro
                return valores.Sum(x => x);
            return 0;
        }
        /// <summary>
        /// Media todos os valores informado nos parametros do Metodo
        /// </summary>
        /// <param name="valores">Lista de Valores separados por , (1, 2, 3...)</param>
        /// <returns>A Media de todos os Valores</returns>
        public static float CalcularMedia(params float[] valores)
        {
            ///Verifica se há valores
            if (valores != null && valores.Any())
                ///Soma todos os valores informados no parametro e divide pela quantidade informada
                return (valores.Sum(x => x) / valores.Length);
            return 0;
        }
        /// <summary>
        /// Valida se o numero informado é Primo
        /// </summary>
        /// <param name="valor">Valor</param>
        /// <returns>É Primo ou Não (true|false)</returns>
        public static Boolean ePrimo(Int32 valor)
        {
            ///Verifica se o valor é divisivel por 2 (se for é Par)
            if (valor % 2 == 0)
                return true;

            return false;
        }
        /// <summary>
        /// Retorna a Representação binaria do valor informado
        /// </summary>
        /// <param name="valor">Valor</param>
        /// <returns>Representação Binaria</returns>
        public static String getBinario(Int32 valor)
        {
            ///Converte o valor para Binario utilizando a base 2
            return Convert.ToString(valor, 2);
        }        /// <summary>
        /// Cerifica se a leitura do numero lido da Esqueda para a Direita é igual a leitura da Direita para a Esquerda
        /// </summary>
        /// <param name="valor">Valor</param>
        /// <returns>É ou Não Palidromo (true|false)</returns>        public static Boolean ePalidromo(Int32 valor)
        {
            ///Converte o valor para String e para uma Array de Char
            char[] charVal = valor.ToString().ToCharArray();
            ///Inverte a Array
            Array.Reverse(charVal);
            ///Transforma a Array invertida em uma String
            String strValor = new string(charVal);
            ///Compara a String da Array invertida com o valor de entrada
            if(strValor == valor.ToString())
                return true;

            return false;
        }        /// <summary>
        /// Recupera a quantidade de caracteres de um Valor
        /// </summary>
        /// <param name="valor">Valor</param>
        /// <returns>Quantidade de Caracteres</returns>        public static Int32 getNumerodeDigitos(Int32 valor)
        {
            ///Conta a quantidade de caracteres do valor
            return valor.ToString().Length;        }
    }

    /// <summary>
    /// Ajustes no Console
    /// </summary>
    public static class ConsoleConfig
    {
        /// <summary>
        /// Printa um determinado texto no Console
        /// </summary>
        /// <param name="obj">Mensagem</param>
        /// <param name="status">Tipo da Mensagem</param>
        public static void PrintLine(object obj, TesteStatus status)
        {
            
            switch (status)
            {
                ///Caso nenhum selecionado
                case TesteStatus.Nenhum:
                    ///altera a cor da fonte do console para Azul Claro
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                ///Caso sucesso selecionado
                case TesteStatus.Sucesso:
                    ///altera a cor da fonte do console para Verde
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                ///Caso falha selecionado
                case TesteStatus.Falha:
                    ///altera a cor da fonte do console para Vermelho
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                ///Caso nada selecionado
                default:
                    ///Reseta as cores do Console
                    Console.ResetColor();
                    break;
            }
            ///Escreve no Console a mensagem
            Console.WriteLine(obj.ToString());
            ///Reseta as cores do Console
            Console.ResetColor();
        }
    }

    /// <summary>
    /// Lista de status dos testes
    /// </summary>
    public enum TesteStatus
    {
        Nenhum,
        Sucesso,
        Falha
    }
}



