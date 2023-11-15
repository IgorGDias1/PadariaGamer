namespace PadariaGamer.Views
{
    partial class Produtos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbAdicionar = new System.Windows.Forms.GroupBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCategoriaEdit = new System.Windows.Forms.Label();
            this.txbCategoriaEdit = new System.Windows.Forms.TextBox();
            this.lblPrecoEdit = new System.Windows.Forms.Label();
            this.txbPrecoEdit = new System.Windows.Forms.TextBox();
            this.lblNomeEdit = new System.Windows.Forms.Label();
            this.txbNomeEdit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbAdicionar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(751, 393);
            this.dgvProdutos.TabIndex = 0;
            // 
            // grbAdicionar
            // 
            this.grbAdicionar.Controls.Add(this.btnAdicionar);
            this.grbAdicionar.Controls.Add(this.lblCategoria);
            this.grbAdicionar.Controls.Add(this.txbCategoria);
            this.grbAdicionar.Controls.Add(this.lblPreco);
            this.grbAdicionar.Controls.Add(this.txbPreco);
            this.grbAdicionar.Controls.Add(this.lblNome);
            this.grbAdicionar.Controls.Add(this.txbNome);
            this.grbAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdicionar.Location = new System.Drawing.Point(12, 444);
            this.grbAdicionar.Name = "grbAdicionar";
            this.grbAdicionar.Size = new System.Drawing.Size(373, 222);
            this.grbAdicionar.TabIndex = 1;
            this.grbAdicionar.TabStop = false;
            this.grbAdicionar.Text = "Adicionar Produto";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(95, 36);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(272, 26);
            this.txbNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(95, 76);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(272, 26);
            this.txbPreco.TabIndex = 2;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(34, 82);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(54, 20);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "Preço:";
            // 
            // txbCategoria
            // 
            this.txbCategoria.Location = new System.Drawing.Point(95, 117);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(272, 26);
            this.txbCategoria.TabIndex = 4;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(7, 123);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categória:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(6, 149);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(361, 67);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEdit);
            this.grbEditar.Controls.Add(this.txbCategoriaEdit);
            this.grbEditar.Controls.Add(this.lblPrecoEdit);
            this.grbEditar.Controls.Add(this.txbPrecoEdit);
            this.grbEditar.Controls.Add(this.lblNomeEdit);
            this.grbEditar.Controls.Add(this.txbNomeEdit);
            this.grbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(391, 444);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(373, 222);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar Produto";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gold;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(6, 149);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(361, 67);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // lblCategoriaEdit
            // 
            this.lblCategoriaEdit.AutoSize = true;
            this.lblCategoriaEdit.Location = new System.Drawing.Point(7, 123);
            this.lblCategoriaEdit.Name = "lblCategoriaEdit";
            this.lblCategoriaEdit.Size = new System.Drawing.Size(82, 20);
            this.lblCategoriaEdit.TabIndex = 5;
            this.lblCategoriaEdit.Text = "Categória:";
            // 
            // txbCategoriaEdit
            // 
            this.txbCategoriaEdit.Location = new System.Drawing.Point(95, 117);
            this.txbCategoriaEdit.Name = "txbCategoriaEdit";
            this.txbCategoriaEdit.Size = new System.Drawing.Size(272, 26);
            this.txbCategoriaEdit.TabIndex = 4;
            // 
            // lblPrecoEdit
            // 
            this.lblPrecoEdit.AutoSize = true;
            this.lblPrecoEdit.Location = new System.Drawing.Point(34, 82);
            this.lblPrecoEdit.Name = "lblPrecoEdit";
            this.lblPrecoEdit.Size = new System.Drawing.Size(54, 20);
            this.lblPrecoEdit.TabIndex = 3;
            this.lblPrecoEdit.Text = "Preço:";
            // 
            // txbPrecoEdit
            // 
            this.txbPrecoEdit.Location = new System.Drawing.Point(95, 76);
            this.txbPrecoEdit.Name = "txbPrecoEdit";
            this.txbPrecoEdit.Size = new System.Drawing.Size(272, 26);
            this.txbPrecoEdit.TabIndex = 2;
            // 
            // lblNomeEdit
            // 
            this.lblNomeEdit.AutoSize = true;
            this.lblNomeEdit.Location = new System.Drawing.Point(33, 42);
            this.lblNomeEdit.Name = "lblNomeEdit";
            this.lblNomeEdit.Size = new System.Drawing.Size(55, 20);
            this.lblNomeEdit.TabIndex = 1;
            this.lblNomeEdit.Text = "Nome:";
            // 
            // txbNomeEdit
            // 
            this.txbNomeEdit.Location = new System.Drawing.Point(95, 36);
            this.txbNomeEdit.Name = "txbNomeEdit";
            this.txbNomeEdit.Size = new System.Drawing.Size(272, 26);
            this.txbNomeEdit.TabIndex = 0;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 678);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbAdicionar);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "Produtos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbAdicionar.ResumeLayout(false);
            this.grbAdicionar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbAdicionar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCategoriaEdit;
        private System.Windows.Forms.TextBox txbCategoriaEdit;
        private System.Windows.Forms.Label lblPrecoEdit;
        private System.Windows.Forms.TextBox txbPrecoEdit;
        private System.Windows.Forms.Label lblNomeEdit;
        private System.Windows.Forms.TextBox txbNomeEdit;
    }
}