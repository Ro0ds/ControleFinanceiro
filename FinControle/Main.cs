using System;
using FinControle.DB;
using FinControle.Login;
using System.Windows.Forms;

namespace FinControle {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DBClassePrincipal dBClasse = new DBClassePrincipal();

            dBClasse.VerificaBanco();
        }
    }
}