namespace PadariaGamer.Views
{
    partial class GerenciamentoComandas
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
            this.grbInfos = new System.Windows.Forms.GroupBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.txbComandas = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbLançamento = new System.Windows.Forms.GroupBox();
            this.btnLançar = new System.Windows.Forms.Button();
            this.lblProdutoLan = new System.Windows.Forms.Label();
            this.txbProdutoLan = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.grbInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbLançamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInfos
            // 
            this.grbInfos.Controls.Add(this.btnContinuar);
            this.grbInfos.Controls.Add(this.txbCodProduto);
            this.grbInfos.Controls.Add(this.lblProduto);
            this.grbInfos.Controls.Add(this.txbComandas);
            this.grbInfos.Controls.Add(this.lblComanda);
            this.grbInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfos.Location = new System.Drawing.Point(12, 12);
            this.grbInfos.Name = "grbInfos";
            this.grbInfos.Size = new System.Drawing.Size(312, 350);
            this.grbInfos.TabIndex = 0;
            this.grbInfos.TabStop = false;
            this.grbInfos.Text = "Informações";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(6, 56);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(133, 25);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "COMANDA:";
            // 
            // txbComandas
            // 
            this.txbComandas.Location = new System.Drawing.Point(145, 37);
            this.txbComandas.Multiline = true;
            this.txbComandas.Name = "txbComandas";
            this.txbComandas.Size = new System.Drawing.Size(149, 77);
            this.txbComandas.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(6, 198);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(130, 25);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "PRODUTO:";
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProduto.Location = new System.Drawing.Point(145, 173);
            this.txbCodProduto.Multiline = true;
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(149, 67);
            this.txbCodProduto.TabIndex = 3;
            this.txbCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnContinuar
            // 
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(11, 281);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(283, 51);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(343, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(445, 635);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbLançamento
            // 
            this.grbLançamento.Controls.Add(this.txbQuantidade);
            this.grbLançamento.Controls.Add(this.lblQuantidade);
            this.grbLançamento.Controls.Add(this.txbProdutoLan);
            this.grbLançamento.Controls.Add(this.lblProdutoLan);
            this.grbLançamento.Controls.Add(this.btnLançar);
            this.grbLançamento.Enabled = false;
            this.grbLançamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLançamento.Location = new System.Drawing.Point(12, 387);
            this.grbLançamento.Name = "grbLançamento";
            this.grbLançamento.Size = new System.Drawing.Size(312, 241);
            this.grbLançamento.TabIndex = 2;
            this.grbLançamento.TabStop = false;
            this.grbLançamento.Text = "Lançamento";
            // 
            // btnLançar
            // 
            this.btnLançar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLançar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLançar.Location = new System.Drawing.Point(11, 168);
            this.btnLançar.Name = "btnLançar";
            this.btnLançar.Size = new System.Drawing.Size(283, 60);
            this.btnLançar.TabIndex = 5;
            this.btnLançar.Text = "LANÇAR";
            this.btnLançar.UseVisualStyleBackColor = true;
            this.btnLançar.Click += new System.EventHandler(this.btnLançar_Click);
            // 
            // lblProdutoLan
            // 
            this.lblProdutoLan.AutoSize = true;
            this.lblProdutoLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoLan.Location = new System.Drawing.Point(55, 46);
            this.lblProdutoLan.Name = "lblProdutoLan";
            this.lblProdutoLan.Size = new System.Drawing.Size(81, 24);
            this.lblProdutoLan.TabIndex = 6;
            this.lblProdutoLan.Text = "Produto:";
            // 
            // txbProdutoLan
            // 
            this.txbProdutoLan.Location = new System.Drawing.Point(145, 46);
            this.txbProdutoLan.Multiline = true;
            this.txbProdutoLan.Name = "txbProdutoLan";
            this.txbProdutoLan.Size = new System.Drawing.Size(149, 34);
            this.txbProdutoLan.TabIndex = 7;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(145, 103);
            this.txbQuantidade.Multiline = true;
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(149, 34);
            this.txbQuantidade.TabIndex = 9;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(26, 113);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(113, 24);
            this.lblQuantidade.TabIndex = 8;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // GerenciamentoComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.grbLançamento);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbInfos);
            this.Name = "GerenciamentoComandas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoComandas";
            this.grbInfos.ResumeLayout(false);
            this.grbInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbLançamento.ResumeLayout(false);
            this.grbLançamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfos;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbComandas;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbLançamento;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbProdutoLan;
        private System.Windows.Forms.Label lblProdutoLan;
        private System.Windows.Forms.Button btnLançar;
    }
}