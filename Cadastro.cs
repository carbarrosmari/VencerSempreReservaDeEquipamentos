using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VencerSempre.Classes;

namespace VencerSempre
{
    public partial class Cadastro : Form
    {
        List<Pessoa> pessoas;
        public Cadastro()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            comboDisciplina.Items.Add("Português");
            comboDisciplina.Items.Add("Literatura");
            comboDisciplina.Items.Add("Redação");
            comboDisciplina.Items.Add("Matemática");
            comboDisciplina.Items.Add("Física");
            comboDisciplina.Items.Add("Química");
            comboDisciplina.Items.Add("Biologia");
            comboDisciplina.Items.Add("Geografia");
            comboDisciplina.Items.Add("História");
            comboDisciplina.Items.Add("Sociologia");
            comboDisciplina.Items.Add("Filosofia");
            comboDisciplina.Items.Add("Educação Física");

            comboDisciplina.SelectedIndex = 0;
        }


        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            RealizarCadastro();
        }
        private void RealizarCadastro()
            {
                toolStripStatusLabel1.Text = "Conectando...";
                statusStrip1.Refresh();

            int index = -1;
            foreach (Pessoa people in pessoas)
                if (people.Nome == txtNome.Text)
                {
                    index = pessoas.IndexOf(people);
                    MessageBox.Show("Erro! Usuário já está cadastrado!");
                }
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome.");
                txtNome.Focus();
                return;
            }
            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo Telefone.");
                txtTelefone.Focus();
                return;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Preencha o campo Senha.");
                txtSenha.Focus();
                return;
            }
            
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Email = txtEmail.Text;
            p.Telefone = txtTelefone.Text;
            p.Disciplina = (string)comboDisciplina.SelectedItem;
            p.Senha = txtSenha.Text;

            if (index < 0)
            {
                pessoas.Add(p);
                MessageBox.Show("Cadastrado com Sucesso!");

            }
            else
            {
                pessoas[index] = p;
            }
            try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        var sql = "INSERT INTO tabuser" + "(IDUsuario, Nome, Email, Telefone, Disciplina, Senha)" + "VALUES " + "(@IDUsuario, @Nome, @Email, @Telefone, @Disciplina, @Senha)";

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            toolStripStatusLabel1.Text = "Salvando";
                            statusStrip1.Refresh();


                            cmd.Parameters.AddWithValue("@IDUsuario", txtId.Text);
                            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                            cmd.Parameters.AddWithValue("@Disciplina", comboDisciplina.Text.ToString());
                            cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);
                            cmd.ExecuteNonQuery();
                        }

                        toolStripStatusLabel1.Text = "Pronto";
                        statusStrip1.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Falha";
                    statusStrip1.Refresh();
                    MessageBox.Show("Não inserir os dados!\n\n" + ex.Message);
                }
            }            
    }
}
