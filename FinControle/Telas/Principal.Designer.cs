
namespace FinControle {
    partial class Principal {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TemporizadorPrincipal = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatusBanco = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.navegador = new CefSharp.WinForms.ChromiumWebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.painelMetaSubMenu = new System.Windows.Forms.Panel();
            this.btnMeta = new System.Windows.Forms.Button();
            this.painelPerfilSubMenu = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.painelRelatorioSubMenu = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.painelRegistroSubMenu = new System.Windows.Forms.Panel();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnGanhos = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgMudarVisibilidade = new System.Windows.Forms.PictureBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.painelRegistroSubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMudarVisibilidade)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 699);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 26);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TemporizadorPrincipal
            // 
            this.TemporizadorPrincipal.Interval = 1000;
            this.TemporizadorPrincipal.Tick += new System.EventHandler(this.TemporizadorPrincipal_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 702);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banco:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusBanco
            // 
            this.lblStatusBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatusBanco.AutoSize = true;
            this.lblStatusBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.lblStatusBanco.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusBanco.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatusBanco.Location = new System.Drawing.Point(50, 705);
            this.lblStatusBanco.Name = "lblStatusBanco";
            this.lblStatusBanco.Size = new System.Drawing.Size(91, 14);
            this.lblStatusBanco.TabIndex = 3;
            this.lblStatusBanco.Text = "Desconectado";
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.lblHorario.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(849, 701);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(157, 23);
            this.lblHorario.TabIndex = 5;
            this.lblHorario.Text = "dd:MM:yyyy - HH:mm:ss";
            this.lblHorario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.lblUsuario.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(484, 705);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(91, 14);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Desconhecido";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(423, 705);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuário:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Controls.Add(this.navegador);
            this.painelPrincipal.Controls.Add(this.panel1);
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(1004, 699);
            this.painelPrincipal.TabIndex = 10;
            // 
            // navegador
            // 
            this.navegador.ActivateBrowserOnCreation = false;
            this.navegador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navegador.Location = new System.Drawing.Point(208, 142);
            this.navegador.Name = "navegador";
            this.navegador.Size = new System.Drawing.Size(784, 536);
            this.navegador.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.painelMetaSubMenu);
            this.panel1.Controls.Add(this.btnMeta);
            this.panel1.Controls.Add(this.painelPerfilSubMenu);
            this.panel1.Controls.Add(this.btnPerfil);
            this.panel1.Controls.Add(this.painelRelatorioSubMenu);
            this.panel1.Controls.Add(this.btnRelatorios);
            this.panel1.Controls.Add(this.painelRegistroSubMenu);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.btnPrincipal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 699);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(0, 595);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(189, 30);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // painelMetaSubMenu
            // 
            this.painelMetaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(157)))));
            this.painelMetaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelMetaSubMenu.Location = new System.Drawing.Point(0, 495);
            this.painelMetaSubMenu.Name = "painelMetaSubMenu";
            this.painelMetaSubMenu.Size = new System.Drawing.Size(189, 100);
            this.painelMetaSubMenu.TabIndex = 9;
            // 
            // btnMeta
            // 
            this.btnMeta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMeta.FlatAppearance.BorderSize = 0;
            this.btnMeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeta.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnMeta.ForeColor = System.Drawing.Color.White;
            this.btnMeta.Location = new System.Drawing.Point(0, 465);
            this.btnMeta.Name = "btnMeta";
            this.btnMeta.Size = new System.Drawing.Size(189, 30);
            this.btnMeta.TabIndex = 8;
            this.btnMeta.Text = "Meta (em breve)";
            this.btnMeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeta.UseVisualStyleBackColor = true;
            this.btnMeta.Click += new System.EventHandler(this.btnMeta_Click_1);
            // 
            // painelPerfilSubMenu
            // 
            this.painelPerfilSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(157)))));
            this.painelPerfilSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelPerfilSubMenu.Location = new System.Drawing.Point(0, 365);
            this.painelPerfilSubMenu.Name = "painelPerfilSubMenu";
            this.painelPerfilSubMenu.Size = new System.Drawing.Size(189, 100);
            this.painelPerfilSubMenu.TabIndex = 7;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Location = new System.Drawing.Point(0, 335);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(189, 30);
            this.btnPerfil.TabIndex = 6;
            this.btnPerfil.Text = "Perfil (em breve)";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click_1);
            // 
            // painelRelatorioSubMenu
            // 
            this.painelRelatorioSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(157)))));
            this.painelRelatorioSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelRelatorioSubMenu.Location = new System.Drawing.Point(0, 235);
            this.painelRelatorioSubMenu.Name = "painelRelatorioSubMenu";
            this.painelRelatorioSubMenu.Size = new System.Drawing.Size(189, 100);
            this.painelRelatorioSubMenu.TabIndex = 5;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 205);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(189, 30);
            this.btnRelatorios.TabIndex = 4;
            this.btnRelatorios.Text = "Relatórios (em breve)";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click_1);
            // 
            // painelRegistroSubMenu
            // 
            this.painelRegistroSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(157)))));
            this.painelRegistroSubMenu.Controls.Add(this.btnGastos);
            this.painelRegistroSubMenu.Controls.Add(this.btnGanhos);
            this.painelRegistroSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelRegistroSubMenu.Location = new System.Drawing.Point(0, 142);
            this.painelRegistroSubMenu.Name = "painelRegistroSubMenu";
            this.painelRegistroSubMenu.Size = new System.Drawing.Size(189, 63);
            this.painelRegistroSubMenu.TabIndex = 3;
            // 
            // btnGastos
            // 
            this.btnGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnGastos.ForeColor = System.Drawing.Color.White;
            this.btnGastos.Location = new System.Drawing.Point(0, 30);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(189, 30);
            this.btnGastos.TabIndex = 12;
            this.btnGastos.Text = "  Gastos";
            this.btnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.UseVisualStyleBackColor = true;
            // 
            // btnGanhos
            // 
            this.btnGanhos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGanhos.FlatAppearance.BorderSize = 0;
            this.btnGanhos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGanhos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGanhos.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnGanhos.ForeColor = System.Drawing.Color.White;
            this.btnGanhos.Location = new System.Drawing.Point(0, 0);
            this.btnGanhos.Name = "btnGanhos";
            this.btnGanhos.Size = new System.Drawing.Size(189, 30);
            this.btnGanhos.TabIndex = 11;
            this.btnGanhos.Text = "  Ganhos";
            this.btnGanhos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGanhos.UseVisualStyleBackColor = true;
            this.btnGanhos.Click += new System.EventHandler(this.btnGanhos_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Location = new System.Drawing.Point(0, 112);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(189, 30);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click_1);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPrincipal.Location = new System.Drawing.Point(0, 82);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(189, 30);
            this.btnPrincipal.TabIndex = 1;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.panel2.Controls.Add(this.imgMudarVisibilidade);
            this.panel2.Controls.Add(this.lblSaldo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 82);
            this.panel2.TabIndex = 0;
            // 
            // imgMudarVisibilidade
            // 
            this.imgMudarVisibilidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMudarVisibilidade.Image = ((System.Drawing.Image)(resources.GetObject("imgMudarVisibilidade.Image")));
            this.imgMudarVisibilidade.Location = new System.Drawing.Point(3, 25);
            this.imgMudarVisibilidade.Name = "imgMudarVisibilidade";
            this.imgMudarVisibilidade.Size = new System.Drawing.Size(30, 30);
            this.imgMudarVisibilidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMudarVisibilidade.TabIndex = 3;
            this.imgMudarVisibilidade.TabStop = false;
            this.imgMudarVisibilidade.Click += new System.EventHandler(this.imgMudarVisibilidade_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(36, 29);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(20, 22);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "-";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1004, 725);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblStatusBanco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Financeiro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.painelRegistroSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMudarVisibilidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TemporizadorPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatusBanco;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel painelRegistroSubMenu;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Panel painelRelatorioSubMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel painelMetaSubMenu;
        private System.Windows.Forms.Button btnMeta;
        private System.Windows.Forms.Panel painelPerfilSubMenu;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnGanhos;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.PictureBox imgMudarVisibilidade;
        private CefSharp.WinForms.ChromiumWebBrowser navegador;
    }
}

