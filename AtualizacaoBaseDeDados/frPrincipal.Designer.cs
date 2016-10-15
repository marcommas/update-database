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
            this.btConectarBanco = new System.Windows.Forms.Button();
            this.btSincronizacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConectarBanco
            // 
            this.btConectarBanco.Location = new System.Drawing.Point(80, 98);
            this.btConectarBanco.Name = "btConectarBanco";
            this.btConectarBanco.Size = new System.Drawing.Size(132, 56);
            this.btConectarBanco.TabIndex = 0;
            this.btConectarBanco.Text = "conectar banco";
            this.btConectarBanco.UseVisualStyleBackColor = true;
            this.btConectarBanco.Click += new System.EventHandler(this.btConectarBanco_Click);
            // 
            // btSincronizacao
            // 
            this.btSincronizacao.Location = new System.Drawing.Point(328, 98);
            this.btSincronizacao.Name = "btSincronizacao";
            this.btSincronizacao.Size = new System.Drawing.Size(129, 56);
            this.btSincronizacao.TabIndex = 1;
            this.btSincronizacao.Text = "realizar sincronização";
            this.btSincronizacao.UseVisualStyleBackColor = true;
            this.btSincronizacao.Visible = false;
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 261);
            this.Controls.Add(this.btSincronizacao);
            this.Controls.Add(this.btConectarBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConectarBanco;
        private System.Windows.Forms.Button btSincronizacao;
    }
}

