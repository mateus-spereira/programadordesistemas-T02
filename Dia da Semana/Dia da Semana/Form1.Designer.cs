namespace Dia_da_Semana
{
    partial class Form1
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
            this.lblPergunta = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.btnResposta = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(275, 76);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(212, 25);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "Digite um Número";
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(263, 128);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(224, 33);
            this.txtResposta.TabIndex = 1;
            this.txtResposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResposta_KeyPress);
            // 
            // btnResposta
            // 
            this.btnResposta.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResposta.Location = new System.Drawing.Point(318, 182);
            this.btnResposta.Name = "btnResposta";
            this.btnResposta.Size = new System.Drawing.Size(110, 41);
            this.btnResposta.TabIndex = 2;
            this.btnResposta.TabStop = false;
            this.btnResposta.Text = "Enviar";
            this.btnResposta.UseVisualStyleBackColor = true;
            this.btnResposta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnResposta_MouseClick);
            // 
            // lblDia
            // 
            this.lblDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDia.Location = new System.Drawing.Point(318, 289);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(100, 23);
            this.lblDia.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.btnResposta);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lblPergunta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button btnResposta;
        private System.Windows.Forms.Label lblDia;
    }
}

