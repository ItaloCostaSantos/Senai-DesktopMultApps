namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmMatriculaAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtAnoUltimoAniversario = new System.Windows.Forms.TextBox();
            this.btnIdentificarCategoria = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Ano nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Ano último aniversário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(45, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(303, 23);
            this.txtNome.TabIndex = 4;
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(96, 45);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(58, 23);
            this.txtAnoNascimento.TabIndex = 5;
            this.txtAnoNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnoUltimoAniversario_Validating);
            // 
            // txtAnoUltimoAniversario
            // 
            this.txtAnoUltimoAniversario.Location = new System.Drawing.Point(293, 45);
            this.txtAnoUltimoAniversario.Name = "txtAnoUltimoAniversario";
            this.txtAnoUltimoAniversario.Size = new System.Drawing.Size(55, 23);
            this.txtAnoUltimoAniversario.TabIndex = 6;
            this.txtAnoUltimoAniversario.Enter += new System.EventHandler(this.txtAnoUltimoAniversario_Enter);
            this.txtAnoUltimoAniversario.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnoUltimoAniversario_Validating);
            // 
            // btnIdentificarCategoria
            // 
            this.btnIdentificarCategoria.Location = new System.Drawing.Point(12, 93);
            this.btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            this.btnIdentificarCategoria.Size = new System.Drawing.Size(131, 23);
            this.btnIdentificarCategoria.TabIndex = 7;
            this.btnIdentificarCategoria.Text = "Identificar Categoria";
            this.btnIdentificarCategoria.UseVisualStyleBackColor = true;
            this.btnIdentificarCategoria.Click += new System.EventHandler(this.btnIdentificarCategoria_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoria.Location = new System.Drawing.Point(232, 93);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(116, 23);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 125);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnIdentificarCategoria);
            this.Controls.Add(this.txtAnoUltimoAniversario);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMatriculaAluno";
            this.Text = "frmMatriculaAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtAnoNascimento;
        private TextBox txtAnoUltimoAniversario;
        private Button btnIdentificarCategoria;
        private Label lblCategoria;
    }
}