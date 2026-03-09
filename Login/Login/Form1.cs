using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        int tentativas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = "TX";
            string pass = "1234";

            if (txtUser.Text == string.Empty || txtPass.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos para continuar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtUser.Text == user && txtPass.Text == pass)
            {
                MessageBox.Show("Credenciais válidas!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tentativas = 0;
            }
            else
            {
                tentativas++;
                int tentativasRestantes = 3 - tentativas;

            if (tentativas >= 3)
            {
                    MessageBox.Show("Número máximo de tentativas excedido. Acesso bloqueado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEntrar.Enabled = false;
                    txtPass.Enabled = false;
                    txtUser.Enabled = false;
            }
                MessageBox.Show("Credenciais inválidas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
