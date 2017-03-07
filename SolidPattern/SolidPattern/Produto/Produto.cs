using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPattern
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool IsValid => !(string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(Descricao));
    }
}