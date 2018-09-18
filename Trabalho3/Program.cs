using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema de Locadoção”");
            ConnectionFactory con = new ConnectionFactory();
            con.create();
        }
    }
}
