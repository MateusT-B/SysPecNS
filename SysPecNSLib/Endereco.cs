using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Endereco
    {

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? TipoEndereco { get; set; }


        public Endereco()
        {
            Cliente = new();
        }

        public Endereco(Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {
            Cliente = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }

        public Endereco(int id, Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {
            Id = id;
            Cliente = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }
        public Endereco(string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
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
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }


        }

        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new Endereco();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from enderecos where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                endereco = new(
                    dr.GetInt32(0),
                    Cliente.ObterPorId(dr.GetInt32(1)),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9)
                    );
                    
            }
            return endereco;

        }
        public static List<Endereco> ObterLista(string? endereco = "")
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            if (endereco == "")
            {
                cmd.CommandText = $"select * from enderecos order by nome";
            }
            else
            {
                cmd.CommandText = $"select * from enderecos where nome LIKE '%{endereco}%' order by nome";

            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(
                    new(
                        dr.GetInt32(0),
                        Cliente.ObterPorId(dr.GetInt32(1)),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetString(9)
                        )
                    );
            }
            return enderecos;
        }

        public static List<Endereco> ObterListaPorCliente(int clienteId)
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from enderecos where cliente_id = {clienteId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(
                    new(
                        dr.GetInt32(0),
                        Cliente.ObterPorId(dr.GetInt32(1)),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetString(9)
                        )
                    );
            }
            return enderecos;
        }

        public void Atualizar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";

            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco);


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


    }
}