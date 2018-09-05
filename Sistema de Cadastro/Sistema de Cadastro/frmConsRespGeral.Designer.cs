namespace Sistema_de_Cadastro
{
    partial class frmConsRespGeral
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
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.dgvResponsavel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(278, 38);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(229, 20);
            this.txtconsulta.TabIndex = 0;
            this.txtconsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtconsulta_KeyUp);
            // 
            // dgvResponsavel
            // 
            this.dgvResponsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsavel.Location = new System.Drawing.Point(16, 89);
            this.dgvResponsavel.Name = "dgvResponsavel";
            this.dgvResponsavel.Size = new System.Drawing.Size(596, 196);
            this.dgvResponsavel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o Nome do Responsável:";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(513, 38);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(99, 23);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frmConsRespGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 321);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResponsavel);
            this.Controls.Add(this.txtconsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmConsRespGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsRespGeral";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.DataGridView dgvResponsavel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlimpar;
    }
}