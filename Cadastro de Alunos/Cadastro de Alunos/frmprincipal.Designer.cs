namespace Cadastro_de_Alunos
{
    partial class frmprincipal
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
            this.mnprincipal = new System.Windows.Forms.MenuStrip();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsávelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnprincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnprincipal
            // 
            this.mnprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.responsávelToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mnprincipal.Location = new System.Drawing.Point(0, 0);
            this.mnprincipal.Name = "mnprincipal";
            this.mnprincipal.Size = new System.Drawing.Size(284, 24);
            this.mnprincipal.TabIndex = 0;
            this.mnprincipal.Text = "menuStrip1";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.alterarToolStripMenuItem});
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // responsávelToolStripMenuItem
            // 
            this.responsávelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.excluirToolStripMenuItem1,
            this.alterarToolStripMenuItem1,
            this.conToolStripMenuItem});
            this.responsávelToolStripMenuItem.Name = "responsávelToolStripMenuItem";
            this.responsávelToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.responsávelToolStripMenuItem.Text = "Responsável";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            // 
            // excluirToolStripMenuItem1
            // 
            this.excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
            this.excluirToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.excluirToolStripMenuItem1.Text = "Consultar";
            // 
            // alterarToolStripMenuItem1
            // 
            this.alterarToolStripMenuItem1.Name = "alterarToolStripMenuItem1";
            this.alterarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.alterarToolStripMenuItem1.Text = "Excluir";
            // 
            // conToolStripMenuItem
            // 
            this.conToolStripMenuItem.Name = "conToolStripMenuItem";
            this.conToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.conToolStripMenuItem.Text = "Alterar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.mnprincipal);
            this.MainMenuStrip = this.mnprincipal;
            this.Name = "frmprincipal";
            this.Text = "Cadastro de Alunos";
            this.mnprincipal.ResumeLayout(false);
            this.mnprincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnprincipal;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsávelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem conToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

