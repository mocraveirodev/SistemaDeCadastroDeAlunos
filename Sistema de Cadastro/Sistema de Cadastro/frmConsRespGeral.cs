using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_de_Cadastro
{
    public partial class frmConsRespGeral : Form
    {
        public frmConsRespGeral()
        {
            InitializeComponent();
        }


        SqlConnection sqlCon = null;
        string strCon = @"Password=adminsql;Persist Security Info=True;User ID=sa;Initial Catalog=Anhanguera;Data Source=LAB5-24\SQLEXPRESS";
        string strSql = string.Empty;
        SqlDataAdapter da = null;
        DataTable responsavel = null;

        private void Carregar(string SQLconsultageral)
        {
            try
            {
                sqlCon = new SqlConnection(strCon);
                da = new SqlDataAdapter(SQLconsultageral, sqlCon);
                responsavel = new DataTable();
                da.Fill(responsavel);
                responsavel.Columns[0].ColumnName = "CPF";
                responsavel.Columns[1].ColumnName = "Nome";
                responsavel.Columns[2].ColumnName = "Celular";
                dgvResponsavel.DataSource = responsavel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtconsulta_KeyUp(object sender, KeyEventArgs e)
        {
            string strSQL = " select cpf_resp,nome,cel from tb_responsavel where nome like '"
                + txtconsulta.Text + "%'";
            Carregar(strSQL);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtconsulta.Clear();
            txtconsulta.Focus();
            dgvResponsavel.DataSource = null;
        }

      

    }
}
