using System;
using FinControle.DB;
using System.Windows.Forms;
using System.Threading;

namespace FinControle.Login {
    public partial class Entrar : Form {
        ConectaBanco conectaBanco;
        DBClassePrincipal dBClasse;
        Logar logar;
        public int id { get; set; } = 0;
        public string senha { get; set; } = string.Empty;

        public Entrar() {
            InitializeComponent();
            logar = new Logar();
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

        private void btnEntrar_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(txtSenha.Text) || numId.Value == 0) {
                MessageBox.Show("Campo ID e senha não podem ser nulos ou 0", "Aviso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                numId.Value = 0;
                return;
            }

            id = Convert.ToInt32(numId.Value);
            senha = txtSenha.Text;

            try {
                logar.ExisteConta(id, senha);
                txtSenha.Text = string.Empty;
            }
            catch (Exception a) {
                MessageBox.Show($"Erro: {a.Message}", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            finally {
                conectaBanco.connection.Close();
            }

            switch (logar.UsuarioEncontrado) {
                case true:                  
                    Thread.Sleep(1000);
                    break;
                case false:
                    break;
            }
        }

        private void btnCriar_Click(object sender, EventArgs e) {
            CriarConta criar = new CriarConta();
            criar.Senha = txtSenha.Text;
            criar.Show();
        }
    }
}