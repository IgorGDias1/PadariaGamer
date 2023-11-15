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
    public partial class GerenciamentoUsuarios : Form
    {
        // Atributos globais:
        int idSelecionado = 0;
        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();

            // Atribuir a tabela (resultado do SELECT) no DGV:
            dgvUsuario.DataSource = usuario.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.NomeCompleto = txbNomeCad.Text;
            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;

            if(usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrar com sucesso!");
                // Limpar os campos:
                txbNomeCad.Clear();
                txbEmail.Clear();
                txbSenha.Clear();
                // Atualizar o dgv:
                dgvUsuario.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuário!");
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar o grbs:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            // Obter a linha clicada:
            int linhaSelecionada = dgvUsuario.CurrentCell.RowIndex;

            // Armazenar os dados da linha selecionada em "linha" (tipo vetor)
            var linha = dgvUsuario.Rows[linhaSelecionada];


            txbNomeEdit.Text = linha.Cells[1].Value.ToString();
            txbEmailEdit.Text = linha.Cells[2].Value.ToString();

            // Juntar o ID e o nome para exibir no apagar:
            lblUsuarioApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = idSelecionado;
            // Confirmar a exclusão:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:
                if (usuario.Apagar() == true)
                {
                    MessageBox.Show("Usuário removido!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    dgvUsuario.DataSource = usuario.ListarTudo();
                    // Limpar os campos de edição:
                    txbNomeCad.Clear();
                    txbEmail.Clear();
                    txbSenha.Clear();
                    lblUsuarioApagar.Text = "Selecione um usuário para apagar.";
                    // Desativar o grbs:
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover usuário!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();

            // Obter os valores do txbs:
            usuario.Id = idSelecionado;
            usuario.NomeCompleto = txbNomeEdit.Text;
            usuario.Email = txbEmailEdit.Text;
            usuario.Senha = txbNovaSenha.Text;

            // Editar:
            if (usuario.Editar())
            {
                MessageBox.Show("Usuário modificado!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Atualizar o dgv:
                dgvUsuario.DataSource = usuario.ListarTudo();
                // Limpar os campos de edição:
                txbNomeCad.Clear();
                txbEmail.Clear();
                txbSenha.Clear();
                lblUsuarioApagar.Text = "Selecione um usuário para apagar.";
                // Desativar o grbs:
                grbEditar.Enabled = false;
                grbApagar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar usuário!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
