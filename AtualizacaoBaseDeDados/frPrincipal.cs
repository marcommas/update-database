﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtualizacaoBaseDeDados
{
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();
            MessageBox.Show("te");
        }

        private void btConectarBanco_Click(object sender, EventArgs e)
        {
            frConfigBase configBase = new frConfigBase();
            configBase.ShowDialog();
        }
    }
}
