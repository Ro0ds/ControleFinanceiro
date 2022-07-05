using System;
using System.Windows.Forms;
using FinControle.DB;
using FinControle.Salario;

namespace FinControle.Telas {
    public partial class Ganhos : Form {
        public static double SalarioBruto { get; set; }
        public Ganhos() {
            InitializeComponent();
        }

        private void Ganhos_Load(object sender, EventArgs e) {
            lblNome.Text = UsuarioConectado.Nome;
        }

        private void btnCalcularINSS_Click(object sender, EventArgs e) {
            if (txtSalarioBruto.Text == string.Empty) {
                MessageBox.Show("Insira um valor.", "Erro - Valor em branco", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (INSS.InssFinal == 0) {
                INSS.CalculaInss(double.Parse(txtSalarioBruto.Text));
                txtINSS.Text = INSS.InssFinal.ToString("F2");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            foreach (Control txt in boxSalario.Controls) {
                if (txt is TextBox && txt.Tag == "referencia") {
                    txt.Enabled = true;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            foreach (Control txt in boxSalario.Controls) {
                if(txt is TextBox && txt.Tag == "referencia") {
                    txt.Enabled = false;
                }
            }
        }

        private void btnCalculaSalarioLiquido_Click(object sender, EventArgs e) {
            Liquido.CalculaSalarioLiquido(double.Parse(txtSalarioBruto.Text), double.Parse(txtPlanoSaude.Text), double.Parse(txtVT.Text), double.Parse(txtVR.Text), double.Parse(txtINSS.Text));

            txtSalarioLiquido.Text = $"R${Liquido.SalarioLiquido:F2}";
            lblTexto.Visible = true;
            lblGanhos.Visible = true;
            lblGanhos.Text = txtSalarioLiquido.Text;
            Principal.Saldo = Liquido.SalarioLiquido;
        }
    }
}
