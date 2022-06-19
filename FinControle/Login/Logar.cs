using System;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using FinControle.DB;
using System.Windows.Forms;

namespace FinControle.Login {
    class Logar {
        public int IdUsuario { get; private set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string DicaSenha { get; set; }
        public int Idade { get; set; }
        public bool UsuarioEncontrado { get; set; } = false;
        public ConectaBanco conectaBanco { get; private set; } = new ConectaBanco();
        public DBClassePrincipal classePrincipal { get; set; } = new DBClassePrincipal();
        public Logar() { }

        public Logar(string nome, string senha, string dicaSenha, int idade) {
            Nome = nome;
            Senha = senha;
            DicaSenha = dicaSenha;
            Idade = idade;
        }

        public void ExisteConta(int id, string senha) {
            string nome = string.Empty;
            try {
                classePrincipal.VerificaBanco();
                conectaBanco.AbreConexaoBanco();

                conectaBanco.QuerySQL = new FbCommand($"SELECT * FROM Usuarios WHERE id_usuario = {id} AND senha = '{senha}';", conectaBanco.connection);

                conectaBanco.QuerySQL.CommandType = CommandType.Text;

                FbDataReader dataReader = conectaBanco.QuerySQL.ExecuteReader();

                switch (dataReader.Read()) {
                    case true:
                        UsuarioEncontrado = true;
                        conectaBanco.QuerySQL = new FbCommand($"SELECT Nome from Usuarios where id_usuario = {id} and senha = '{senha}'", conectaBanco.connection);

                        conectaBanco.QuerySQL.CommandType = CommandType.Text;

                        FbDataReader reader = conectaBanco.QuerySQL.ExecuteReader();
                        while (reader.Read()) {
                            nome = reader.GetString(0);
                        }

                        if (int.Parse(DateTime.Now.ToString("HH")) >= 5 && int.Parse(DateTime.Now.ToString("HH")) < 12) {
                            MessageBox.Show($"Bom dia, {nome}!", $"Bem vindo - {DateTime.Now.ToString("HH:mm")}", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else if (int.Parse(DateTime.Now.ToString("HH")) >= 12 && int.Parse(DateTime.Now.ToString("HH")) < 18) {
                            MessageBox.Show($"Boa tarde, {nome}!", $"Bem vindo - {DateTime.Now.ToString("HH:mm")}", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else if (int.Parse(DateTime.Now.ToString("HH")) >= 18 && double.Parse(DateTime.Now.ToString("HH:mm")) < 23.59 || int.Parse(DateTime.Now.ToString("HH")) < 5) {
                            MessageBox.Show($"Boa noite, {nome}!", $"Bem vindo - {DateTime.Now.ToString("HH:mm")}", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        break;
                    case false:
                        UsuarioEncontrado = false;
                        MessageBox.Show($"Usuário não encontrado na base de dados, crie um registro novo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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