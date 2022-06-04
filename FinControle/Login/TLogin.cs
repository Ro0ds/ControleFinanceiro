using System;
using FinControle.DB;
using FinControle.Login;
using System.Windows.Forms;

namespace FinControle.Login {
    public partial class TLogin : Form {
        ConectaBanco conectaBanco;
        DBClassePrincipal dBClasse;

        public TLogin() {
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

        private void btnEntrar_Click(object sender, EventArgs e) {
            int id = int.Parse(txtId.Text);
            string senha = txtSenha.Text;
            
            Logar logar = new Logar();
            logar.ExisteConta(id, senha);
        }

        private void btnCriar_Click(object sender, EventArgs e) {

        }
    }
}