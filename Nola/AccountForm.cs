﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nola
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'nolaDBDataSet2.viewAccountBalance'. Você pode movê-la ou removê-la conforme necessário.
            this.viewAccountBalanceTableAdapter.Fill(this.nolaDBDataSet2.viewAccountBalance);

        }
    }
}
