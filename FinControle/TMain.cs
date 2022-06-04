﻿using System;
using FinControle.DB;
using System.Data;
using FinControle.Login;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace FinControle {
    public partial class TMain : Form {
        ConectaBanco conectaBanco = new ConectaBanco();
        DBClassePrincipal dBClasse = new DBClassePrincipal();
        public TMain() {
            InitializeComponent();
            try {
                dBClasse.VerificaBanco();
            }
            catch (Exception a) {
                MessageBox.Show($"Erro: {a.Message}", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally {
                conectaBanco.AbreConexaoBanco();
                Timer();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            conectaBanco.connection.Close();
        }

        private void TemporizadorPrincipal_Tick(object sender, EventArgs e) {
            if (conectaBanco.connection.State == ConnectionState.Open) {
                lblStatusBanco.Text = "Conectado";
                lblStatusBanco.ForeColor = Color.LawnGreen;
            }
            else {
                lblStatusBanco.Text = "Desconectado";
                lblStatusBanco.ForeColor = Color.DarkRed;
            }

            lblHorario.Text = DateTime.Now.ToString("dd:MM:yyyy - HH:mm:ss");
        }
        public void Timer() {
            TemporizadorPrincipal.Enabled = true;
            TemporizadorPrincipal.Interval = 1000;
        }
    }
}