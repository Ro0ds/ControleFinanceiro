
namespace FinControle.Telas {
    partial class Ganhos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.boxSalario = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalculaSalarioLiquido = new System.Windows.Forms.Button();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.btnCalcularINSS = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtPlanoSaude = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdiantamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiasTrabalhados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblGanhos = new System.Windows.Forms.Label();
            this.boxSalario.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxSalario
            // 
            this.boxSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.boxSalario.Controls.Add(this.lblGanhos);
            this.boxSalario.Controls.Add(this.lblTexto);
            this.boxSalario.Controls.Add(this.label10);
            this.boxSalario.Controls.Add(this.btnCalculaSalarioLiquido);
            this.boxSalario.Controls.Add(this.txtSalarioLiquido);
            this.boxSalario.Controls.Add(this.txtINSS);
            this.boxSalario.Controls.Add(this.btnCalcularINSS);
            this.boxSalario.Controls.Add(this.label9);
            this.boxSalario.Controls.Add(this.btnSalvar);
            this.boxSalario.Controls.Add(this.btnEditar);
            this.boxSalario.Controls.Add(this.txtPlanoSaude);
            this.boxSalario.Controls.Add(this.label8);
            this.boxSalario.Controls.Add(this.txtAdiantamento);
            this.boxSalario.Controls.Add(this.label7);
            this.boxSalario.Controls.Add(this.txtVR);
            this.boxSalario.Controls.Add(this.label6);
            this.boxSalario.Controls.Add(this.txtVT);
            this.boxSalario.Controls.Add(this.label5);
            this.boxSalario.Controls.Add(this.txtDiasTrabalhados);
            this.boxSalario.Controls.Add(this.label4);
            this.boxSalario.Controls.Add(this.label3);
            this.boxSalario.Controls.Add(this.txtSalarioBruto);
            this.boxSalario.Controls.Add(this.label2);
            this.boxSalario.Controls.Add(this.label1);
            this.boxSalario.Controls.Add(this.lblNome);
            this.boxSalario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxSalario.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.boxSalario.Location = new System.Drawing.Point(12, 12);
            this.boxSalario.Name = "boxSalario";
            this.boxSalario.Size = new System.Drawing.Size(417, 298);
            this.boxSalario.TabIndex = 0;
            this.boxSalario.TabStop = false;
            this.boxSalario.Text = "Registro de salário";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(19, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 14);
            this.label10.TabIndex = 23;
            this.label10.Text = "Calcular salário liquido";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculaSalarioLiquido
            // 
            this.btnCalculaSalarioLiquido.Location = new System.Drawing.Point(19, 267);
            this.btnCalculaSalarioLiquido.Name = "btnCalculaSalarioLiquido";
            this.btnCalculaSalarioLiquido.Size = new System.Drawing.Size(193, 23);
            this.btnCalculaSalarioLiquido.TabIndex = 22;
            this.btnCalculaSalarioLiquido.Text = "Calcular";
            this.btnCalculaSalarioLiquido.UseVisualStyleBackColor = true;
            this.btnCalculaSalarioLiquido.Click += new System.EventHandler(this.btnCalculaSalarioLiquido_Click);
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(19, 238);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(193, 23);
            this.txtSalarioLiquido.TabIndex = 21;
            this.txtSalarioLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtINSS
            // 
            this.txtINSS.Enabled = false;
            this.txtINSS.Location = new System.Drawing.Point(19, 186);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.ReadOnly = true;
            this.txtINSS.Size = new System.Drawing.Size(73, 23);
            this.txtINSS.TabIndex = 20;
            this.txtINSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcularINSS
            // 
            this.btnCalcularINSS.Location = new System.Drawing.Point(98, 186);
            this.btnCalcularINSS.Name = "btnCalcularINSS";
            this.btnCalcularINSS.Size = new System.Drawing.Size(114, 23);
            this.btnCalcularINSS.TabIndex = 19;
            this.btnCalcularINSS.Text = "INSS";
            this.btnCalcularINSS.UseVisualStyleBackColor = true;
            this.btnCalcularINSS.Click += new System.EventHandler(this.btnCalcularINSS_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(16, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "INSS";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(246, 185);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(74, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(326, 185);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(74, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtPlanoSaude
            // 
            this.txtPlanoSaude.Location = new System.Drawing.Point(19, 135);
            this.txtPlanoSaude.Name = "txtPlanoSaude";
            this.txtPlanoSaude.Size = new System.Drawing.Size(193, 23);
            this.txtPlanoSaude.TabIndex = 14;
            this.txtPlanoSaude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Plano de saúde (ex: 1200,00)";
            // 
            // txtAdiantamento
            // 
            this.txtAdiantamento.Enabled = false;
            this.txtAdiantamento.Location = new System.Drawing.Point(361, 148);
            this.txtAdiantamento.Name = "txtAdiantamento";
            this.txtAdiantamento.Size = new System.Drawing.Size(37, 23);
            this.txtAdiantamento.TabIndex = 12;
            this.txtAdiantamento.Tag = "referencia";
            this.txtAdiantamento.Text = "40";
            this.txtAdiantamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(243, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "Adiantamento(%)";
            // 
            // txtVR
            // 
            this.txtVR.Enabled = false;
            this.txtVR.Location = new System.Drawing.Point(361, 119);
            this.txtVR.Name = "txtVR";
            this.txtVR.Size = new System.Drawing.Size(37, 23);
            this.txtVR.TabIndex = 10;
            this.txtVR.Tag = "referencia";
            this.txtVR.Text = "0";
            this.txtVR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(313, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "VR(%)";
            // 
            // txtVT
            // 
            this.txtVT.Enabled = false;
            this.txtVT.Location = new System.Drawing.Point(361, 90);
            this.txtVT.Name = "txtVT";
            this.txtVT.Size = new System.Drawing.Size(37, 23);
            this.txtVT.TabIndex = 8;
            this.txtVT.Tag = "referencia";
            this.txtVT.Text = "0";
            this.txtVT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(313, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "VT(%)";
            // 
            // txtDiasTrabalhados
            // 
            this.txtDiasTrabalhados.Enabled = false;
            this.txtDiasTrabalhados.Location = new System.Drawing.Point(361, 61);
            this.txtDiasTrabalhados.Name = "txtDiasTrabalhados";
            this.txtDiasTrabalhados.Size = new System.Drawing.Size(37, 23);
            this.txtDiasTrabalhados.TabIndex = 6;
            this.txtDiasTrabalhados.Tag = "referencia";
            this.txtDiasTrabalhados.Text = "30";
            this.txtDiasTrabalhados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(237, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dias trabalhados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(321, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Referência";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(19, 82);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(193, 23);
            this.txtSalarioBruto.TabIndex = 3;
            this.txtSalarioBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário bruto (ex: 1200,00)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(57, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 14);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblTexto.Location = new System.Drawing.Point(270, 221);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(100, 29);
            this.lblTexto.TabIndex = 24;
            this.lblTexto.Text = "Ganhos";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTexto.Visible = false;
            // 
            // lblGanhos
            // 
            this.lblGanhos.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblGanhos.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblGanhos.Location = new System.Drawing.Point(270, 250);
            this.lblGanhos.Name = "lblGanhos";
            this.lblGanhos.Size = new System.Drawing.Size(100, 29);
            this.lblGanhos.TabIndex = 25;
            this.lblGanhos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ganhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1004, 699);
            this.Controls.Add(this.boxSalario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ganhos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganhos";
            this.Load += new System.EventHandler(this.Ganhos_Load);
            this.boxSalario.ResumeLayout(false);
            this.boxSalario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlanoSaude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdiantamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiasTrabalhados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCalcularINSS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalculaSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label lblGanhos;
        private System.Windows.Forms.Label lblTexto;
    }
}