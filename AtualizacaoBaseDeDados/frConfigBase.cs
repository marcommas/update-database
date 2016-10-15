using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AtualizacaoBaseDeDados
{
    public partial class frConfigBase : Form
    {
        private DataTable dtSelect;
        private string sql;
        ConFirebird conFb;

        public frConfigBase()
        {

            InitializeComponent();
            conFb = new ConFirebird();
        }

        private bool camposObrigatorios()
        {
            if (tbIp.Text == "")
            {
                MessageBox.Show("É preciso definir o IP.");
                return false;
            }

            if (tbCaminho.Text == "")
            {
                MessageBox.Show("É preciso selecionar uma base de dados.");
                return false;
            }


            return true;
        }

        private void bSalvar_Click(object sender, EventArgs e)
        {
            if (camposObrigatorios())
            {

                FbConnection conAux = new FbConnection("User=SYSDBA; Password=masterkey; Database=" + tbCaminho.Text + "; server=" + tbIp.Text + ";");

                try
                {
                    conAux.Open();
                    if (conAux.State == ConnectionState.Open)
                    {
                        conFb.ArrumarConexao(tbIp.Text, tbCaminho.Text);
                        conAux.Close();

                        // this.Close();
                        //this.Dispose();
                        MessageBox.Show("Base de dados conectada!");
                        btSincronizacao.Visible = true;
                        // frOpcoesAvaliacaoCon opAvaliacao = new frOpcoesAvaliacaoCon(cd_usuario, dtNascimento, flSexo, fl_master);
                        // opAvaliacao.ShowDialog();
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
                tbCaminho.Text = ofdBanco.FileName;
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

        private void btSincronizacao_Click(object sender, EventArgs e)
        {
            sql = " CREATE TABLE CONFIGURACOESSS ( ";
            sql += " CD_CONFIGURACOESS SMALLINT, ";
            sql += " FL_TECLADO_NUMERICO_LOGIN CHAR(1), ";
            sql += " DT_ALTERACAO TIMESTAMP); ";

            ComandoSql.ComandoFb(sql);
        }


    }
}


