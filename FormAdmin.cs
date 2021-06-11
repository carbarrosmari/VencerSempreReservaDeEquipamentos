using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VencerSempre.Classes;

namespace VencerSempre
{
    public partial class FormAdmin : Form
    {

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    string sqlQuery = "SELECT * FROM tabuser";
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
                            dataGridView2.DataSource = dt;
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    string sqlQuery = "SELECT * FROM tabdevolucao";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView3.DataSource = dt;
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
    }
}
