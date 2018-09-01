using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Trabalho Pratico:
///     Requisição
/// </summary>
namespace Trabalho1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Criando um client em um escopo using para descarta-lo quando o processo for concluido
            using (HttpClient httpClient = new HttpClient())
            {
                ///Especificar o endereço base
                httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
                ///Especificar o tipo da mídia, se é json, xml ....
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                ///Adicionar os parametros userid e id
                httpClient.DefaultRequestHeaders.Add("userid", "1");
                httpClient.DefaultRequestHeaders.Add("id", "2");
                ///...

                ///Efetuar a requisição no servidor no método "todos"
                HttpResponseMessage resposta = httpClient.GetAsync("todos").Result;

                ///Verificar se o resultado foi bem sucedido
                if (resposta.IsSuccessStatusCode)
                {
                    ///Escrever no console a resposta (json) do servidor
                    Console.Write(resposta.Content.ReadAsStringAsync().Result);
                    ///Escrever no arquivo "resultado.json" a resposta (json) do servidor
                    File.WriteAllText("resultado.json", resposta.Content.ReadAsStringAsync().Result, Encoding.UTF8);
                }
                else
                    ///Escreve a mensagem do servidor no console caso a resposta não tenha sido bem sucedida
                    Console.WriteLine($"Erro: {resposta.Content.ReadAsStringAsync().Result}");

                ///Aguarda o usuário pressionar alguma tecla para que o console não feche automaticamente
                Console.ReadKey();
            }
        }
    }
}
