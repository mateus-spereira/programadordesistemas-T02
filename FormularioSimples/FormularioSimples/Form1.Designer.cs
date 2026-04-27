namespace FormularioSimples
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
            this.gpboxGenero = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtNumeroCadastrado = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTDatadeNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDatadeNascimento = new System.Windows.Forms.Label();
            this.gpboxGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxGenero
            // 
            this.gpboxGenero.Controls.Add(this.rbOutro);
            this.gpboxGenero.Controls.Add(this.rbMasculino);
            this.gpboxGenero.Controls.Add(this.rbFeminino);
            this.gpboxGenero.Location = new System.Drawing.Point(45, 290);
            this.gpboxGenero.Name = "gpboxGenero";
            this.gpboxGenero.Size = new System.Drawing.Size(121, 114);
            this.gpboxGenero.TabIndex = 0;
            this.gpboxGenero.TabStop = false;
            this.gpboxGenero.Text = "Gênero";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(11, 31);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 0;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(11, 54);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.Location = new System.Drawing.Point(11, 77);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(51, 17);
            this.rbOutro.TabIndex = 2;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Salvador",
            "Florianópolis",
            "Amazonas",
            "Mato Grosso"});
            this.cbEstado.Location = new System.Drawing.Point(45, 236);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 1;
            // 
            // txtNumeroCadastrado
            // 
            this.txtNumeroCadastrado.Location = new System.Drawing.Point(45, 50);
            this.txtNumeroCadastrado.Name = "txtNumeroCadastrado";
            this.txtNumeroCadastrado.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroCadastrado.TabIndex = 2;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(45, 109);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(121, 20);
            this.txtNomeCompleto.TabIndex = 3;
            this.txtNomeCompleto.Text = "Insira o nome completo";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(56, 453);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(89, 23);
            this.btnCadastro.TabIndex = 4;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número Cadastro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado:";
            // 
            // DTDatadeNascimento
            // 
            this.DTDatadeNascimento.Location = new System.Drawing.Point(45, 174);
            this.DTDatadeNascimento.Name = "DTDatadeNascimento";
            this.DTDatadeNascimento.Size = new System.Drawing.Size(121, 20);
            this.DTDatadeNascimento.TabIndex = 8;
            // 
            // lblDatadeNascimento
            // 
            this.lblDatadeNascimento.AutoSize = true;
            this.lblDatadeNascimento.Location = new System.Drawing.Point(42, 158);
            this.lblDatadeNascimento.Name = "lblDatadeNascimento";
            this.lblDatadeNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDatadeNascimento.TabIndex = 9;
            this.lblDatadeNascimento.Text = "Data de Nascimento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 508);
            this.Controls.Add(this.lblDatadeNascimento);
            this.Controls.Add(this.DTDatadeNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.txtNumeroCadastrado);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.gpboxGenero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpboxGenero.ResumeLayout(false);
            this.gpboxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxGenero;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtNumeroCadastrado;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTDatadeNascimento;
        private System.Windows.Forms.Label lblDatadeNascimento;
    }
}

