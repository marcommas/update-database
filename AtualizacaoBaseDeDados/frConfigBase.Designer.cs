namespace AtualizacaoBaseDeDados
{
    partial class frConfigBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frConfigBase));
            this.btProcurarBase = new System.Windows.Forms.Button();
            this.btConectarBanco = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCaminhoBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLocalhost = new System.Windows.Forms.CheckBox();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.ofdBanco = new System.Windows.Forms.OpenFileDialog();
            this.btSincronizacao = new System.Windows.Forms.Button();
            this.btCarregarArquivo = new System.Windows.Forms.Button();
            this.lPasso1 = new System.Windows.Forms.Label();
            this.lPasso2 = new System.Windows.Forms.Label();
            this.lPasso3 = new System.Windows.Forms.Label();
            this.gbConectarBanco = new System.Windows.Forms.GroupBox();
            this.gbCarregarArquivo = new System.Windows.Forms.GroupBox();
            this.tbCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.btProcurarArquivo = new System.Windows.Forms.Button();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btBackup = new System.Windows.Forms.Button();
            this.lPasso4 = new System.Windows.Forms.Label();
            this.gbConectarBanco.SuspendLayout();
            this.gbCarregarArquivo.SuspendLayout();
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
            this.btConectarBanco.Location = new System.Drawing.Point(238, 174);
            this.btConectarBanco.Name = "btConectarBanco";
            this.btConectarBanco.Size = new System.Drawing.Size(189, 57);
            this.btConectarBanco.TabIndex = 98;
            this.btConectarBanco.Text = "Conectar Banco ";
            this.btConectarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConectarBanco.UseVisualStyleBackColor = false;
            this.btConectarBanco.Visible = false;
            this.btConectarBanco.Click += new System.EventHandler(this.btConectarBanco_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "Local:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "IP:";
            // 
            // cbLocalhost
            // 
            this.cbLocalhost.AutoSize = true;
            this.cbLocalhost.Location = new System.Drawing.Point(302, 29);
            this.cbLocalhost.Name = "cbLocalhost";
            this.cbLocalhost.Size = new System.Drawing.Size(158, 24);
            this.cbLocalhost.TabIndex = 93;
            this.cbLocalhost.Text = "Computador Local";
            this.cbLocalhost.UseVisualStyleBackColor = true;
            this.cbLocalhost.CheckedChanged += new System.EventHandler(this.cbLocalhost_CheckedChanged);
            // 
            // tbIp
            // 
            this.tbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIp.Location = new System.Drawing.Point(64, 22);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(214, 26);
            this.tbIp.TabIndex = 95;
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
            this.btSincronizacao.Location = new System.Drawing.Point(669, 175);
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
            this.btCarregarArquivo.Location = new System.Drawing.Point(463, 174);
            this.btCarregarArquivo.Name = "btCarregarArquivo";
            this.btCarregarArquivo.Size = new System.Drawing.Size(189, 56);
            this.btCarregarArquivo.TabIndex = 101;
            this.btCarregarArquivo.Text = "Carregar Arquivo";
            this.btCarregarArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCarregarArquivo.UseVisualStyleBackColor = true;
            this.btCarregarArquivo.Visible = false;
            this.btCarregarArquivo.Click += new System.EventHandler(this.btCarregarArquivo_Click);
            // 
            // lPasso1
            // 
            this.lPasso1.AutoSize = true;
            this.lPasso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasso1.Location = new System.Drawing.Point(86, 148);
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
            this.lPasso2.Location = new System.Drawing.Point(296, 148);
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
            this.lPasso3.Location = new System.Drawing.Point(537, 148);
            this.lPasso3.Name = "lPasso3";
            this.lPasso3.Size = new System.Drawing.Size(66, 20);
            this.lPasso3.TabIndex = 104;
            this.lPasso3.Text = "Passo 3";
            this.lPasso3.Visible = false;
            // 
            // gbConectarBanco
            // 
            this.gbConectarBanco.Controls.Add(this.label1);
            this.gbConectarBanco.Controls.Add(this.tbIp);
            this.gbConectarBanco.Controls.Add(this.gbCarregarArquivo);
            this.gbConectarBanco.Controls.Add(this.cbLocalhost);
            this.gbConectarBanco.Controls.Add(this.tbCaminhoBanco);
            this.gbConectarBanco.Controls.Add(this.label2);
            this.gbConectarBanco.Controls.Add(this.btProcurarBase);
            this.gbConectarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConectarBanco.Location = new System.Drawing.Point(164, 12);
            this.gbConectarBanco.Name = "gbConectarBanco";
            this.gbConectarBanco.Size = new System.Drawing.Size(530, 120);
            this.gbConectarBanco.TabIndex = 107;
            this.gbConectarBanco.TabStop = false;
            this.gbConectarBanco.Text = "Conectar Banco";
            this.gbConectarBanco.Visible = false;
            // 
            // gbCarregarArquivo
            // 
            this.gbCarregarArquivo.Controls.Add(this.tbCaminhoArquivo);
            this.gbCarregarArquivo.Controls.Add(this.btProcurarArquivo);
            this.gbCarregarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarregarArquivo.Location = new System.Drawing.Point(0, 0);
            this.gbCarregarArquivo.Name = "gbCarregarArquivo";
            this.gbCarregarArquivo.Size = new System.Drawing.Size(530, 120);
            this.gbCarregarArquivo.TabIndex = 108;
            this.gbCarregarArquivo.TabStop = false;
            this.gbCarregarArquivo.Text = "Carregar Arquivo";
            this.gbCarregarArquivo.Visible = false;
            // 
            // tbCaminhoArquivo
            // 
            this.tbCaminhoArquivo.Enabled = false;
            this.tbCaminhoArquivo.Location = new System.Drawing.Point(50, 51);
            this.tbCaminhoArquivo.Name = "tbCaminhoArquivo";
            this.tbCaminhoArquivo.ReadOnly = true;
            this.tbCaminhoArquivo.Size = new System.Drawing.Size(309, 26);
            this.tbCaminhoArquivo.TabIndex = 100;
            // 
            // btProcurarArquivo
            // 
            this.btProcurarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProcurarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurarArquivo.Location = new System.Drawing.Point(365, 50);
            this.btProcurarArquivo.Name = "btProcurarArquivo";
            this.btProcurarArquivo.Size = new System.Drawing.Size(90, 29);
            this.btProcurarArquivo.TabIndex = 102;
            this.btProcurarArquivo.Text = "Procurar";
            this.btProcurarArquivo.UseVisualStyleBackColor = true;
            this.btProcurarArquivo.Click += new System.EventHandler(this.btProcurarArquivo_Click);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.Filter = " (*.TXT)|";
            // 
            // btBackup
            // 
            this.btBackup.BackColor = System.Drawing.Color.White;
            this.btBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackup.Image = ((System.Drawing.Image)(resources.GetObject("btBackup.Image")));
            this.btBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBackup.Location = new System.Drawing.Point(23, 175);
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
            this.lPasso4.Location = new System.Drawing.Point(719, 152);
            this.lPasso4.Name = "lPasso4";
            this.lPasso4.Size = new System.Drawing.Size(66, 20);
            this.lPasso4.TabIndex = 110;
            this.lPasso4.Text = "Passo 4";
            this.lPasso4.Visible = false;
            // 
            // frConfigBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 270);
            this.Controls.Add(this.lPasso4);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.gbConectarBanco);
            this.Controls.Add(this.lPasso3);
            this.Controls.Add(this.lPasso2);
            this.Controls.Add(this.lPasso1);
            this.Controls.Add(this.btCarregarArquivo);
            this.Controls.Add(this.btSincronizacao);
            this.Controls.Add(this.btConectarBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frConfigBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbConectarBanco.ResumeLayout(false);
            this.gbConectarBanco.PerformLayout();
            this.gbCarregarArquivo.ResumeLayout(false);
            this.gbCarregarArquivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btProcurarBase;
        private System.Windows.Forms.Button btConectarBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCaminhoBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbLocalhost;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.OpenFileDialog ofdBanco;
        private System.Windows.Forms.Button btSincronizacao;
        private System.Windows.Forms.Button btCarregarArquivo;
        private System.Windows.Forms.Label lPasso1;
        private System.Windows.Forms.Label lPasso2;
        private System.Windows.Forms.Label lPasso3;
        private System.Windows.Forms.GroupBox gbConectarBanco;
        private System.Windows.Forms.GroupBox gbCarregarArquivo;
        private System.Windows.Forms.TextBox tbCaminhoArquivo;
        private System.Windows.Forms.Button btProcurarArquivo;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Label lPasso4;
    }
}