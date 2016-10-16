using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AtualizacaoBaseDeDados
{
    public partial class frPrincipal : Form
    {
        ConFirebird conFb;

        public frPrincipal()
        {
            InitializeComponent();
            mostraEscondePassos(1);
            conFb = new ConFirebird();
        }

        private bool camposObrigatorios(int passoObrigatorio)
        {
            if (passoObrigatorio == 1)
            {
                string gdb = "", caminhoGdb = "";

                if (tbIp.Text == "")
                {
                    MessageBox.Show("É preciso definir o IP.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (tbCaminhoBanco.Text == "")
                {
                    MessageBox.Show("É preciso selecionar uma base de dados.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (tbCaminhoBanco.TextLength > 4)
                {
                    gdb = ".GDB";
                    caminhoGdb = tbCaminhoBanco.Text.Substring(tbCaminhoBanco.TextLength - 4);

                    if (!gdb.Equals(caminhoGdb, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("É preciso selecionar uma base de dados válida.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                
            }
            else if (passoObrigatorio == 2)
            {
                string txt = "", caminhoTxt = "";

                if (tbCaminhoArquivo.Text == "")
                {
                    MessageBox.Show("É preciso selecionar um script.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (tbCaminhoArquivo.TextLength > 4)
                {
                    txt = ".SQL";
                    caminhoTxt = tbCaminhoArquivo.Text.Substring(tbCaminhoArquivo.TextLength - 4);

                    if (!txt.Equals(caminhoTxt, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("É preciso selecionar um script válido.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }


            return true;
        }

         /*
         * PASSO 1
         */ 
        private void btConectarBanco_Click(object sender, EventArgs e)
        {
            if (camposObrigatorios(1))
            {
                FbConnection conAux = new FbConnection("User=SYSDBA; Password=masterkey; Database=" + tbCaminhoBanco.Text + "; server=" + tbIp.Text + ";");

                try
                {
                    conAux.Open();
                    if (conAux.State == ConnectionState.Open)
                    {
                        conFb.ArrumarConexao(tbIp.Text, tbCaminhoBanco.Text);
                        conAux.Close();

                        MessageBox.Show("Base de dados conectada!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostraEscondePassos(2);

                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Não foi possível estabelecer uma conexão com os dados fornecidos!\n\nDetalhes do erro:\n" + ee.Message.ToString(), "Atenção!");
                    return;
                }
            }
        }


        private void btProcurar_Click(object sender, EventArgs e)
        {
            if (ofdBanco.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbCaminhoBanco.Text = ofdBanco.FileName;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    //AQUI VAI OS COMAMNDO PARA QUANDO SE FECHA O APLICATIVO
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Application.Exit();
                    break;
            }

            base.OnFormClosing(e);
        }

        private void cbLocalhost_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLocalhost.Checked == false)
            {
                tbIp.Enabled = true;
                tbIp.Text = String.Empty;
            }
            else if (cbLocalhost.Checked == true)
            {
                tbIp.Enabled = false;
                tbIp.Text = "localhost";
            }
        }

        /*
         * PASSO 2
         */
        private void btBackup_Click(object sender, EventArgs e)
        {
            bool realizouBackup = false;
            Backup back = new Backup();
            realizouBackup = back.backup(tbCaminhoBanco.Text);

            if (realizouBackup)
            {
                mostraEscondePassos(3);
            }

        }

        /*
         * PASSO 3
         */ 
        private void btProcurarArquivo_Click(object sender, EventArgs e)
        {
            if (ofdScript.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbCaminhoArquivo.Text = ofdScript.FileName;
            }
        }

        private void btCarregarArquivo_Click(object sender, EventArgs e)
        {
            if (camposObrigatorios(2))
            {
                MessageBox.Show("Arquivo Carregado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mostraEscondePassos(4);
            }
        }

        /*
         * PASSO 4
         */ 
        private void btSincronizacao_Click(object sender, EventArgs e)
        {
            leImportaArquivo(tbCaminhoArquivo.Text);

            MessageBox.Show("Base de dados Atualizada!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void mostraEscondePassos(int passo)
        {
            switch (passo)
            {
                case 1:
                    gb.Visible = true;
                    lPasso1.Visible = true;
                    btConectarBanco.Visible = true;
                    lIp.Visible = true;
                    tbIp.Visible = true;
                    cbLocalhost.Visible = true;
                    lLocal.Visible = true;
                    tbCaminhoBanco.Visible = true;
                    btProcurarBase.Visible = true;

                    btBackup.Visible = false;
                    lPasso2.Visible = false;

                    lPasso3.Visible = false;
                    btCarregarArquivo.Visible = false;

                    lPasso4.Visible = false;
                    btSincronizacao.Visible = false;

                    break;
                case 2 :
                    gb.Visible = false;
                    lPasso1.Visible = false;
                    btConectarBanco.Visible = false;

                    btBackup.Visible = true;
                    lPasso2.Visible = true;

                    tbCaminhoArquivo.Visible = false;
                    btProcurarArquivo.Visible = false;
                    lPasso3.Visible = false;
                    btCarregarArquivo.Visible = false;

                    lPasso4.Visible = false;
                    btSincronizacao.Visible = false;
                    
                    break;
                case 3 :
                    lPasso1.Visible = false;
                    lIp.Visible = false;
                    tbIp.Visible = false;
                    cbLocalhost.Visible = false;
                    lLocal.Visible = false;
                    tbCaminhoBanco.Visible = false;
                    btProcurarBase.Visible = false;
                    btConectarBanco.Visible = false;

                    lPasso2.Visible = false;
                    btBackup.Visible = false;

                    gb.Visible = true;
                    gb.Text = "Carregar Arquivo";
                    tbCaminhoArquivo.Visible = true;
                    btProcurarArquivo.Visible = true;
                    lPasso3.Visible = true;
                    btCarregarArquivo.Visible = true;

                    lPasso4.Visible = false;
                    btSincronizacao.Visible = false;
                    break;

                case 4 :
                    btBackup.Visible = false;
                    lPasso1.Visible = false;
                    gb.Visible = false;
                    lPasso2.Visible = false;
                    btConectarBanco.Visible = false;

                    tbCaminhoArquivo.Visible = false;
                    btProcurarArquivo.Visible = false;
                    lPasso3.Visible = false;
                    btCarregarArquivo.Visible = false;

                    lPasso4.Visible = true;
                    btSincronizacao.Visible = true;

                    break;
            } 
        }

        private void limpaCampos()
        {
            //tbIp.Clear();
            tbCaminhoBanco.Clear();

            tbCaminhoArquivo.Clear();

        }

        private void leImportaArquivo(string arquivo)
        {
            string sql;

            using (StreamReader texto = new StreamReader(arquivo))
            {
                while ((sql = texto.ReadLine()) != null)
                {
                    ComandoSql.ExecImpSQL(sql);
                }
            }
        }

        private void btSobre_Click(object sender, EventArgs e)
        {
            frSobre sobre = new frSobre();
            sobre.Show();
        }

        

    }
}


