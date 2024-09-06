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
        public DateTime Data_nasc { get; set; }
        public DateTime Data_cad { get; set; }

        public Cliente(string? nome, string? email, string? telefone, string? cpf, DateTime data_nasc, DateTime data_cad)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
        }
        public Cliente(string? nome, string? email, string? cpf,string? telefone, DateTime data_nasc, DateTime data_cad, bool ativo)   
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }
        public Cliente(int id,string? nome, string? email, string? cpf, bool ativo, string? telefone, DateTime data_nasc,DateTime data_cad)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Data_cad = data_cad;
            Data_nasc = data_nasc;
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
            cmd.Parameters.AddWithValue("spdatanasc", Data_nasc);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }
        /*public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from cliente where id ={id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetBoolean(4),

                    )
             
            }

          */  
        }
        
    }
}
