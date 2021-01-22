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
    public partial class frmEmpregados : Form
    {
        public frmEmpregados()
        {
            InitializeComponent();
        }

        bool flag = false;
        private void frmEmpregados_Load(object sender, EventArgs e)
        {
            cboEmpregados.DataSource = Empregados.ListaTodos();
            cboEmpregados.DisplayMember = "Name";
            cboEmpregados.ValueMember = "Id";

            flag = true;
        }

        private void cboEmpregados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                Empregado empregado = new Empregado((int)cboEmpregados.SelectedValue);

                lblNome.Text = empregado.FirstName;
                lblApelido.Text = empregado.LastName;
                lblDataNascimento.Text = empregado.DataNascimento.ToShortDateString();
            }
           
        }
    }
}
