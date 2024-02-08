using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda
{
    public partial class form_agenda : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        string idregistro;
        
        public form_agenda()
        {
            InitializeComponent();

            servidor = "Server=localhost;Database=bdagenda;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            atualiza_lista();
            
        }

        private void atualiza_lista()
        {
            try
            {

                conexao.Open();

                comando.CommandText = "SELECT * FROM tbl_contatos;";
                MySqlDataAdapter adaptadoragenda = new MySqlDataAdapter(comando);
                DataTable tabelaagenda = new DataTable();
                adaptadoragenda.Fill(tabelaagenda);
                dataGridlista.DataSource = tabelaagenda;
                dataGridlista.Columns["idtbl_contatos"].HeaderText = "ID";


            }
            catch (Exception erro_mysql)
            {
                
                //MessageBox.Show(erro_mysql.Message);
                MessageBox.Show("Erro de Sistema. Informe o suporte");
            }
            finally
            {

                conexao.Close();
            }

        }



        private void buttonsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                
               
                if (textnome.Text != "" && textcelular.Text != "")
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO tbl_contatos(nome,sobrenome,celular,telefone,email,endereco,instagram) VALUES('" + textnome.Text + "', '" + textsobrenome.Text + "', '" + textcelular.Text + "', '" + texttelefone.Text + "', '" + textemail.Text + "', '" + textendereco.Text + "', '" + textinsta.Text + "');";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado");

                }
                else
                {
                    MessageBox.Show("Campo Nome/Celular obrigatório.");
                }
                
                
            }
            catch (Exception erro_mysql)
            {
                //MessageBox.Show(erro_mysql.Message);
                MessageBox.Show("Erro de Sistema. Informe o suporte");
            }
            finally
            {
                textBoxPESQUISA.Clear(); textnome.Clear(); textsobrenome.Clear(); textemail.Clear(); textcelular.Clear(); textinsta.Clear(); textendereco.Clear(); texttelefone.Clear();

                conexao.Close();
            }
            atualiza_lista();


        }

        private void buttonexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Continuar?", "Atenção!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                try
                {

                    conexao.Open();
                    comando.CommandText = "DELETE FROM tbl_contatos WHERE idtbl_contatos = " + idregistro + ";";
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Contato(s) Removido(s) com Sucesso! - " + resultado + "Registros Removidos...");
                    }
                    else
                    {
                        MessageBox.Show("Contato não encontrado");
                    }

                }
                catch (Exception erro_mysql)
                {

                    MessageBox.Show("Erro de Sistema. Informe o suporte");

                }
                finally
                {

                    textBoxPESQUISA.Clear(); textnome.Clear(); textsobrenome.Clear(); textemail.Clear(); textcelular.Clear(); textinsta.Clear(); textendereco.Clear(); texttelefone.Clear();
                    conexao.Close();

                }
                atualiza_lista();
            } else
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void buttonatualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Continuar?", "Atenção!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                try
                {

                    conexao.Open();
                    comando.CommandText = "UPDATE tbl_contatos SET nome = '" + textnome.Text + "', celular = '" + textcelular.Text + "', sobrenome = '" + textsobrenome.Text + "', telefone = '" + texttelefone.Text + "', email = '" + textemail.Text + "', instagram = '" + textinsta.Text + "', endereco = '" + textendereco.Text + "' WHERE  idtbl_contatos = " + idregistro + ";";
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Contato(s) Atualizado(s) com Sucesso! - " + resultado + " Registro(s) Alterado(s)...");
                    }
                    else
                    {
                        MessageBox.Show("Contato não encontrado");
                    }

                }
                catch (Exception erro_mysql)
                {

                    MessageBox.Show(erro_mysql.Message);

                }
                finally
                {

                    textBoxPESQUISA.Clear(); textnome.Clear(); textsobrenome.Clear(); textemail.Clear(); textcelular.Clear(); textinsta.Clear(); textendereco.Clear(); texttelefone.Clear();
                    conexao.Close();

                }
                atualiza_lista();
            } else
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void dataGridlista_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            

            // MessageBox.Show(dataGridlista.CurrentRow.Cells[1].Value.ToString());
            idregistro = dataGridlista.CurrentRow.Cells[0].Value.ToString();
            textnome.Text = dataGridlista.CurrentRow.Cells[1].Value.ToString();
            textsobrenome.Text = dataGridlista.CurrentRow.Cells[2].Value.ToString();
            textemail.Text = dataGridlista.CurrentRow.Cells[5].Value.ToString();
            textendereco.Text = dataGridlista.CurrentRow.Cells[6].Value.ToString();
            textinsta.Text = dataGridlista.CurrentRow.Cells[7].Value.ToString();
            textcelular.Text = dataGridlista.CurrentRow.Cells[3].Value.ToString();
            texttelefone.Text = dataGridlista.CurrentRow.Cells[4].Value.ToString(); 

        }

        private void buttonbUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPESQUISA.Text == "")
                {
                    atualiza_lista();
                }
                else
                {
                    conexao.Open();

                    comando.CommandText = "SELECT * FROM tbl_contatos WHERE nome LIKE '%" + textBoxPESQUISA.Text + "%';";
                    MySqlDataAdapter adaptadorAGENDA = new MySqlDataAdapter(comando);
                    DataTable tabelaAGENDA = new DataTable();
                    adaptadorAGENDA.Fill(tabelaAGENDA);

                    dataGridlista.DataSource = tabelaAGENDA;
                    
                }
            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
            textBoxPESQUISA.Clear(); textnome.Clear(); textsobrenome.Clear(); textemail.Clear(); textcelular.Clear(); textinsta.Clear(); textendereco.Clear(); texttelefone.Clear();

        }
    }
}
