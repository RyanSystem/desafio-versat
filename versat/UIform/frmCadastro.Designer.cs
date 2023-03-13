namespace versat
{
    partial class frmCadastro
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txt_id_cad = new TextBox();
            txt_nome_cad = new TextBox();
            label3 = new Label();
            txt_end_cad = new TextBox();
            label4 = new Label();
            txt_cont_cli = new TextBox();
            label5 = new Label();
            dgvCad = new DataGridView();
            btn_cadastrar = new Button();
            btn_atualizar = new Button();
            btn_deletar = new Button();
            label6 = new Label();
            txt_pesquisar = new TextBox();
            btn_limpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 0;
            label1.Text = "Preencha os Dados:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 41);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 140);
            label2.Name = "label2";
            label2.Size = new Size(24, 17);
            label2.TabIndex = 2;
            label2.Text = "Id:";
            // 
            // txt_id_cad
            // 
            txt_id_cad.Location = new Point(86, 139);
            txt_id_cad.Name = "txt_id_cad";
            txt_id_cad.ReadOnly = true;
            txt_id_cad.Size = new Size(360, 23);
            txt_id_cad.TabIndex = 3;
            // 
            // txt_nome_cad
            // 
            txt_nome_cad.Location = new Point(86, 179);
            txt_nome_cad.Name = "txt_nome_cad";
            txt_nome_cad.Size = new Size(360, 23);
            txt_nome_cad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            // 
            // txt_end_cad
            // 
            txt_end_cad.Location = new Point(86, 214);
            txt_end_cad.Multiline = true;
            txt_end_cad.Name = "txt_end_cad";
            txt_end_cad.Size = new Size(360, 23);
            txt_end_cad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 215);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 6;
            label4.Text = "Endereço:";
            // 
            // txt_cont_cli
            // 
            txt_cont_cli.Location = new Point(86, 253);
            txt_cont_cli.Name = "txt_cont_cli";
            txt_cont_cli.Size = new Size(360, 23);
            txt_cont_cli.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 254);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 8;
            label5.Text = "Contato:";
            // 
            // dgvCad
            // 
            dgvCad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCad.Location = new Point(12, 282);
            dgvCad.Name = "dgvCad";
            dgvCad.RowTemplate.Height = 25;
            dgvCad.Size = new Size(434, 113);
            dgvCad.TabIndex = 10;
            dgvCad.CellContentClick += dgvCad_CellContentClick;
            dgvCad.RowHeaderMouseClick += dgvCad_RowHeaderMouseClick;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(12, 405);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(75, 23);
            btn_cadastrar.TabIndex = 11;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Location = new Point(112, 405);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(75, 23);
            btn_atualizar.TabIndex = 12;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = true;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // btn_deletar
            // 
            btn_deletar.Location = new Point(205, 405);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(75, 23);
            btn_deletar.TabIndex = 13;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = true;
            btn_deletar.Click += btn_deletar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 83);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 14;
            label6.Text = "Pesquisar:";
            // 
            // txt_pesquisar
            // 
            txt_pesquisar.Location = new Point(90, 82);
            txt_pesquisar.Name = "txt_pesquisar";
            txt_pesquisar.Size = new Size(100, 23);
            txt_pesquisar.TabIndex = 15;
            txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(302, 405);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(104, 23);
            btn_limpar.TabIndex = 16;
            btn_limpar.Text = "Limpar Campos";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 446);
            Controls.Add(btn_limpar);
            Controls.Add(txt_pesquisar);
            Controls.Add(label6);
            Controls.Add(btn_deletar);
            Controls.Add(btn_atualizar);
            Controls.Add(btn_cadastrar);
            Controls.Add(dgvCad);
            Controls.Add(txt_cont_cli);
            Controls.Add(label5);
            Controls.Add(txt_end_cad);
            Controls.Add(label4);
            Controls.Add(txt_nome_cad);
            Controls.Add(label3);
            Controls.Add(txt_id_cad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += frmCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txt_id_cad;
        private TextBox txt_nome_cad;
        private Label label3;
        private TextBox txt_end_cad;
        private Label label4;
        private TextBox txt_cont_cli;
        private Label label5;
        private DataGridView dgvCad;
        private Button btn_cadastrar;
        private Button btn_atualizar;
        private Button btn_deletar;
        private Label label6;
        private TextBox txt_pesquisar;
        private Button btn_limpar;
    }
}