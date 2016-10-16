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
    public partial class frConfigBase : Form
    {
        ConFirebird conFb;

        public frConfigBase()
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
                    MessageBox.Show("É preciso selecionar um arquivo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (tbCaminhoArquivo.TextLength > 4)
                {
                    txt = ".TXT";
                    caminhoTxt = tbCaminhoArquivo.Text.Substring(tbCaminhoArquivo.TextLength - 4);

                    if (!txt.Equals(caminhoTxt, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("É preciso selecionar um arquivo válido.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }


            return true;
        }

        /*
         * PASSO 1
         */ 
        private void btBackup_Click(object sender, EventArgs e)
        {
            backup();
            mostraEscondePassos(2);
        }

        /*
         * PASSO 2
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
                        mostraEscondePassos(3);

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
         * PASSO 3
         */ 
        private void btProcurarArquivo_Click(object sender, EventArgs e)
        {
            if (ofdArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbCaminhoArquivo.Text = ofdArquivo.FileName;
            }
        }

        /*
         * PASSO 4
         */ 
        private void btCarregarArquivo_Click(object sender, EventArgs e)
        {
            if (camposObrigatorios(2))
            {
                MessageBox.Show("Arquivo Carregado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mostraEscondePassos(4);
            }
        }

        /*
         * PASSO 3
         */ 
        private void btSincronizacao_Click(object sender, EventArgs e)
        {
            string sql = leArquivo(tbCaminhoArquivo.Text);

            ComandoSql.ComandoFb(sql);

            MessageBox.Show("Base de dados Atualizada!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mostraEscondePassos(1);
            limpaCampos();
        }

        private void mostraEscondePassos(int passo)
        {
            switch (passo)
            {
                case 1:
                    btBackup.Visible = true;
                    lPasso1.Visible = true;

                    gbConectarBanco.Visible = false;
                    lPasso2.Visible = false;
                    btConectarBanco.Visible = false;

                    gbCarregarArquivo.Visible = false;
                    lPasso3.Visible = false;
                    btCarregarArquivo.Visible = false;

                    lPasso4.Visible = false;
                    btSincronizacao.Visible = false;

                    break;
                case 2 :
                    btBackup.Visible = false;
                    lPasso1.Visible = false;

                    gbConectarBanco.Visible = true;
                    lPasso2.Visible = true;
                    btConectarBanco.Visible = true;

                    gbCarregarArquivo.Visible = false;
                    lPasso3.Visible = false;
                    btCarregarArquivo.Visible = false;

                    lPasso4.Visible = false;
                    btSincronizacao.Visible = false;
                    
                    break;
                case 3 :
                    btBackup.Visible = false;
                    lPasso1.Visible = false;
                    gbConectarBanco.Visible = false;
                    lPasso2.Visible = false;
                    btConectarBanco.Visible = false;

                    gbCarregarArquivo.Visible = true;
                    lPasso3.Visible = true;
                    btCarregarArquivo.Visible = true;

                    lPasso4.Visible = false;
                    btSincronizacao.Visible = false;
                    break;

                case 4 :
                    btBackup.Visible = false;
                    lPasso1.Visible = false;
                    gbConectarBanco.Visible = false;
                    lPasso2.Visible = false;
                    btConectarBanco.Visible = false;

                    gbCarregarArquivo.Visible = false;
                    lPasso3.Visible = false;
                    btCarregarArquivo.Visible = false;

                    lPasso4.Visible = true;
                    btSincronizacao.Visible = true;

                    break;
            } 
        }

        private void limpaCampos()
        {
            tbIp.Clear();
            tbCaminhoBanco.Clear();

            tbCaminhoArquivo.Clear();

        }

        private void backup()
        {

            MessageBox.Show("Para efetuar o backup é necessário estar no mesmo computador aonde se encontra a base de dados.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Software GT Manager Base|*.GDB";
            saveFileDialog1.Title = "Save Backup Database";
            saveFileDialog1.FileName = "Backup " + DateTime.Today.ToString().Replace('/', '-').Substring(0, 10);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.
                    string conexao = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
                    string[] file_backup_local = conexao.Split('=');
                    string[] file_backup_local_aux = file_backup_local[2].Split(';');
                    File.Copy(file_backup_local_aux[0].ToString(), saveFileDialog1.FileName.ToString());

                    MessageBox.Show("Backup salvo com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private string leArquivo(string arquivo)
        {
            string mensagem;
            string mensagemTexto = "";

            using (StreamReader texto = new StreamReader(arquivo))
            {
                while ((mensagem = texto.ReadLine()) != null)
                {
                    mensagemTexto += mensagem + " ";
                }
            }

            return mensagemTexto;
        }

        

    }
}


