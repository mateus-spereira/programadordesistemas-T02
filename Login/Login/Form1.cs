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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = "TX";
            string pass = "1234";

            if (textUser.Text == string.Empty || textPass.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos para continuar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textUser.Text == user && textPass.Text == pass)
            {
                MessageBox.Show("Credenciais válidas!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Credenciais inválidas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
