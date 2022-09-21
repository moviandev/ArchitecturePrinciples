using System;

namespace SOLID.SRP.Solucao
{
    public class Email
    {
        public string Endereco { get; set; }

        public bool Validar()
            => Endereco.Contains("@");
    }
}