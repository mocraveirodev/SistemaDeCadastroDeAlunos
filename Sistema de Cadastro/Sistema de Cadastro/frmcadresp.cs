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
    public partial class frmcadresp : Form
    {
        public frmcadresp()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        string strCon = @"Password=adminsql;Persist Security Info=True;User ID=sa;Initial Catalog=Anhanguera;Data Source=LAB5-24\SQLEXPRESS";
        string strSql =string.Empty;

        private void btnsalvar_Click_1(object sender, EventArgs e)
        {

            strSql = "INSERT INTO tb_responsavel(cpf_resp,nome,cel) VALUES(@cpf_resp, @nome, @cel )";
            //cria a conexão com o banco de dados
            sqlCon = new SqlConnection(strCon);
            //Cria o comando que executa a instrução sql
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@cpf_resp", SqlDbType.VarChar).Value = txtcpf.Text;
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtnome.Text;
            comando.Parameters.Add("@cel", SqlDbType.VarChar).Value = txtcel.Text;
            try
            {
                // abre o banco
                sqlCon.Open();
                // executa a instrução
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado");
            }
            //Trata a exceção
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //fecha a conexao 
                sqlCon.Close();
            }

        }
    }
}
