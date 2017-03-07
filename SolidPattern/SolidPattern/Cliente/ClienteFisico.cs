using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPattern.Cliente
{
    public class ClienteFisico : Pessoa
    {
        public ClienteFisico(IEmailService emailService): base(emailService)
        {

        }
        public ICpf Cpf { get; set; }
        public override bool IsValid()
        {
            return base.IsValid() /*&& Cpf.IsValid()*/;
        }
    }
}