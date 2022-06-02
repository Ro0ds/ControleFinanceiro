using System;
using System.Data;
using System.IO;
using FirebirdSql.Data.FirebirdClient;
using System.Text;

namespace FinControle.Login {
    class Logar {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string DicaSenha { get; set; }
        public int Idade { get; set; }

        public Logar(){}

        public Logar(string nome, string senha, string dicaSenha, int idade) {
            Nome = nome;
            Senha = senha;
            DicaSenha = dicaSenha;
            Idade = idade;
        }


    }
}