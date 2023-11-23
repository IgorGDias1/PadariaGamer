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
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbComandas = new System.Windows.Forms.TextBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbLançamento = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbProdutoLan = new System.Windows.Forms.TextBox();
            this.lblProdutoLan = new System.Windows.Forms.Label();
            this.btnLançar = new System.Windows.Forms.Button();
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
            this.grbInfos.Size = new System.Drawing.Size(312, 264);
            this.grbInfos.TabIndex = 0;
            this.grbInfos.TabStop = false;
            this.grbInfos.Text = "Informações";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(11, 192);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(283, 51);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProduto.Location = new System.Drawing.Point(145, 98);
            this.txbCodProduto.Multiline = true;
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(149, 50);
            this.txbCodProduto.TabIndex = 3;
            this.txbCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(6, 123);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(130, 25);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "PRODUTO:";
            // 
            // txbComandas
            // 
            this.txbComandas.Location = new System.Drawing.Point(145, 37);
            this.txbComandas.Multiline = true;
            this.txbComandas.Name = "txbComandas";
            this.txbComandas.Size = new System.Drawing.Size(149, 44);
            this.txbComandas.TabIndex = 1;
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
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(343, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(445, 595);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbLançamento
            // 
            this.grbLançamento.Controls.Add(this.btnCancelar);
            this.grbLançamento.Controls.Add(this.txbQuantidade);
            this.grbLançamento.Controls.Add(this.lblQuantidade);
            this.grbLançamento.Controls.Add(this.txbProdutoLan);
            this.grbLançamento.Controls.Add(this.lblProdutoLan);
            this.grbLançamento.Controls.Add(this.btnLançar);
            this.grbLançamento.Enabled = false;
            this.grbLançamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLançamento.Location = new System.Drawing.Point(12, 301);
            this.grbLançamento.Name = "grbLançamento";
            this.grbLançamento.Size = new System.Drawing.Size(312, 306);
            this.grbLançamento.TabIndex = 2;
            this.grbLançamento.TabStop = false;
            this.grbLançamento.Text = "Lançamento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(11, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(283, 46);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // txbProdutoLan
            // 
            this.txbProdutoLan.Location = new System.Drawing.Point(145, 46);
            this.txbProdutoLan.Multiline = true;
            this.txbProdutoLan.Name = "txbProdutoLan";
            this.txbProdutoLan.ReadOnly = true;
            this.txbProdutoLan.Size = new System.Drawing.Size(149, 34);
            this.txbProdutoLan.TabIndex = 7;
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
            // btnLançar
            // 
            this.btnLançar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLançar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLançar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLançar.Location = new System.Drawing.Point(11, 168);
            this.btnLançar.Name = "btnLançar";
            this.btnLançar.Size = new System.Drawing.Size(283, 60);
            this.btnLançar.TabIndex = 5;
            this.btnLançar.Text = "LANÇAR";
            this.btnLançar.UseVisualStyleBackColor = false;
            this.btnLançar.Click += new System.EventHandler(this.btnLançar_Click);
            // 
            // GerenciamentoComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.grbLançamento);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbInfos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Button btnCancelar;
    }
}