using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoADadosWin
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuVerEmpregados_Click(object sender, EventArgs e)
        {
            frmEmpregados f = new frmEmpregados();
            f.ShowDialog();
        }

        private void mnuPesquisarProdutos_Click(object sender, EventArgs e)
        {
            frmCategoriasProdutos f = new frmCategoriasProdutos();
            f.ShowDialog();
        }

        private void mnuAtualizarEmpregados_Click(object sender, EventArgs e)
        {
            frmAtualizaEmpregado f = new frmAtualizaEmpregado();
            f.ShowDialog();
        }

        private void mnuAtualizarCategorias_Click(object sender, EventArgs e)
        {
            frmAtualizaCategoria f = new frmAtualizaCategoria();
            f.ShowDialog();
        }
    }
}
