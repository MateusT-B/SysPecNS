using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
        public bool Ativo { get; set; }
        public string? Telefone { get; set; }
        public int DataNas { get; set; }

        public Cliente(string? nome, string? email, string? telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
        public Cliente(string? nome, string? email, string? cpf, int Datanas)   
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
        }
        public Cliente(int id,string? nome, string? email, string? cpf, bool ativo, string? telefone, int datnasc)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            DataNas = datnasc;
            CPF = cpf;
            Ativo = ativo;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", DataNas);
            var cr = cmd.ExecuteReader();
            while (cr.Read())
            {
                Id = cr.GetInt32(0);
            }
        }
        public static Cliente ObterPorId(int id)
        {

        }
    }
}
