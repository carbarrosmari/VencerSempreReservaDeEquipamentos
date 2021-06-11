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
    public partial class TelaInicial : Form
    {
        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    string sqlQuery = "SELECT * FROM tabreserva";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    toolStripStatusLabel1.Text = "Pronto!";
                    statusStrip1.Refresh();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha!";
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }   
        }
                        
        private void btnReserva_Click(object sender, EventArgs e)
        {
            formReserva janelaReserva = new formReserva();
            janelaReserva.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDevolucao janelaDevolucao = new FormDevolucao();
            janelaDevolucao.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
