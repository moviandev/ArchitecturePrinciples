using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.SRP.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }


        public string AddCliente()
        {
            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido";

            if (CPF.Length != 11)
                return "Cliente com CPF inválido";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MyconnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @datacadastro)";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("datacadastro", DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            };

            var mail = new MailMessage("email@email.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com",
            };

            mail.Subject = "Bem-Vindo";
            mail.Body = "Parabéns! Você foi cadastrado";

            client.Send(mail);

            return "Cliente cadastrado com sucesso!";
        }

    }
}

