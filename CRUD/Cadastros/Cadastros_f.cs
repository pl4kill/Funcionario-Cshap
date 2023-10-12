using CRUD.Banco_de_dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    internal class Cadastros_f
    {
        public int id;
        public string nome;
        public string idade;
        public string telefone;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public bool CadastrarFuncionarios()
        {
            try
            {
                MySqlConnection connect = new MySqlConnection(BancoConnect.conexaobanco);
                connect.Open();

                string sql_insert = $"INSERT INTO funcionarios VALUES('0','{Nome}','{Idade}','{Telefone}')";

                MySqlCommand comando = new MySqlCommand(sql_insert, connect);
                comando.CommandText = sql_insert;

                comando.ExecuteNonQuery();

                return true;
            }catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o usuario" + ex);
                return false;
            }
        }
    }
}



