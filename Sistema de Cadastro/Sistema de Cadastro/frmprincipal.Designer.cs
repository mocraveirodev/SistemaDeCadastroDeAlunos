namespace Sistema_de_Cadastro
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
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exclusãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsávelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alteraçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnprincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnprincipal
            // 
            this.mnprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.responsávelToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mnprincipal.Location = new System.Drawing.Point(0, 0);
            this.mnprincipal.Name = "mnprincipal";
            this.mnprincipal.Size = new System.Drawing.Size(434, 24);
            this.mnprincipal.TabIndex = 0;
            this.mnprincipal.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.alteraçãoToolStripMenuItem,
            this.exclusãoToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porAlunoToolStripMenuItem,
            this.porTurmaToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // porAlunoToolStripMenuItem
            // 
            this.porAlunoToolStripMenuItem.Name = "porAlunoToolStripMenuItem";
            this.porAlunoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.porAlunoToolStripMenuItem.Text = "Por Aluno";
            // 
            // porTurmaToolStripMenuItem
            // 
            this.porTurmaToolStripMenuItem.Name = "porTurmaToolStripMenuItem";
            this.porTurmaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.porTurmaToolStripMenuItem.Text = "Por Turma";
            // 
            // alteraçãoToolStripMenuItem
            // 
            this.alteraçãoToolStripMenuItem.Name = "alteraçãoToolStripMenuItem";
            this.alteraçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alteraçãoToolStripMenuItem.Text = "Alteração";
            // 
            // exclusãoToolStripMenuItem
            // 
            this.exclusãoToolStripMenuItem.Name = "exclusãoToolStripMenuItem";
            this.exclusãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exclusãoToolStripMenuItem.Text = "Exclusão";
            // 
            // responsávelToolStripMenuItem
            // 
            this.responsávelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1,
            this.consultaToolStripMenuItem1,
            this.alteraçãoToolStripMenuItem1,
            this.excluirToolStripMenuItem});
            this.responsávelToolStripMenuItem.Name = "responsávelToolStripMenuItem";
            this.responsávelToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.responsávelToolStripMenuItem.Text = "Responsável";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem});
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // alteraçãoToolStripMenuItem1
            // 
            this.alteraçãoToolStripMenuItem1.Name = "alteraçãoToolStripMenuItem1";
            this.alteraçãoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.alteraçãoToolStripMenuItem1.Text = "Alteração";
            this.alteraçãoToolStripMenuItem1.Click += new System.EventHandler(this.alteraçãoToolStripMenuItem1_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.geralToolStripMenuItem.Text = "Geral";
            this.geralToolStripMenuItem.Click += new System.EventHandler(this.geralToolStripMenuItem_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 200);
            this.Controls.Add(this.mnprincipal);
            this.MainMenuStrip = this.mnprincipal;
            this.Name = "frmprincipal";
            this.Text = "Controle de Alunos";
            this.mnprincipal.ResumeLayout(false);
            this.mnprincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnprincipal;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exclusãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsávelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alteraçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;

    }
}

