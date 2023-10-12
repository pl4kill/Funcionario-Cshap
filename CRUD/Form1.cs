using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Banco_de_dados;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!txtNome.Text.Equals("") && !txtIdade.Text.Equals("") && !txtTelefone.Text.Equals(""))
                {
                    Cadastros_f CadastroFuncionario = new Cadastros_f();
                    CadastroFuncionario.nome = txtNome.Text;
                    CadastroFuncionario.idade = txtIdade.Text;
                    CadastroFuncionario.telefone = txtTelefone.Text;

                    if (CadastroFuncionario.CadastrarFuncionarios())
                    {
                        MessageBox.Show("SALVO COM SUCESSO SEU BOSTA");
                    }
                }
                else
                {
                    MessageBox.Show("Preencher todos os campos");
                    txtNome.Clear();
                    txtIdade.Clear();
                    txtTelefone.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir os dados.");
            }
        }

        private void LimparCampo_Click(object sender, EventArgs e)
        {
            txtIdade.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*lbNomeBanco.Text = BancoConnect.db_name.ToString();
            lbTipoHost.Text = BancoConnect.host.ToString();
            lbNomeUser.Text = BancoConnect.name.ToString();
            lbSenha.Text = BancoConnect.name.ToString();*/
        }

        private void btnTesteConnectBanco_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Verificando conexão. Nome Banco: {BancoConnect.db_name}");
        }
    }
}

