using System;
using FinControle.DB;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace FinControle.Login {
    public partial class LCriar : Form {
        ConectaBanco conectaBanco;
        DBClassePrincipal dBClasse;
        public string Nome { get; private set; }
        public string Senha { get; set; }
        public string DicaSenha { get; private set; }
        public int Idade { get; private set; }

        public LCriar() {
            InitializeComponent();
            conectaBanco = new ConectaBanco();
            dBClasse = new DBClassePrincipal();

            try {
                dBClasse.VerificaBanco();
            }
            catch (Exception a) {
                MessageBox.Show($"Erro: {a.Message}", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally {
                conectaBanco.AbreConexaoBanco();
            }
        }

        private void LCriar_Load(object sender, EventArgs e) {
            txtSenhaCriar.Text = Senha;
        }

        private void btnCriarConta_Click(object sender, EventArgs e) {
            Nome = txtNomeCriar.Text;
            Senha = txtSenhaCriar.Text;
            DicaSenha = txtDicaSenhaCriar.Text;
            Idade = Convert.ToInt32(numIdadeCriar.Value);

            try {
                conectaBanco.QuerySQL = new FbCommand($"INSERT INTO Usuarios (Nome, Idade, Senha, DICA_SENHA) VALUES ('{Nome}', {Idade}, '{Senha}', '{DicaSenha}');", conectaBanco.connection);
                conectaBanco.QuerySQL.CommandType = CommandType.Text;
                conectaBanco.QuerySQL.ExecuteNonQuery();
                MessageBox.Show("Usuário criado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception a) {
                MessageBox.Show($"Erro: {a.Message}", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally {
                conectaBanco.QuerySQL.Connection.Close();
            }
            Close();
        }
    }
}