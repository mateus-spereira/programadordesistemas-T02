using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Matrizes
{
    public partial class FrmMatrizes : Form
    {
        public FrmMatrizes()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            matrizes = new int[2, 2];

            DtgMatriz.ColumnCount = 2;
            DtgMatriz.RowCount = 2;
            dtgTransposta.ColumnCount = 2;
            dtgTransposta.RowCount = 2;
                
            for (int fila = 0; fila < 2; fila++)
            {

                for (int coluna = 0; coluna < 2; coluna++)
                {
                    matrizes[fila, coluna] = int.Parse(Interaction.InputBox("Entrada de Dados"));
                }
            }

            for (int fila = 0; fila < 2; fila++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    DtgMatriz.Rows[fila].Cells[coluna].Value = matrizes[fila, coluna];
                }
            }
        }

        int[,] matrizes;
        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int fila = 0; fila < 2; fila++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    dtgTransposta.Rows[fila].Cells[coluna].Value = matrizes[coluna, fila];
                
                }

            }

        }

        
    }
}
