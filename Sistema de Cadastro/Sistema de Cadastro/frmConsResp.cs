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
    public partial class frmConsResp : Form
    {
        public frmConsResp()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        string strCon = @"Password=adminsql;Persist Security Info=True;User ID=sa;Initial Catalog=Anhanguera;Data Source=LAB5-24\SQLEXPRESS";
        string strSql = string.Empty;
        
        #region Métodos do formulário
       
        void LimparControles()
        {
            txtcel.Clear();
            txtcpf.Clear();
            txtnome.Clear();
        }
        #endregion

        private void btnlocalizar_Click(object sender, EventArgs e)
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparControles();
            txtcpf.Focus();

        }

      

       
    }
}
