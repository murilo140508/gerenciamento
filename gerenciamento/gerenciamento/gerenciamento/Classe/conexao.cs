using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamento.Classe
{
    public class conexao
    {
        static private string servidor = "localhost";
        static private string banco = "gerenciamento";
        static private string funcionario = "root";
        static private string senha = "";
        public MySqlConnection conexaoProjeto = null;
        static private string conexaobd = "server=" + servidor +
        ";database="
        + banco + ";user id=" + funcionario + ";password=" + senha;
        /// <summary>
        /// Metodo de conexao comm o banco de dados
        /// </summary>
        /// <returns>conexao do sistema</returns>
        public MySqlConnection getConexao()
        {
            conexaoProjeto = new MySqlConnection(conexaobd);
            return conexaoProjeto;
        }
        public DataTable obterdados(string sql)
        {
            DataTable dt = new DataTable();
            conexaoProjeto.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conexaoProjeto);
            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(dt);
            conexaoProjeto.Close();
            return dt;
        }
        public int cadastrar(string[] campos, object[] valores, string
        sql)
        {
            int registro;
            try
            {
                conexaoProjeto.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conexaoProjeto);
                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                registro = cmd.ExecuteNonQuery();
                conexaoProjeto.Close();
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}