using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPattern
{
    public class ProdutoService
    {
        private ProdutoRepository _produtoRepository;

        public ProdutoService()
        {
            _produtoRepository = new ProdutoRepository();
        }

        public string Add(Produto produto)
        {
            try
            {
                if (!produto.IsValid) return "Produto Inválido!";
                _produtoRepository.Add(produto);
            }
            catch (Exception ex)
            {
                //FileLogger.Handle(ex.Message);
                return ex.Message;
            }

            return "Produto cadastrado com Sucesso!";
        }
    }
}