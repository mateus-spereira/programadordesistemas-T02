namespace Matrizes
{
    partial class FrmMatrizes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnTransposta = new System.Windows.Forms.Button();
            this.DtgMatriz = new System.Windows.Forms.DataGridView();
            this.dtgTransposta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransposta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(45, 127);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnTransposta
            // 
            this.btnTransposta.Location = new System.Drawing.Point(45, 218);
            this.btnTransposta.Name = "btnTransposta";
            this.btnTransposta.Size = new System.Drawing.Size(75, 23);
            this.btnTransposta.TabIndex = 1;
            this.btnTransposta.Text = "Transposta";
            this.btnTransposta.UseVisualStyleBackColor = true;
            this.btnTransposta.Click += new System.EventHandler(this.button2_Click);
            // 
            // DtgMatriz
            // 
            this.DtgMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgMatriz.Location = new System.Drawing.Point(189, 35);
            this.DtgMatriz.Name = "DtgMatriz";
            this.DtgMatriz.Size = new System.Drawing.Size(240, 150);
            this.DtgMatriz.TabIndex = 2;
            // 
            // dtgTransposta
            // 
            this.dtgTransposta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTransposta.Location = new System.Drawing.Point(189, 218);
            this.dtgTransposta.Name = "dtgTransposta";
            this.dtgTransposta.Size = new System.Drawing.Size(240, 150);
            this.dtgTransposta.TabIndex = 3;
            // 
            // FrmMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgTransposta);
            this.Controls.Add(this.DtgMatriz);
            this.Controls.Add(this.btnTransposta);
            this.Controls.Add(this.btnCarregar);
            this.Name = "FrmMatrizes";
            this.Text = "Trabalhando com Matriz";
            ((System.ComponentModel.ISupportInitialize)(this.DtgMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransposta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnTransposta;
        private System.Windows.Forms.DataGridView DtgMatriz;
        private System.Windows.Forms.DataGridView dtgTransposta;
    }
}

