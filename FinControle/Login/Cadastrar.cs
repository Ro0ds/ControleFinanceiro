using System;
using System.Linq;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace FinControle.Login {
    class Cadastrar {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Senha { get; private set; }
        public string DicaSenha { get; private set; }

        public Cadastrar(){}

        public Cadastrar(string nome, int idade, string senha, string dicaSenha) {
            Nome = nome;
            Idade = idade;
            Senha = senha;
            DicaSenha = dicaSenha;
        }

        public void CadastrarUsuarioNovo(string nome, string senha, string dicaSenha, int idade) {

        }
    }
}
