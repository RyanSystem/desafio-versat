namespace versat
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            panel1 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            ordemDeCompraToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 311);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 33);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(414, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 1;
            label1.Text = "Desenvolvido Por Murilo Ryan";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, produtoToolStripMenuItem, ordemDeCompraToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(604, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.BackColor = SystemColors.Control;
            clienteToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            clienteToolStripMenuItem.ImageTransparentColor = Color.Black;
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(56, 20);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.BackColor = SystemColors.Control;
            produtoToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(62, 20);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // ordemDeCompraToolStripMenuItem
            // 
            ordemDeCompraToolStripMenuItem.BackColor = SystemColors.Control;
            ordemDeCompraToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            ordemDeCompraToolStripMenuItem.Name = "ordemDeCompraToolStripMenuItem";
            ordemDeCompraToolStripMenuItem.Size = new Size(118, 20);
            ordemDeCompraToolStripMenuItem.Text = "Ordem de Compra";
            ordemDeCompraToolStripMenuItem.Click += ordemDeCompraToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(603, 278);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 356);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Versat - Sistema";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem ordemDeCompraToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}