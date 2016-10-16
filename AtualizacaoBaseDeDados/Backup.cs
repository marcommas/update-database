using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtualizacaoBaseDeDados
{
    class Backup
    {
        public bool backup(string caminho)
        {
            MessageBox.Show("Para efetuar o backup é necessário estar no mesmo computador aonde se encontra a base de dados.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SaveFileDialog saveDatabase = new SaveFileDialog();
            saveDatabase.Filter = ".GDB|";
            saveDatabase.Title = "";
            saveDatabase.FileName = "Backup Genialtec " + Regex.Replace(DateTime.Now.ToString(), "[/:]", "-") +".GDB";

            if (saveDatabase.ShowDialog() == DialogResult.OK)
            {
                if (saveDatabase.FileName != "")
                {
                    File.Copy(caminho, saveDatabase.FileName.ToString());

                    MessageBox.Show("Backup salvo com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }else 
            {
                return false;
            }

            return false;

        }
    }
}
