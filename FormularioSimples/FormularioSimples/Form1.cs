using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;



namespace FormularioSimples
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_formulariosimples";

        private int? codigo_cliente = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                string genero = "";

                if (rbMasculino.Checked)
                    genero = "Masculino";
                else if (rbFeminino.Checked)
                    genero = "Feminino";
                else if (rbOutro.Checked)
                    genero = "Outro";

                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtNumeroCadastrado.Text.Trim()) ||
                    string.IsNullOrEmpty(cbEstado.Text.Trim()) ||
                    string.IsNullOrEmpty(genero))

                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.",
                                    "Validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }


                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = Conexao;

                    if (codigo_cliente == null)
                    {

                        cmd.CommandText = @"INSERT INTO formulariosimples     
                        (Nome, NumeroCadastro, DatadeNascimento, Estado, Genero) 
                        VALUES (@NomeCompleto, @NumeroCadastrado, @DatadeNascimento, @Estado, @Genero)";
                        cmd.Parameters.Add("@NomeCompleto", MySqlDbType.VarChar).Value = txtNomeCompleto.Text.Trim();
                        cmd.Parameters.Add("@NumeroCadastrado", MySqlDbType.VarChar).Value = txtNumeroCadastrado.Text.Trim();
                        cmd.Parameters.Add("@DatadeNascimento", MySqlDbType.Date).Value = DTDatadeNascimento.Value;
                        cmd.Parameters.Add("@Estado", MySqlDbType.VarChar).Value = cbEstado.Text.Trim();
                        cmd.Parameters.Add("@Genero", MySqlDbType.VarChar).Value = genero;


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Contato inserido com Sucesso: ",
                                            "Sucesso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                    }

                    else
                    {
                        //update
                        cmd.CommandText = cmd.CommandText = @"UPDATE formulariosimples 
                        SET Nome = @NomeCompleto,
                        NumeroCadastro = @NumeroCadastrado,
                        DatadeNascimento = @DatadeNascimento,
                        Estado = @Estado
                        WHERE codigo = @codigo";

                        cmd.Parameters.Add("@codigo", MySqlDbType.Int32).Value = codigo_cliente;
                        cmd.Parameters.Add("@NomeCompleto", MySqlDbType.VarChar).Value = txtNomeCompleto.Text.Trim();
                        cmd.Parameters.Add("@NumeroCadastrado", MySqlDbType.VarChar).Value = txtNumeroCadastrado.Text.Trim();
                        cmd.Parameters.Add("@DatadeNascimento", MySqlDbType.Date).Value = DTDatadeNascimento.Value;
                        cmd.Parameters.Add("@Estado", MySqlDbType.VarChar).Value = cbEstado.Text.Trim();
                        cmd.Parameters.Add("@Genero", MySqlDbType.VarChar).Value = genero;

                        //Executa o comando de alteração no banco
                        cmd.ExecuteNonQuery();

                        //Mensagem de sucesso para dados atualizados 
                        MessageBox.Show($"Os dados com o códgio {codigo_cliente} foram alterados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    codigo_cliente = null;

                    //Limpa os campos após o sucesso
                    txtNomeCompleto.Text = string.Empty;
                    txtNumeroCadastrado.Text = "";
                    DTDatadeNascimento.Text = "";
                    cbEstado.Text = string.Empty;
                }

            }
            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro" + ex.Number + " ocorreu: " + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                // Trata outros tipos de erro 
                MessageBox.Show("Ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Garante que a conexão com o banco será fechada, mesmo se o ocorrer o erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }
    }
}
         