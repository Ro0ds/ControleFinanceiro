using System;
using FinControle.DB;
using System.Windows.Forms;

namespace FinControle.Login {
    public partial class LLogin : Form {
        ConectaBanco conectaBanco;
        DBClassePrincipal dBClasse;
        Logar logar;
        public int id { get; set; } = 0;
        public string senha { get; set; } = string.Empty;

        public LLogin() {
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
                    TMain main = new TMain();
                    main.Show();
                    break;
                case false:
                    break;
            }
        }

        private void btnCriar_Click(object sender, EventArgs e) {
            LCriar criar = new LCriar();
            criar.Senha = txtSenha.Text;
            criar.Show();
        }

        private void lblFechar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}