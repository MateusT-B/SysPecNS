﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace SysPecNSLib
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime Data_nasc { get; set; }
        public DateTime Data_cad { get; set; }
         public bool Ativo { get; set; }


        public Cliente()
        {
          
        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime data_cad, DateTime data_nasc)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_cad = data_cad;
            Data_nasc = data_nasc;
        
        }
        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime data_cad, DateTime data_nasc, bool ativo)   
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_cad = data_cad;
            Data_nasc = data_nasc;
            Ativo = ativo;
        }
        public Cliente(int id,string? nome, string? cpf,string? telefone, string? email, DateTime data_cad, DateTime data_nasc,bool ativo)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_cad = data_cad;
            Data_nasc = data_nasc;
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
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where id ={id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7)
                    );
             
            }
            return cliente;
          
        }
        public static List<Cliente> ObterLista(string? nome = "")
        {
            List<Cliente> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            if (nome == "")
            {
                cmd.CommandText = "select * from clientes order by nome";
            }
            else
            {
                cmd.CommandText = $"select * from clientes where nome " +
                    $"like '%{nome}%' order by nome";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7)
                    )
                    );
            }

            return lista;
        }
        public void Atualizar() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", Data_nasc);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        } 

        
        
    }
}
