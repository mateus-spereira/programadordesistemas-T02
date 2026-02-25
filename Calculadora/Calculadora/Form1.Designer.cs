namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnSubtracao = new Button();
            btnDividir = new Button();
            button1 = new Button();
            btnSoma = new Button();
            lblNumeroProduto = new Label();
            btnIgualA = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTrês = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btn0 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn0);
            groupBox1.Controls.Add(btnNove);
            groupBox1.Controls.Add(btnOito);
            groupBox1.Controls.Add(btnSete);
            groupBox1.Controls.Add(btnSeis);
            groupBox1.Controls.Add(btnCinco);
            groupBox1.Controls.Add(btnQuatro);
            groupBox1.Controls.Add(btnTrês);
            groupBox1.Controls.Add(btnDois);
            groupBox1.Controls.Add(btnUm);
            groupBox1.Controls.Add(btnIgualA);
            groupBox1.Controls.Add(btnSubtracao);
            groupBox1.Controls.Add(btnDividir);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnSoma);
            groupBox1.Controls.Add(lblNumeroProduto);
            groupBox1.Location = new Point(1, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 512);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.White;
            btnSubtracao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtracao.Location = new Point(424, 198);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(63, 62);
            btnSubtracao.TabIndex = 4;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += lblSubtrair;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.White;
            btnDividir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(424, 266);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(63, 62);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += lblDividir;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(424, 334);
            button1.Name = "button1";
            button1.Size = new Size(63, 62);
            button1.TabIndex = 2;
            button1.Text = "*";
            button1.UseVisualStyleBackColor = false;
            button1.Click += lblMultiplicar;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.White;
            btnSoma.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoma.Location = new Point(424, 130);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(63, 62);
            btnSoma.TabIndex = 1;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += lblSoma;
            // 
            // lblNumeroProduto
            // 
            lblNumeroProduto.AutoSize = true;
            lblNumeroProduto.Location = new Point(474, 37);
            lblNumeroProduto.Name = "lblNumeroProduto";
            lblNumeroProduto.Size = new Size(13, 15);
            lblNumeroProduto.TabIndex = 0;
            lblNumeroProduto.Text = "0";
            // 
            // btnIgualA
            // 
            btnIgualA.BackColor = Color.White;
            btnIgualA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgualA.Location = new Point(424, 402);
            btnIgualA.Name = "btnIgualA";
            btnIgualA.Size = new Size(63, 62);
            btnIgualA.TabIndex = 5;
            btnIgualA.Text = "=";
            btnIgualA.UseVisualStyleBackColor = false;
            btnIgualA.Click += this.btnIgualA;
            // 
            // btnUm
            // 
            btnUm.BackColor = Color.White;
            btnUm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUm.Location = new Point(86, 130);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(63, 62);
            btnUm.TabIndex = 6;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += this.btnUm;
            // 
            // btnDois
            // 
            btnDois.BackColor = Color.White;
            btnDois.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDois.Location = new Point(171, 130);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(63, 62);
            btnDois.TabIndex = 7;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += this.btnDois;
            // 
            // btnTrês
            // 
            btnTrês.BackColor = Color.White;
            btnTrês.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrês.Location = new Point(256, 130);
            btnTrês.Name = "btnTrês";
            btnTrês.Size = new Size(63, 62);
            btnTrês.TabIndex = 8;
            btnTrês.Text = "3";
            btnTrês.UseVisualStyleBackColor = false;
            btnTrês.Click += this.btnTres;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = Color.White;
            btnQuatro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuatro.Location = new Point(86, 222);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(63, 62);
            btnQuatro.TabIndex = 9;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += this.btnQuatro;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.White;
            btnCinco.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCinco.Location = new Point(171, 222);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(63, 62);
            btnCinco.TabIndex = 10;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += this.btnCinco;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.White;
            btnSeis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeis.Location = new Point(256, 222);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(63, 62);
            btnSeis.TabIndex = 11;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += this.btnSeis;
            // 
            // btnSete
            // 
            btnSete.BackColor = Color.White;
            btnSete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSete.Location = new Point(86, 308);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(63, 62);
            btnSete.TabIndex = 12;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += this.btnSete;
            // 
            // btnOito
            // 
            btnOito.BackColor = Color.White;
            btnOito.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOito.Location = new Point(171, 308);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(63, 62);
            btnOito.TabIndex = 13;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += this.btnOito;
            // 
            // btnNove
            // 
            btnNove.BackColor = Color.White;
            btnNove.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNove.Location = new Point(256, 308);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(63, 62);
            btnNove.TabIndex = 14;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(171, 402);
            btn0.Name = "btn0";
            btn0.Size = new Size(63, 62);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnZero;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(534, 511);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblNumeroProduto;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnDividir;
        private Button button1;
        private Button btn0;
        private Button btnNove;
        private Button btnOito;
        private Button btnSete;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnDois;
        private Button btnUm;
        private Button btnIgualA;
        private Button btnQuatro;
        private Button btnDois;
        private Button btnUm;
        private Button btnIgualA;
        private Button btnCinco;
        private Button btnOito;
        private Button btnSete;
        private Button btnSeis;
        private Button btnQuatro;
        private Button btnDois;
        private Button btnUm;
        private Button btnIgualA;
        private Button btnCinco;
        private Button btnTrês;
        private Button btnOito;
        private Button btnSete;
        private Button btnSeis;
        private Button btnQuatro;
        private Button btnDois;
        private Button btnUm;
        private Button btnIgualA;
        private Button btnCinco;
        private Button btnSete;
        private Button btnSeis;
        private Button btnQuatro;
        private Button btnDois;
        private Button btnUm;
        private Button btnIgualA;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnIgualA;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnDois;
        private Button btnUm;
        private Button btnIgualA;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnDois;
        private Button btnUm;
        private Button btnIgualA;
        private Button btnQuatro;
        private Button btnDois;
        private Button btnUm;
        private Button btnIgualA;
        private Button btnQuatro;
        private Button btnUm;
        private Button btnIgualA;
        private Button btnUm;
        private Button btnIgualA;
        private Button btnUm;
        private Button btnIgualA;
        private Button btnUm;
        private Button btnIgualA;
    }
}
