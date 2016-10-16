namespace AtualizacaoBaseDeDados
{
    partial class frPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPrincipal));
            this.btProcurarBase = new System.Windows.Forms.Button();
            this.btConectarBanco = new System.Windows.Forms.Button();
            this.lLocal = new System.Windows.Forms.Label();
            this.tbCaminhoBanco = new System.Windows.Forms.TextBox();
            this.lIp = new System.Windows.Forms.Label();
            this.cbLocalhost = new System.Windows.Forms.CheckBox();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.ofdBanco = new System.Windows.Forms.OpenFileDialog();
            this.btSincronizacao = new System.Windows.Forms.Button();
            this.btCarregarArquivo = new System.Windows.Forms.Button();
            this.lPasso1 = new System.Windows.Forms.Label();
            this.lPasso2 = new System.Windows.Forms.Label();
            this.lPasso3 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.tbCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.btProcurarArquivo = new System.Windows.Forms.Button();
            this.ofdScript = new System.Windows.Forms.OpenFileDialog();
            this.btBackup = new System.Windows.Forms.Button();
            this.lPasso4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSobre = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btProcurarBase
            // 
            this.btProcurarBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProcurarBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurarBase.Location = new System.Drawing.Point(379, 72);
            this.btProcurarBase.Name = "btProcurarBase";
            this.btProcurarBase.Size = new System.Drawing.Size(90, 29);
            this.btProcurarBase.TabIndex = 99;
            this.btProcurarBase.Text = "Procurar";
            this.btProcurarBase.UseVisualStyleBackColor = true;
            this.btProcurarBase.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // btConectarBanco
            // 
            this.btConectarBanco.BackColor = System.Drawing.Color.White;
            this.btConectarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConectarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConectarBanco.Image = ((System.Drawing.Image)(resources.GetObject("btConectarBanco.Image")));
            this.btConectarBanco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConectarBanco.Location = new System.Drawing.Point(12, 171);
            this.btConectarBanco.Name = "btConectarBanco";
            this.btConectarBanco.Size = new System.Drawing.Size(189, 57);
            this.btConectarBanco.TabIndex = 98;
            this.btConectarBanco.Text = "Conectar Banco ";
            this.btConectarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConectarBanco.UseVisualStyleBackColor = false;
            this.btConectarBanco.Visible = false;
            this.btConectarBanco.Click += new System.EventHandler(this.btConectarBanco_Click);
            // 
            // lLocal
            // 
            this.lLocal.AutoSize = true;
            this.lLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLocal.Location = new System.Drawing.Point(7, 71);
            this.lLocal.Name = "lLocal";
            this.lLocal.Size = new System.Drawing.Size(51, 20);
            this.lLocal.TabIndex = 97;
            this.lLocal.Text = "Local:";
            // 
            // tbCaminhoBanco
            // 
            this.tbCaminhoBanco.Enabled = false;
            this.tbCaminhoBanco.Location = new System.Drawing.Point(64, 73);
            this.tbCaminhoBanco.Name = "tbCaminhoBanco";
            this.tbCaminhoBanco.ReadOnly = true;
            this.tbCaminhoBanco.Size = new System.Drawing.Size(309, 26);
            this.tbCaminhoBanco.TabIndex = 94;
            // 
            // lIp
            // 
            this.lIp.AutoSize = true;
            this.lIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIp.Location = new System.Drawing.Point(30, 33);
            this.lIp.Name = "lIp";
            this.lIp.Size = new System.Drawing.Size(28, 20);
            this.lIp.TabIndex = 96;
            this.lIp.Text = "IP:";
            // 
            // cbLocalhost
            // 
            this.cbLocalhost.AutoSize = true;
            this.cbLocalhost.Checked = true;
            this.cbLocalhost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLocalhost.Enabled = false;
            this.cbLocalhost.Location = new System.Drawing.Point(301, 32);
            this.cbLocalhost.Name = "cbLocalhost";
            this.cbLocalhost.Size = new System.Drawing.Size(158, 24);
            this.cbLocalhost.TabIndex = 93;
            this.cbLocalhost.Text = "Computador Local";
            this.cbLocalhost.UseVisualStyleBackColor = true;
            this.cbLocalhost.CheckedChanged += new System.EventHandler(this.cbLocalhost_CheckedChanged);
            // 
            // tbIp
            // 
            this.tbIp.Enabled = false;
            this.tbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIp.Location = new System.Drawing.Point(64, 30);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(214, 26);
            this.tbIp.TabIndex = 95;
            this.tbIp.Text = "localhost";
            // 
            // ofdBanco
            // 
            this.ofdBanco.Filter = "Bando de Dados Firebird (*.GDB)|";
            // 
            // btSincronizacao
            // 
            this.btSincronizacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSincronizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSincronizacao.Image = ((System.Drawing.Image)(resources.GetObject("btSincronizacao.Image")));
            this.btSincronizacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSincronizacao.Location = new System.Drawing.Point(597, 171);
            this.btSincronizacao.Name = "btSincronizacao";
            this.btSincronizacao.Size = new System.Drawing.Size(189, 56);
            this.btSincronizacao.TabIndex = 100;
            this.btSincronizacao.Text = "Sincronizar";
            this.btSincronizacao.UseVisualStyleBackColor = true;
            this.btSincronizacao.Visible = false;
            this.btSincronizacao.Click += new System.EventHandler(this.btSincronizacao_Click);
            // 
            // btCarregarArquivo
            // 
            this.btCarregarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCarregarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarregarArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btCarregarArquivo.Image")));
            this.btCarregarArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCarregarArquivo.Location = new System.Drawing.Point(402, 171);
            this.btCarregarArquivo.Name = "btCarregarArquivo";
            this.btCarregarArquivo.Size = new System.Drawing.Size(189, 56);
            this.btCarregarArquivo.TabIndex = 101;
            this.btCarregarArquivo.Text = "Carregar Script";
            this.btCarregarArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCarregarArquivo.UseVisualStyleBackColor = true;
            this.btCarregarArquivo.Visible = false;
            this.btCarregarArquivo.Click += new System.EventHandler(this.btCarregarArquivo_Click);
            // 
            // lPasso1
            // 
            this.lPasso1.AutoSize = true;
            this.lPasso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasso1.Location = new System.Drawing.Point(69, 148);
            this.lPasso1.Name = "lPasso1";
            this.lPasso1.Size = new System.Drawing.Size(66, 20);
            this.lPasso1.TabIndex = 102;
            this.lPasso1.Text = "Passo 1";
            this.lPasso1.Visible = false;
            // 
            // lPasso2
            // 
            this.lPasso2.AutoSize = true;
            this.lPasso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasso2.Location = new System.Drawing.Point(273, 148);
            this.lPasso2.Name = "lPasso2";
            this.lPasso2.Size = new System.Drawing.Size(66, 20);
            this.lPasso2.TabIndex = 103;
            this.lPasso2.Text = "Passo 2";
            this.lPasso2.Visible = false;
            // 
            // lPasso3
            // 
            this.lPasso3.AutoSize = true;
            this.lPasso3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasso3.Location = new System.Drawing.Point(462, 148);
            this.lPasso3.Name = "lPasso3";
            this.lPasso3.Size = new System.Drawing.Size(66, 20);
            this.lPasso3.TabIndex = 104;
            this.lPasso3.Text = "Passo 3";
            this.lPasso3.Visible = false;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.tbCaminhoArquivo);
            this.gb.Controls.Add(this.lIp);
            this.gb.Controls.Add(this.btProcurarArquivo);
            this.gb.Controls.Add(this.tbIp);
            this.gb.Controls.Add(this.cbLocalhost);
            this.gb.Controls.Add(this.tbCaminhoBanco);
            this.gb.Controls.Add(this.lLocal);
            this.gb.Controls.Add(this.btProcurarBase);
            this.gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.Location = new System.Drawing.Point(130, 12);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(530, 120);
            this.gb.TabIndex = 107;
            this.gb.TabStop = false;
            this.gb.Text = "Conectar Banco";
            this.gb.Visible = false;
            // 
            // tbCaminhoArquivo
            // 
            this.tbCaminhoArquivo.Enabled = false;
            this.tbCaminhoArquivo.Location = new System.Drawing.Point(64, 51);
            this.tbCaminhoArquivo.Name = "tbCaminhoArquivo";
            this.tbCaminhoArquivo.ReadOnly = true;
            this.tbCaminhoArquivo.Size = new System.Drawing.Size(309, 26);
            this.tbCaminhoArquivo.TabIndex = 100;
            this.tbCaminhoArquivo.Visible = false;
            // 
            // btProcurarArquivo
            // 
            this.btProcurarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProcurarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurarArquivo.Location = new System.Drawing.Point(379, 50);
            this.btProcurarArquivo.Name = "btProcurarArquivo";
            this.btProcurarArquivo.Size = new System.Drawing.Size(90, 29);
            this.btProcurarArquivo.TabIndex = 102;
            this.btProcurarArquivo.Text = "Procurar";
            this.btProcurarArquivo.UseVisualStyleBackColor = true;
            this.btProcurarArquivo.Visible = false;
            this.btProcurarArquivo.Click += new System.EventHandler(this.btProcurarArquivo_Click);
            // 
            // ofdScript
            // 
            this.ofdScript.Filter = " (*.SQL)|";
            // 
            // btBackup
            // 
            this.btBackup.BackColor = System.Drawing.Color.White;
            this.btBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackup.Image = ((System.Drawing.Image)(resources.GetObject("btBackup.Image")));
            this.btBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBackup.Location = new System.Drawing.Point(207, 171);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(189, 57);
            this.btBackup.TabIndex = 109;
            this.btBackup.Text = "Realizar Backup";
            this.btBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBackup.UseVisualStyleBackColor = false;
            this.btBackup.Visible = false;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // lPasso4
            // 
            this.lPasso4.AutoSize = true;
            this.lPasso4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasso4.Location = new System.Drawing.Point(657, 148);
            this.lPasso4.Name = "lPasso4";
            this.lPasso4.Size = new System.Drawing.Size(66, 20);
            this.lPasso4.TabIndex = 110;
            this.lPasso4.Text = "Passo 4";
            this.lPasso4.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(653, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // btSobre
            // 
            this.btSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSobre.Location = new System.Drawing.Point(2, 2);
            this.btSobre.Name = "btSobre";
            this.btSobre.Size = new System.Drawing.Size(75, 23);
            this.btSobre.TabIndex = 112;
            this.btSobre.Text = "Sobre";
            this.btSobre.UseVisualStyleBackColor = true;
            this.btSobre.Click += new System.EventHandler(this.btSobre_Click);
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 288);
            this.Controls.Add(this.btSobre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lPasso4);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.lPasso3);
            this.Controls.Add(this.lPasso2);
            this.Controls.Add(this.lPasso1);
            this.Controls.Add(this.btCarregarArquivo);
            this.Controls.Add(this.btSincronizacao);
            this.Controls.Add(this.btConectarBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btProcurarBase;
        private System.Windows.Forms.Button btConectarBanco;
        private System.Windows.Forms.Label lLocal;
        private System.Windows.Forms.TextBox tbCaminhoBanco;
        private System.Windows.Forms.Label lIp;
        private System.Windows.Forms.CheckBox cbLocalhost;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.OpenFileDialog ofdBanco;
        private System.Windows.Forms.Button btSincronizacao;
        private System.Windows.Forms.Button btCarregarArquivo;
        private System.Windows.Forms.Label lPasso1;
        private System.Windows.Forms.Label lPasso2;
        private System.Windows.Forms.Label lPasso3;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TextBox tbCaminhoArquivo;
        private System.Windows.Forms.Button btProcurarArquivo;
        private System.Windows.Forms.OpenFileDialog ofdScript;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Label lPasso4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSobre;
    }
}