using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace AcessoADadosWin
{
    public partial class frmAtualizaEmpregado : Form
    {
        public frmAtualizaEmpregado()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNomeNovoEmpregado.Text != string.Empty)
            {
                Empregado novoEmpregado = new Empregado();
                novoEmpregado.FirstName = txtNomeNovoEmpregado.Text;
                novoEmpregado.LastName = txtApelidoNovoEmpregado.Text;
                novoEmpregado.DataNascimento = calDataNascimento.SelectionStart;

                if (novoEmpregado.Inserir())
                {
                    MessageBox.Show("Inserido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Houve um erro.");
                }
            }
        }
    }
}
