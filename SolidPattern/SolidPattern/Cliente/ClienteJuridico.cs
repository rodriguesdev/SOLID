using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPattern.Cliente
{
    public class ClienteJuridico : Pessoa
    {
        public ClienteJuridico(IEmailService emailService): base(emailService)
        {

        }
        public ICnpj Cnpj { get; set; }

        public override bool IsValid()
        {
            return base.IsValid() /*&& Cnpj.IsValid()*/;
        }
    }
}