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
    public partial class frmExcResp : Form
    {
        public frmExcResp()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        string strCon = @"Password=adminsql;Persist Security Info=True;User ID=sa;Initial Catalog=Anhanguera;Data Source=LAB5-24\SQLEXPRESS";
        string strSql = string.Empty;

       void Consulta_Responsavel()
        {
            strSql = " select * from tb_responsavel where cpf_resp =@cpf";
            //cria a conexão com o banco de dados
            sqlCon = new SqlConnection(strCon);
            //Cria o comando que executa a instrução sql
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtcpf.Text;
            try
            {

                if (txtcpf.Text == string.Empty)
                {
                    throw new Exception("Você precisa digitar um CPF!!!");
                }
                // abre o banco
                sqlCon.Open();
                // executa a instrução
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("CPF não cadastrado!!!");
                }
                dr.Read();

                txtnome.Text = Convert.ToString(dr["nome"]);
                txtcel.Text = Convert.ToString(dr["cel"]);
                btnExcluir.Enabled = true;
            }
            //Trata a exceção
            catch (Exception ex)
            {
                // MessageBox.Show("Não encontrei");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //fecha a conexao 
                sqlCon.Close();

            }
        }

       void confirmaExcluirResp()
        {
            if (MessageBox.Show("Deseja realmente excluir este responsável?",
                "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!!!");
            }
            else
            {
                strSql = "Delete from tb_responsavel where cpf_resp= @cpf ";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtcpf.Text;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Responsável deletado com sucesso!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();

                }
            }
        }
         
  



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            confirmaExcluirResp();
        }

        private void btnlocalizar_Click(object sender, EventArgs e)
        {
            Consulta_Responsavel();
        }

        private void frmExcResp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Sair?", "Cuidado", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
