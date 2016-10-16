using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtualizacaoBaseDeDados
{
    public partial class frSobre : Form
    {
        public frSobre()
        {
            InitializeComponent();
            lAno.Text = DateTime.Today.Year.ToString();
            lb_inf.Text = "Atenção este programa é protegido por leis de direitos autorais e tratados internacionais. A reprodução ou a distribuição não autorizada deste programa, ou de qualquer parte do mesmo, pode resultar em penalidades civis e criminais severas, e será processada até a extensão máxima permitida por lei.";
     
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.genialtec.com.br");
        }
    }
}
