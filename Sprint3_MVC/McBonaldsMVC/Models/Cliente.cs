using System;

namespace McBonaldsMVC.Models
{
    public class Cliente
    {
            public string Nome {get;set;}
            public string Endereco {get;set;}
            public string Telefone {get;set;}
            public string Senha {get;set;}
            public string Email {get;set;}
            public DateTime DataNascimento {get;set;}
            
            public Cliente ()
            {
                
            }
            public Cliente (string nome, string email, string endereco, string telefone, DateTime dataNascimento,  string senha){

                this.Nome = nome;
                this.Endereco = endereco;
                this.Telefone = telefone;
                this.Senha = senha;
                this.Email = email;
                this.DataNascimento = dataNascimento;

            }



    }
}