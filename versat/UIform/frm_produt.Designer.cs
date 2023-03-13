namespace versat.UIform
{
    partial class frm_produt
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_id_pro = new TextBox();
            txt_nome_pro = new TextBox();
            txt_preco_pro = new TextBox();
            txt_descricao_pro = new TextBox();
            txt_qnt_pro = new TextBox();
            txt_categoria_pro = new TextBox();
            dgv_pro = new DataGridView();
            txt_pesquisa_pro = new TextBox();
            label8 = new Label();
            btn_cad_pro = new Button();
            btn_update_pro = new Button();
            btn_deletar_pro = new Button();
            btn_limpar_pro = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_pro).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 0;
            label1.Text = "Preencha os Dados:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 45);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 115);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 2;
            label2.Text = "ID Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 151);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 3;
            label3.Text = "Nome Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(301, 112);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 5;
            label4.Text = "Preço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 182);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 4;
            label5.Text = "Descrição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(301, 184);
            label6.Name = "label6";
            label6.Size = new Size(80, 17);
            label6.TabIndex = 7;
            label6.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(301, 148);
            label7.Name = "label7";
            label7.Size = new Size(67, 17);
            label7.TabIndex = 6;
            label7.Text = "Categoria";
            // 
            // txt_id_pro
            // 
            txt_id_pro.Location = new Point(120, 112);
            txt_id_pro.Name = "txt_id_pro";
            txt_id_pro.ReadOnly = true;
            txt_id_pro.Size = new Size(136, 23);
            txt_id_pro.TabIndex = 8;
            txt_id_pro.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_nome_pro
            // 
            txt_nome_pro.Location = new Point(120, 148);
            txt_nome_pro.Name = "txt_nome_pro";
            txt_nome_pro.Size = new Size(136, 23);
            txt_nome_pro.TabIndex = 9;
            // 
            // txt_preco_pro
            // 
            txt_preco_pro.Location = new Point(392, 109);
            txt_preco_pro.Name = "txt_preco_pro";
            txt_preco_pro.Size = new Size(139, 23);
            txt_preco_pro.TabIndex = 11;
            // 
            // txt_descricao_pro
            // 
            txt_descricao_pro.Location = new Point(120, 179);
            txt_descricao_pro.Name = "txt_descricao_pro";
            txt_descricao_pro.Size = new Size(136, 23);
            txt_descricao_pro.TabIndex = 10;
            // 
            // txt_qnt_pro
            // 
            txt_qnt_pro.Location = new Point(392, 176);
            txt_qnt_pro.Name = "txt_qnt_pro";
            txt_qnt_pro.Size = new Size(139, 23);
            txt_qnt_pro.TabIndex = 13;
            // 
            // txt_categoria_pro
            // 
            txt_categoria_pro.Location = new Point(392, 140);
            txt_categoria_pro.Name = "txt_categoria_pro";
            txt_categoria_pro.Size = new Size(139, 23);
            txt_categoria_pro.TabIndex = 12;
            // 
            // dgv_pro
            // 
            dgv_pro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_pro.Location = new Point(15, 217);
            dgv_pro.Name = "dgv_pro";
            dgv_pro.RowTemplate.Height = 25;
            dgv_pro.Size = new Size(516, 115);
            dgv_pro.TabIndex = 14;
            dgv_pro.RowHeaderMouseClick += dgv_pro_RowHeaderMouseClick;
            // 
            // txt_pesquisa_pro
            // 
            txt_pesquisa_pro.Location = new Point(120, 68);
            txt_pesquisa_pro.Name = "txt_pesquisa_pro";
            txt_pesquisa_pro.Size = new Size(136, 23);
            txt_pesquisa_pro.TabIndex = 16;
            txt_pesquisa_pro.TextChanged += txt_pesquisa_pro_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(15, 74);
            label8.Name = "label8";
            label8.Size = new Size(67, 17);
            label8.TabIndex = 15;
            label8.Text = "Pesquisar";
            // 
            // btn_cad_pro
            // 
            btn_cad_pro.Location = new Point(15, 347);
            btn_cad_pro.Name = "btn_cad_pro";
            btn_cad_pro.Size = new Size(75, 23);
            btn_cad_pro.TabIndex = 17;
            btn_cad_pro.Text = "Cadastrar";
            btn_cad_pro.UseVisualStyleBackColor = true;
            btn_cad_pro.Click += btn_cad_pro_Click;
            // 
            // btn_update_pro
            // 
            btn_update_pro.Location = new Point(156, 347);
            btn_update_pro.Name = "btn_update_pro";
            btn_update_pro.Size = new Size(75, 23);
            btn_update_pro.TabIndex = 18;
            btn_update_pro.Text = "Atualizar";
            btn_update_pro.UseVisualStyleBackColor = true;
            btn_update_pro.Click += btn_update_pro_Click;
            // 
            // btn_deletar_pro
            // 
            btn_deletar_pro.Location = new Point(306, 347);
            btn_deletar_pro.Name = "btn_deletar_pro";
            btn_deletar_pro.Size = new Size(75, 23);
            btn_deletar_pro.TabIndex = 20;
            btn_deletar_pro.Text = "Deletar";
            btn_deletar_pro.UseVisualStyleBackColor = true;
            btn_deletar_pro.Click += btn_deletar_pro_Click;
            // 
            // btn_limpar_pro
            // 
            btn_limpar_pro.Location = new Point(431, 347);
            btn_limpar_pro.Name = "btn_limpar_pro";
            btn_limpar_pro.Size = new Size(100, 23);
            btn_limpar_pro.TabIndex = 19;
            btn_limpar_pro.Text = "Limpar Campos";
            btn_limpar_pro.UseVisualStyleBackColor = true;
            btn_limpar_pro.Click += btn_limpar_pro_Click;
            // 
            // frm_produt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 450);
            Controls.Add(btn_deletar_pro);
            Controls.Add(btn_limpar_pro);
            Controls.Add(btn_update_pro);
            Controls.Add(btn_cad_pro);
            Controls.Add(txt_pesquisa_pro);
            Controls.Add(label8);
            Controls.Add(dgv_pro);
            Controls.Add(txt_qnt_pro);
            Controls.Add(txt_categoria_pro);
            Controls.Add(txt_preco_pro);
            Controls.Add(txt_descricao_pro);
            Controls.Add(txt_nome_pro);
            Controls.Add(txt_id_pro);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frm_produt";
            Text = "Produto";
            Load += frm_produt_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_pro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_id_pro;
        private TextBox txt_nome_pro;
        private TextBox txt_preco_pro;
        private TextBox txt_descricao_pro;
        private TextBox txt_qnt_pro;
        private TextBox txt_categoria_pro;
        private DataGridView dgv_pro;
        private TextBox txt_pesquisa_pro;
        private Label label8;
        private Button btn_cad_pro;
        private Button btn_update_pro;
        private Button btn_deletar_pro;
        private Button btn_limpar_pro;
    }
}