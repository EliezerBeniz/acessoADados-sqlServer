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
    public partial class frmCategoriasProdutos : Form
    {
        public frmCategoriasProdutos()
        {
            InitializeComponent();
        }

        bool flag = false;
        private void frmCategoriasProdutos_Load(object sender, EventArgs e) {
            cboCategorias.DataSource = Categorias.ListaTodas();
            cboCategorias.DisplayMember = "Nome";
            cboCategorias.ValueMember = "IdCategoria";

            flag = true;
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e) {
            if (flag) {
                dgvProdutos.DataSource = Categorias.ListaProdutos((int)cboCategorias.SelectedValue);
            }
                
        }
    }
}
