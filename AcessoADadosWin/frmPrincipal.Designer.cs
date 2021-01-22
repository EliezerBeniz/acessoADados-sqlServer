namespace AcessoADadosWin
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empregadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerEmpregados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAtualizarEmpregados = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPesquisarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAtualizarCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empregadosToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empregadosToolStripMenuItem
            // 
            this.empregadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVerEmpregados,
            this.mnuAtualizarEmpregados});
            this.empregadosToolStripMenuItem.Name = "empregadosToolStripMenuItem";
            this.empregadosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.empregadosToolStripMenuItem.Text = "Empregados";
            // 
            // mnuVerEmpregados
            // 
            this.mnuVerEmpregados.Name = "mnuVerEmpregados";
            this.mnuVerEmpregados.Size = new System.Drawing.Size(152, 22);
            this.mnuVerEmpregados.Text = "Ver";
            this.mnuVerEmpregados.Click += new System.EventHandler(this.mnuVerEmpregados_Click);
            // 
            // mnuAtualizarEmpregados
            // 
            this.mnuAtualizarEmpregados.Name = "mnuAtualizarEmpregados";
            this.mnuAtualizarEmpregados.Size = new System.Drawing.Size(152, 22);
            this.mnuAtualizarEmpregados.Text = "Atualizar";
            this.mnuAtualizarEmpregados.Click += new System.EventHandler(this.mnuAtualizarEmpregados_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPesquisarProdutos,
            this.mnuAtualizarCategorias});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.produtosToolStripMenuItem.Text = "Produtos | Categorias";
            // 
            // mnuPesquisarProdutos
            // 
            this.mnuPesquisarProdutos.Name = "mnuPesquisarProdutos";
            this.mnuPesquisarProdutos.Size = new System.Drawing.Size(179, 22);
            this.mnuPesquisarProdutos.Text = "Pesquisar";
            this.mnuPesquisarProdutos.Click += new System.EventHandler(this.mnuPesquisarProdutos_Click);
            // 
            // mnuAtualizarCategorias
            // 
            this.mnuAtualizarCategorias.Name = "mnuAtualizarCategorias";
            this.mnuAtualizarCategorias.Size = new System.Drawing.Size(179, 22);
            this.mnuAtualizarCategorias.Text = "Atualizar Categorias";
            this.mnuAtualizarCategorias.Click += new System.EventHandler(this.mnuAtualizarCategorias_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 428);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empregadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuVerEmpregados;
        private System.Windows.Forms.ToolStripMenuItem mnuAtualizarEmpregados;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPesquisarProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnuAtualizarCategorias;
    }
}