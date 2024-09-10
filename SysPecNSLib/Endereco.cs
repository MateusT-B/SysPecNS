using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Endereco
    {
       

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string? Cep { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Logradouro { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? TipoEndereco { get; set; }

        public Endereco()
        {
          
        }

        public Endereco(int clienteId, string? cep, string? numero, string? complemento, string? logradouro, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {
            ClienteId = clienteId;
            Cep = cep;
            Numero = numero;
            Complemento = complemento;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }

        public Endereco(int id, int clienteId, string? cep, string? numero, string? logradouro, string? bairro, string? cidade, string? uf)
        {
            Id = id;
            ClienteId = clienteId;
            Cep = cep;
            Numero = numero;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public Endereco(int id, int clienteId, string? cep, string? numero, string? complemento, string? logradouro, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {
            Id = id;
            ClienteId = clienteId;
            Cep = cep;
            Numero = numero;
            Complemento = complemento;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id",ClienteId);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade  );
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.ExecuteNonQuery();
        }
    }
}
