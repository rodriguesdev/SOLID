using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SolidPattern
{
    public class ProdutoRepository
    {
        public void Add(Produto produto)
        {
            using (var conn = new SqlConnection())
            {
                var command = new SqlCommand
                {
                    CommandText = "INSERT INTO PRODUTO(Nome,Descricao) VALUES(@Nnome,@descricao)"
                };

                command.Parameters.AddWithValue("nome", produto.Nome);
                command.Parameters.AddWithValue("descricao", produto.Descricao);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}