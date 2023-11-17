﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaGamer.Views
{
    public partial class Produtos : Form
    {
        // Atributos globais:
        int idSelecionado = 0;
        Classes.Usuario usuario = new Classes.Usuario();
        public Produtos(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            Classes.Produto produto = new Classes.Produto();

            dgvProdutos.DataSource = produto.ListarProdutos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Classes.Produto produto = new Classes.Produto();
            produto.Nome = txbNome.Text;
            produto.Preco = double.Parse(txbPreco.Text); 
            produto.IdCategoria = int.Parse(txbCategoria.Text);
            produto.IdRespCadastro = usuario.Id;

            if (produto.Adicionar() == true)
            {
                MessageBox.Show("Produto adicionado com sucesso!");
                // Limpar os campos:
                txbNome.Clear();
                txbPreco.Clear();
                txbCategoria.Clear();
                // Atualizar o dgv:
                dgvProdutos.DataSource = produto.ListarProdutos();
            }
            else
            {
                MessageBox.Show("Falha ao adicionar o produto!");
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar o grbs:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            // Obter a linha clicada:
            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;

            // Armazenar os dados da linha selecionada em "linha" (tipo vetor)
            var linha = dgvProdutos.Rows[linhaSelecionada];


            txbNomeEdit.Text = linha.Cells[1].Value.ToString();
            txbPrecoEdit.Text = linha.Cells[2].Value.ToString();

            // Juntar o ID e o nome para exibir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();

            // Obter os valores do txbs:
            produto.Nome = txbNomeEdit.Text;
            produto.Preco = double.Parse(txbPrecoEdit.Text);
            produto.IdCategoria = int.Parse(txbCategoriaEdit.Text);
            produto.IdRespCadastro = usuario.Id;
            produto.Id = idSelecionado;

            // Editar:
            if (produto.Editar())
            {
                MessageBox.Show("Produto modificado!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Atualizar o dgv:
                dgvProdutos.DataSource = produto.ListarProdutos();
                // Limpar os campos de edição:
                txbNomeEdit.Clear();
                txbPrecoEdit.Clear();
                txbCategoriaEdit.Clear();
                lblApagar.Text = "Selecione um produto para apagar.";
                // Desativar o grbs:
                grbEditar.Enabled = false;
                grbApagar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar o produto!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();
            produto.Id = idSelecionado;
            // Confirmar a exclusão:
            var r = MessageBox.Show("Tem certeza que deseja remover esse produto?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:
                if (produto.Apagar() == true)
                {
                    MessageBox.Show("Produto removido!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    dgvProdutos.DataSource = produto.ListarProdutos();
                    // Limpar os campos de edição:
                    txbNomeEdit.Clear();
                    txbPrecoEdit.Clear();
                    txbCategoriaEdit.Clear();
                    lblApagar.Text = "Selecione um produto para apagar.";
                    // Desativar o grbs:
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover o produto!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbCategorias_Click(object sender, EventArgs e)
        {
            Classes.Categoria categoria = new Classes.Categoria();
            cmbCategorias.SelectedIndex = categoria.Categorias();
        }
    }
}
