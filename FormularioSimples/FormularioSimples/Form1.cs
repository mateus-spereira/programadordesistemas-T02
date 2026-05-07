using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using MySqlX.XDevAPI;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FormularioSimples
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_formulariosimples";

        private int? id_cliente = null;

        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDadosComFiltro();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void CarregarDadosComFiltro(string filtro = "")
        {
            try
            {
                using (Conexao = new MySqlConnection(data_source))
                {
                    Conexao.Open();

                    string sql = @"SELECT id, Nome, NumeroCadastro, DatadeNascimento, Estado, Genero 
                                   FROM formulariosimples";

                    if (!string.IsNullOrEmpty(filtro))
                    {
                        sql += @" WHERE LOWER(Nome) LIKE LOWER(@filtro) OR LOWER(NumeroCadastro) LIKE LOWER(@filtro)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, Conexao))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                        {
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);

                        dataGridView1.DataSource = tabela;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                string genero = "";

                if (rbMasculino.Checked) genero = "Masculino";
                else if (rbFeminino.Checked) genero = "Feminino";
                else if (rbOutro.Checked) genero = "Outro";

                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtNumeroCadastrado.Text.Trim()) ||
                    string.IsNullOrEmpty(cbEstado.Text.Trim()) ||
                    string.IsNullOrEmpty(genero))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.");
                    return;
                }

                using (Conexao = new MySqlConnection(data_source))
                {
                    Conexao.Open();

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = Conexao;

                        if (id_cliente == null)
                        {
                            // INSERT
                            cmd.CommandText = @"INSERT INTO formulariosimples
                                (Nome, NumeroCadastro, DatadeNascimento, Estado, Genero)
                                VALUES (@Nome, @Numero, @Data, @Estado, @Genero)";
                        }
                        else
                        {
                            // UPDATE
                            cmd.CommandText = @"UPDATE formulariosimples SET
                                Nome = @Nome,
                                NumeroCadastro = @Numero,
                                DatadeNascimento = @Data,
                                Estado = @Estado,
                                Genero = @Genero
                                WHERE id = @id";

                            cmd.Parameters.AddWithValue("@id", id_cliente);
                        }

                        cmd.Parameters.AddWithValue("@Nome", txtNomeCompleto.Text.Trim());
                        cmd.Parameters.AddWithValue("@Numero", txtNumeroCadastrado.Text.Trim());
                        cmd.Parameters.AddWithValue("@Data", DTDatadeNascimento.Value);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.Text.Trim());
                        cmd.Parameters.AddWithValue("@Genero", genero);

                        cmd.ExecuteNonQuery();

                        btnCadastro.Text = "Cadastrar";

                        MessageBox.Show("Dados salvos com sucesso!");
                    }
                }

                id_cliente = null;

                // Limpar campos
                txtNomeCompleto.Clear();
                txtNumeroCadastrado.Clear();
                cbEstado.Text = "";

                // Atualizar grid
                CarregarDadosComFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Pegando o ID do registro selecionado
                    id_cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                    // Preenchendo os campos
                    txtNomeCompleto.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                    txtNumeroCadastrado.Text = dataGridView1.CurrentRow.Cells["NumeroCadastro"].Value.ToString();

                    cbEstado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();

                    DTDatadeNascimento.Value =
                        Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DatadeNascimento"].Value);

                    string genero = dataGridView1.CurrentRow.Cells["Genero"].Value.ToString();

                    btnCadastro.Text = "Atualizar";

                    // Marcando RadioButton
                    rbMasculino.Checked = genero == "Masculino";
                    rbFeminino.Checked = genero == "Feminino";
                    rbOutro.Checked = genero == "Outro";

                    MessageBox.Show("Dados carregados para edição.");
                }
                else
                {
                    MessageBox.Show("Registro não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
        
                
        private void txtpesquisa_TextChanged_1(object sender, EventArgs e)
        {
            CarregarDadosComFiltro(txtpesquisa.Text.Trim());
        }
    }
}