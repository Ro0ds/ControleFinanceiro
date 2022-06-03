using System;
using System.Data;
using System.IO;
using FirebirdSql.Data.FirebirdClient;
using System.Text;
using FinControle.DB;
using System.Windows.Forms;

namespace FinControle.Login {
    class Logar {
        public int IdUsuario { get; private set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string DicaSenha { get; set; }
        public int Idade { get; set; }
        public ConectaBanco conectaBanco { get; private set; } = new ConectaBanco();
        public DBClassePrincipal classePrincipal { get; set; } = new DBClassePrincipal();
        public Logar() { }

        public Logar(string nome, string senha, string dicaSenha, int idade) {
            Nome = nome;
            Senha = senha;
            DicaSenha = dicaSenha;
            Idade = idade;
        }

        public void ExisteConta(string nome, string senha) {
            try {
                classePrincipal.VerificaBanco();
                conectaBanco.AbreConexaoBanco();

                conectaBanco.QuerySQL = new FbCommand($"SELECT nome, senha from Usuarios where nome = {nome} and senha = {senha};", conectaBanco.connection);

                conectaBanco.QuerySQL.CommandType = CommandType.Text;
                int existeUsuario = conectaBanco.QuerySQL.ExecuteNonQuery();

                switch (existeUsuario) {
                    case (int)Usuario.existe:
                        if (int.Parse(DateTime.Now.ToString("HH")) >= 5 && int.Parse(DateTime.Now.ToString("HH")) < 12) {
                            MessageBox.Show($"Bom dia, {nome}");
                        }
                        else if (int.Parse(DateTime.Now.ToString("HH")) >= 12 && int.Parse(DateTime.Now.ToString("HH")) < 18) {
                            MessageBox.Show($"Boa tarde, {nome}");
                        }
                        else if (int.Parse(DateTime.Now.ToString("HH")) >= 18 && double.Parse(DateTime.Now.ToString("HH:mm")) < 23.59 || int.Parse(DateTime.Now.ToString("HH")) < 5) {
                            MessageBox.Show($"Boa noite, {nome}");
                        }
                        break;
                    case (int)Usuario.naoExiste:
                        MessageBox.Show($"Usuário: {nome} não encontrado na base de dados, crie um registro.");
                        break;
                }




            }
            catch (Exception a) {
                MessageBox.Show($"Erro: {a.Message}", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally {
                conectaBanco.connection.Close();
            }
        }
    }
}