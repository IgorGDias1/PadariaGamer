using System;
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
    public partial class GerenciamentoComandas : Form
    {
        // Atributos globais:
        int idSelecionado = 0;
        Classes.Usuario usuario = new Classes.Usuario();
        public GerenciamentoComandas(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            // Mudar o título da janela:
            this.Text = "Gerenciamento Comandas - Logado como: " +
                usuario.NomeCompleto.ToUpper();

            // Popular o DGV com os dados da tabela de produtos:
            Classes.Produto produto = new Classes.Produto();
            dgvProdutos.DataSource = produto.ListarProdutos();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obter a linha clicada:
            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;

            // Armazenar os dados da linha selecionada em "linha" (tipo vetor)
            var linha = dgvProdutos.Rows[linhaSelecionada];

            // Popular os txbs com os valores do dgv:
            txbCodProduto.Text = linha.Cells[0].Value.ToString();
            txbProdutoLan.Text = linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnLançar_Click(object sender, EventArgs e)
        {
            if(txbQuantidade.Text != "")
            {
                var r = MessageBox.Show("Tem certeza que deseja lançar?", "Aviso!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes && txbQuantidade.Text != "")
                {
                    Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                    // Obter os valores dos campos:
                    ordem.IdFicha = int.Parse(txbComandas.Text);
                    ordem.IdProduto = int.Parse(txbCodProduto.Text);
                    ordem.Quantidade = int.Parse(txbQuantidade.Text);
                    ordem.IdResp = usuario.Id;
                    // Efetuar o cadastro:
                    if (ordem.NovoLancamento() == true)
                    {
                        MessageBox.Show("Lançamento efetuado!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparTudo();
                    }
                    else
                    {
                        MessageBox.Show("Falha no lançamento!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimparTudo();
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe a quantidade!","Erro!",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Verificar se o número da comanda e cód do produto não estão vazios:
            if(txbComandas.Text != "" && txbCodProduto.Text != "")
            {
                grbLançamento.Enabled = true;
                grbInfos.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verificar as informações digitadas!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparTudo()
        {
            // Limpar os campos:
            txbCodProduto.Clear();
            txbQuantidade.Clear();
            txbProdutoLan.Clear();
            txbComandas.Clear();

            // Resetar os grbs:
            grbInfos.Enabled = true;
            grbLançamento.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }
    }
}
