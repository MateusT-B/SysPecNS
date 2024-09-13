using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {


        public int ProdutoID { get; set; }
        public double Quantidade { get; set; }
        public DateTime DataUltimoMovimento { get; set; }

        public Estoque()
        {
         
        }
        public Estoque(double quantidade, DateTime dataUltimoMovimento)
        {
            Quantidade = quantidade;
            DataUltimoMovimento = dataUltimoMovimento;
        }
        public Estoque(int produtoID, double quantidade, DateTime dataUltimoMovimento)
        {
            ProdutoID = produtoID;
            Quantidade = quantidade;
            DataUltimoMovimento = dataUltimoMovimento;
        }



        public static Estoque ObterPorId(int id)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from estoques where produto_id ={id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque = new(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDateTime(2)
                    );
            }
            return estoque;
        } 
        public static List<Estoque> ObterLista()
        {
            List<Estoque> estoques = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from estoques order by produto_id";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoques.Add(new(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDateTime(2)
                    )
                    );
            }
            return estoques;
        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update estoques " +
                $"set quantidade = '{Quantidade}', data_ultimo_movimento '{DataUltimoMovimento}' where produto_id = {ProdutoID}";
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
    }
}
