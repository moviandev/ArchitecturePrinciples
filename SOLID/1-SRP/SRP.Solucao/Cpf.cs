using System;

namespace SOLID.SRP.Solucao
{
    public class Cpf
    {
        public string Numero { get; set; }

        public bool Validar()
            => Numero.Length == 11;
    }
}