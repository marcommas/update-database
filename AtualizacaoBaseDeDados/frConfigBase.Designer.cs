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
            this.btProcurar = new System.Windows.Forms.Button();
            this.bSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCaminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLocalhost = new System.Windows.Forms.CheckBox();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.ofdBanco = new System.Windows.Forms.OpenFileDialog();
            this.btSincronizacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btProcurar
            // 
            this.btProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurar.Location = new System.Drawing.Point(384, 64);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(90, 29);
            this.btProcurar.TabIndex = 99;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // bSalvar
            // 
            this.bSalvar.BackColor = System.Drawing.Color.White;
            this.bSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSalvar.Location = new System.Drawing.Point(27, 179);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(170, 70);
            this.bSalvar.TabIndex = 98;
            this.bSalvar.Text = "Conectar Banco ";
            this.bSalvar.UseVisualStyleBackColor = false;
            this.bSalvar.Click += new System.EventHandler(this.bSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "Local:";
            // 
            // tbCaminho
            // 
            this.tbCaminho.Location = new System.Drawing.Point(69, 70);
            this.tbCaminho.Name = "tbCaminho";
            this.tbCaminho.Size = new System.Drawing.Size(309, 20);
            this.tbCaminho.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "IP:";
            // 
            // cbLocalhost
            // 
            this.cbLocalhost.AutoSize = true;
            this.cbLocalhost.Location = new System.Drawing.Point(307, 26);
            this.cbLocalhost.Name = "cbLocalhost";
            this.cbLocalhost.Size = new System.Drawing.Size(112, 17);
            this.cbLocalhost.TabIndex = 93;
            this.cbLocalhost.Text = "Computador Local";
            this.cbLocalhost.UseVisualStyleBackColor = true;
            this.cbLocalhost.CheckedChanged += new System.EventHandler(this.cbLocalhost_CheckedChanged);
            // 
            // tbIp
            // 
            this.tbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIp.Location = new System.Drawing.Point(69, 19);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(214, 26);
            this.tbIp.TabIndex = 95;
            // 
            // ofdBanco
            // 
            this.ofdBanco.FileName = "DBMANAGER";
            this.ofdBanco.Filter = "Bando de Dados Firebird (*.GDB)|";
            // 
            // btSincronizacao
            // 
            this.btSincronizacao.Location = new System.Drawing.Point(332, 179);
            this.btSincronizacao.Name = "btSincronizacao";
            this.btSincronizacao.Size = new System.Drawing.Size(129, 56);
            this.btSincronizacao.TabIndex = 100;
            this.btSincronizacao.Text = "realizar sincronização";
            this.btSincronizacao.UseVisualStyleBackColor = true;
            this.btSincronizacao.Visible = false;
            this.btSincronizacao.Click += new System.EventHandler(this.btSincronizacao_Click);
            // 
            // frConfigBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 330);
            this.Controls.Add(this.btSincronizacao);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.bSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCaminho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLocalhost);
            this.Controls.Add(this.tbIp);
            this.Name = "frConfigBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frConfigBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.Button bSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCaminho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbLocalhost;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.OpenFileDialog ofdBanco;
        private System.Windows.Forms.Button btSincronizacao;
    }
}