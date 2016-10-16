using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace AtualizacaoBaseDeDados
{
    class ComandoSql
    {

        //SELECT
        public static DataTable ComandoDT(string sql)
        {

            frPrincipal configBase = new frPrincipal();
            string conexao = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            FbConnection dbcon = new FbConnection(conexao);
            FbCommand cmdCad = new FbCommand(sql, dbcon);
            FbDataAdapter DA = new FbDataAdapter(cmdCad);
            DataTable dtTable = new DataTable();

            try
            {
                DA.Fill(dtTable);

            }
            catch (FbException)
            {
                MessageBox.Show("ERRO AO CONECTAR COM BANCO DE DADOS!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //aqui
                configBase.ShowDialog();
                Environment.Exit(0);
            }
            try
            {
                dbcon.Open();
                cmdCad.ExecuteNonQuery();
                dbcon.Close();
            }
            catch (FbException)
            {
                MessageBox.Show("ERRO AO CONECTAR COM BANCO DE DADOS!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.Close();
            }
            return dtTable;


        }

        //INSERT, UPDATE, DELETE
        public static void ComandoFb(string sql)
        {
            try
            {
                string conexao = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
                IDbConnection dbcon = new FbConnection(conexao);
                dbcon.Open();
                IDbCommand dbcmd = dbcon.CreateCommand();
                //string sql = "SELECT FIRST 1 CD_IMAGEM FROM IMAGENS ORDER BY CD_IMAGEM DESC;";
                dbcmd.CommandText = sql;
                IDataReader reader = dbcmd.ExecuteReader();
                while (reader.Read())
                {
                    object dataValue = reader.GetValue(0);
                    string sValue = dataValue.ToString();
                    //cd_imagem = sValue;
                }

                // clean up 
                reader.Close();
                reader = null;
                dbcmd.Dispose();
                dbcmd = null;
                dbcon.Close();
                dbcon = null;
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao executar script!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public static void ExecImpSQL(string SQL)
        {
            try
            {
                string conexao = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
                FbConnection dbcon = new FbConnection(conexao);
                FbCommand cmdCad = new FbCommand(SQL, dbcon);
                FbDataAdapter DA = new FbDataAdapter(cmdCad);

                dbcon.Open();
                cmdCad.ExecuteNonQuery();

                dbcon.Close();

            }
            catch (Exception )
            {
                MessageBox.Show("Erro ao executar script!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}