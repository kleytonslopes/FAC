using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Trabalho3
{
    public class ConnectionFactory
    {
        private readonly String host = "localhost";
        private readonly String db = "locadora";
        private readonly String user = "root";
        private readonly String password = "root";

        private MySqlConnection con;

        public Boolean create()
        {
            try
            {
                con = new MySqlConnection("Server="+ host + ";Database="+ db + ";Uid="+ user + ";Pwd="+ password + ";SslMode=None;");
                if (con != null)
                {
                    con.Open();
                    Console.WriteLine("Conectado.");
                    return true;
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erro ao conectar a base de dados");
                throw new InvalidOperationException(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Classe não encontrada, adicione o driver nas bibliotecas.");
                throw new InvalidOperationException(e.Message);
            }
            return false;
        }
    }
}
