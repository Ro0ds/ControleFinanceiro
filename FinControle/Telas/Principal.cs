using System;
using FinControle.DB;
using FinControle.Properties;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using CefSharp;
using FinControle.Telas;
using FinControle.Login;

namespace FinControle {
    public partial class Principal : Form {
        ConectaBanco conectaBanco = new ConectaBanco();
        DBClassePrincipal dBClasse = new DBClassePrincipal();
        private Form activeForm = null;

        public string comando { get; set; }
        public Principal() {
            InitializeComponent();
            try {
                dBClasse.VerificaBanco();
            }
            catch (Exception a) {
                MessageBox.Show($"Erro: {a.Message}", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally {
                conectaBanco.AbreConexaoBanco();
                lblUsuario.Text = UsuarioConectado.Nome;
                Timer();
                customizarMenu();
                navegador.LoadUrl("https://valor.globo.com/financas/");
            }
        }

        private void customizarMenu() {
            painelRegistroSubMenu.Visible = false;
            painelRelatorioSubMenu.Visible = false;
            painelPerfilSubMenu.Visible = false;
            painelMetaSubMenu.Visible = false;
        }

        private void esconderSubMenu() {
            if (painelRegistroSubMenu.Visible == true)
                painelRegistroSubMenu.Visible = false;
            if (painelRelatorioSubMenu.Visible == true)
                painelRelatorioSubMenu.Visible = false;
            if (painelPerfilSubMenu.Visible == true)
                painelPerfilSubMenu.Visible = false;
            if (painelMetaSubMenu.Visible == true)
                painelMetaSubMenu.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu) {
            if (subMenu.Visible == false) {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else {
                subMenu.Visible = false;
            }
        }

        private void openChildForm(Form childForm) {
            if (activeForm != null) {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            painelPrincipal.Controls.Add(childForm);
            painelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRegistro_Click_1(object sender, EventArgs e) {
            mostrarSubMenu(painelRegistroSubMenu);
        }

        private void btnRelatorios_Click_1(object sender, EventArgs e) {
            mostrarSubMenu(painelRelatorioSubMenu);
        }

        private void btnPerfil_Click_1(object sender, EventArgs e) {
            mostrarSubMenu(painelPerfilSubMenu);
        }

        private void btnMeta_Click_1(object sender, EventArgs e) {
            mostrarSubMenu(painelMetaSubMenu);
        }

        private void btnSair_Click_1(object sender, EventArgs e) {
            Application.Exit();
        }

        private void imgMudarVisibilidade_Click(object sender, EventArgs e) {
            if (lblSaldo.Text.Contains("R$")) {
                imgMudarVisibilidade.Image = Resources.visible;
                lblSaldo.Text = "-";
            }
            else if (lblSaldo.Text.Contains("-")) {
                imgMudarVisibilidade.Image = Resources.notvisible;
                lblSaldo.Text = "R$1.500.000,00";
            }
        }

        #region Timer
        private void TemporizadorPrincipal_Tick(object sender, EventArgs e) {
            if (conectaBanco.connection.State == ConnectionState.Open) {
                lblStatusBanco.Text = "Conectado";
                lblStatusBanco.ForeColor = Color.LawnGreen;
            }
            else {
                lblStatusBanco.Text = "Desconectado";
                lblStatusBanco.ForeColor = Color.DarkRed;
            }

            lblHorario.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }
        public void Timer() {
            TemporizadorPrincipal.Enabled = true;
            TemporizadorPrincipal.Interval = 1000;
        }


        #endregion

        private void btnGanhos_Click(object sender, EventArgs e) {
            openChildForm(new Ganhos());
            navegador.Stop();
        }

        private void btnPrincipal_Click(object sender, EventArgs e) {
            navegador.Reload();
            esconderSubMenu();
            FecharTelas();
        }

        private void FecharTelas() {
            Ganhos ganhos = (Ganhos)Application.OpenForms["Ganhos"];
            //Tela tela = (Tela)Application.OpenForms["Tela"];
            ganhos.Close();
        }
    }
}