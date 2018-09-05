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
    public partial class frmAltResp : Form
    {
        public frmAltResp()
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
            txtcpf.Focus();
            btnalterar.Enabled = false;
        }


        void ConsultaResp()
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
                btnalterar.Enabled = true;
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


        void alterarResp()
        {
            strSql = "update tb_responsavel set cpf_resp=@cpf, nome= @nome,cel=@telefone where cpf_resp=@cpfbusca";
            //cria a conexão com o banco de dados
            sqlCon = new SqlConnection(strCon);
            //Cria o comando que executa a instrução sql
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@cpfbusca", SqlDbType.VarChar).Value = txtcpf.Text;
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtnome.Text;
            comando.Parameters.Add("@telefone", SqlDbType.Int).Value = txtcel.Text;
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtcpf.Text;

            try
            {
                // abre o banco
                sqlCon.Open();
                // executa a instrução
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro atualizado com sucesso!!!");
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


        #endregion




        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparControles();

        }

        private void btnlocalizar_Click(object sender, EventArgs e)
        {
            ConsultaResp();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            alterarResp();

            
        }

    
   
    }
}
