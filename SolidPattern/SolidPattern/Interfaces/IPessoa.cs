using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPattern.Interfaces
{
    public interface IPessoa
    {
        string Nome { get; set; }
        IEnumerable<string> Telefones { get; set; }
        bool IsValid();
    }
}
