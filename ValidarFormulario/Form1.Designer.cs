namespace ValidarFormulario
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
            lblFullName = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtIdd = new TextBox();
            lblIdd = new Label();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtConfirmSenha = new TextBox();
            lblConfirmSenha = new Label();
            btnLimpar = new Button();
            btnEnviar = new Button();
            checkBoxTermo = new CheckBox();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(23, 19);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(96, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Nome Completo";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(23, 37);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(223, 23);
            txtFullName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(23, 81);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtIdd
            // 
            txtIdd.Location = new Point(23, 166);
            txtIdd.Name = "txtIdd";
            txtIdd.Size = new Size(223, 23);
            txtIdd.TabIndex = 5;
            // 
            // lblIdd
            // 
            lblIdd.AutoSize = true;
            lblIdd.Location = new Point(23, 148);
            lblIdd.Name = "lblIdd";
            lblIdd.Size = new Size(36, 15);
            lblIdd.TabIndex = 4;
            lblIdd.Text = "Idade";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(23, 224);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(223, 23);
            txtSenha.TabIndex = 7;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(23, 206);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // txtConfirmSenha
            // 
            txtConfirmSenha.Location = new Point(23, 284);
            txtConfirmSenha.Name = "txtConfirmSenha";
            txtConfirmSenha.Size = new Size(223, 23);
            txtConfirmSenha.TabIndex = 9;
            // 
            // lblConfirmSenha
            // 
            lblConfirmSenha.AutoSize = true;
            lblConfirmSenha.Location = new Point(23, 266);
            lblConfirmSenha.Name = "lblConfirmSenha";
            lblConfirmSenha.Size = new Size(95, 15);
            lblConfirmSenha.TabIndex = 8;
            lblConfirmSenha.Text = "Confirmar senha";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(23, 361);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(171, 361);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 11;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // checkBoxTermo
            // 
            checkBoxTermo.AutoSize = true;
            checkBoxTermo.Location = new Point(23, 327);
            checkBoxTermo.Name = "checkBoxTermo";
            checkBoxTermo.Size = new Size(204, 19);
            checkBoxTermo.TabIndex = 12;
            checkBoxTermo.Text = "Concordo Com os Termos de Uso";
            checkBoxTermo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxTermo);
            Controls.Add(btnEnviar);
            Controls.Add(btnLimpar);
            Controls.Add(txtConfirmSenha);
            Controls.Add(lblConfirmSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtIdd);
            Controls.Add(lblIdd);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtIdd;
        private Label lblIdd;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtConfirmSenha;
        private Label lblConfirmSenha;
        private Button btnLimpar;
        private Button btnEnviar;
        private CheckBox checkBoxTermo;
    }
}
