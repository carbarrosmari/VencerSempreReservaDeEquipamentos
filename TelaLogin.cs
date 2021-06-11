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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro janelaCadastro = new Cadastro();
            janelaCadastro.ShowDialog();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
                          

            var email = txtLogEmail.Text;
            var senha = txtLogSenha.Text;
            if (email == "admin" && senha == "admin")
            {
                FormAdmin fadmin = new FormAdmin();
                fadmin.ShowDialog();

                toolStripStatusLabel1.Text = "Login com Sucesso!";
                statusStrip1.Refresh();
                return;
            }
            else 
            {
                TelaInicial telinicio = new TelaInicial();
                telinicio.ShowDialog();
                return;
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
