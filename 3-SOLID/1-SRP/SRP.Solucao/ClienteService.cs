namespace SOLID.SRP.Solucao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            var repo = new ClientRepository();
            repo.AdicionarCliente(cliente);

            EmailServices.Enviar("email@email.com", cliente.Email.Endereco, "Bem vindo", "Parabéns! Você foi cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
