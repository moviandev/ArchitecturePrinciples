using System.Data;
using System.Data.SqlClient;
using SOLID.SRP.Solucao;

namespace SOLID.SRP.Solucao
{
    public class ClientRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MyconnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @datacadastro)";

                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                cmd.Parameters.AddWithValue("cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("datacadastro", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            };
        }
    }
}

