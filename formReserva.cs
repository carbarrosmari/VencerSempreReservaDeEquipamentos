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
    public partial class formReserva : Form
    {
        private void formReserva_Load(object sender, EventArgs e)
        {

        }
        public List<Reserva> reservas;

        public formReserva()
        {
            InitializeComponent();

            reservas = new List<Reserva>();

            cbxDisciplina.Items.Add("Português");
            cbxDisciplina.Items.Add("Literatura");
            cbxDisciplina.Items.Add("Redação");
            cbxDisciplina.Items.Add("Matemática");
            cbxDisciplina.Items.Add("Física");
            cbxDisciplina.Items.Add("Química");
            cbxDisciplina.Items.Add("Biologia");
            cbxDisciplina.Items.Add("Geografia");
            cbxDisciplina.Items.Add("História");
            cbxDisciplina.Items.Add("Sociologia");
            cbxDisciplina.Items.Add("Filosofia");
            cbxDisciplina.Items.Add("Educação Física");

            cbxDisciplina.SelectedIndex = 0;

            cbxEquipamento2.Items.Add("Data-Show");
            cbxEquipamento2.Items.Add("Notebook");
            cbxEquipamento2.Items.Add("Desktop");
            cbxEquipamento2.Items.Add("TV-Smart");
            cbxEquipamento2.Items.Add("Caixa Amplificadora");
            cbxEquipamento2.Items.Add("Caixa de Som Simples");
            cbxEquipamento2.Items.Add("Tablet");
            cbxEquipamento2.Items.Add("Tv");
            cbxEquipamento2.Items.Add("Dvd Blue-Ray");
            cbxEquipamento2.Items.Add("Home Teacher");
            cbxEquipamento2.Items.Add("Microfone");
            cbxEquipamento2.Items.Add("Mini System");

            cbxEquipamento2.SelectedIndex = 0;

            cbxEquipamento1.Items.Add("Data-Show");
            cbxEquipamento1.Items.Add("Notebook");
            cbxEquipamento1.Items.Add("Desktop");
            cbxEquipamento1.Items.Add("TV-Smart");
            cbxEquipamento1.Items.Add("Caixa Amplificadora");
            cbxEquipamento1.Items.Add("Caixa de Som Simples");
            cbxEquipamento1.Items.Add("Tablet");
            cbxEquipamento1.Items.Add("Tv");
            cbxEquipamento1.Items.Add("Dvd Blue-Ray");
            cbxEquipamento1.Items.Add("Home Teacher");
            cbxEquipamento1.Items.Add("Microfone");
            cbxEquipamento1.Items.Add("Mini System");

            cbxEquipamento1.SelectedIndex = 0;

            cbxEquipamento3.Items.Add("Data-Show");
            cbxEquipamento3.Items.Add("Notebook");
            cbxEquipamento3.Items.Add("Desktop");
            cbxEquipamento3.Items.Add("TV-Smart");
            cbxEquipamento3.Items.Add("Caixa Amplificadora");
            cbxEquipamento3.Items.Add("Caixa de Som Simples");
            cbxEquipamento3.Items.Add("Tablet");
            cbxEquipamento3.Items.Add("Tv");
            cbxEquipamento3.Items.Add("Dvd Blue-Ray");
            cbxEquipamento3.Items.Add("Home Teacher");
            cbxEquipamento3.Items.Add("Microfone");
            cbxEquipamento3.Items.Add("Mini System");

            cbxEquipamento2.SelectedIndex = 0;

            cbxTurno.Items.Add("Manhã");
            cbxTurno.Items.Add("Tarde");
            cbxTurno.Items.Add("Noite");

            cbxTurno.SelectedIndex = 0;
        }

        private void btnReservar_Click_1(object sender, EventArgs e)
        {
            ReservarEquipamento();
        }
        private void ReservarEquipamento()
        {
            toolStripStatusLabel1.Text = "Conectando...";
            statusStrip1.Refresh();

            int index = -1;
            foreach (Reserva reserv in reservas)
            {
                if (reserv.Equipamento1 == (string)cbxEquipamento1.SelectedItem
                    && reserv.Turno == (string)cbxTurno.SelectedItem)
                {
                    index = reservas.IndexOf(reserv);
                    MessageBox.Show("Erro! O equipamento já foi reservado!");
                }
            }


            if ((string)cbxEquipamento2.SelectedItem == "")
            {
                MessageBox.Show("Escolha o equipamento.");
                return;
            }
            if ((string)cbxTurno.SelectedItem == "")
            {
                MessageBox.Show("Escolha o Turno.");
                return;
            }

            Reserva r = new Reserva();
            r.IDReserva = txtIDR.Text;
            r.Nome = txtbNome.Text;
            r.Disciplina = (string)cbxDisciplina.SelectedItem;
            r.Equipamento1 = (string)cbxEquipamento1.SelectedItem;
            r.Equipamento2 = (string)cbxEquipamento2.SelectedItem;
            r.Equipamento3 = (string)cbxEquipamento3.SelectedItem;
            r.Turno = (string)cbxTurno.SelectedItem;
            r.Data = dateTimePicker1.MaxDate;

            if (index < 0)
            {
                reservas.Add(r);
                MessageBox.Show("Reservado com sucesso!");

            }
            else
            {
                reservas[index] = r;
            }
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "INSERT INTO tabreserva" + "(IDReserva, Nome, Disciplina, Equipamento1, Equipamento2, Equipamento3, Data, Turno)" + "VALUES" + "(@IDReserva, @Nome, @Disciplina, @Equipamento1, @Equipamento2, @Equipamento3, @Data, @Turno)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        toolStripStatusLabel1.Text = "Salvando o equipamento.";
                        statusStrip1.Refresh();

                        cmd.Parameters.AddWithValue("@IDReserva", txtIDR.Text);
                        cmd.Parameters.AddWithValue("@Nome", txtbNome.Text);
                        cmd.Parameters.AddWithValue("@Disciplina", cbxDisciplina.Text.ToString());
                        cmd.Parameters.AddWithValue("@Equipamento1", cbxEquipamento1.Text.ToString());
                        cmd.Parameters.AddWithValue("@Equipamento2", cbxEquipamento2.Text.ToString());
                        cmd.Parameters.AddWithValue("@Equipamento3", cbxEquipamento3.Text.ToString());
                        cmd.Parameters.AddWithValue("@Data", dateTimePicker1.MaxDate);
                        cmd.Parameters.AddWithValue("@Turno", cbxTurno.Text.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    toolStripStatusLabel1.Text = "Pronto";                    
                    statusStrip1.Refresh();
                    MessageBox.Show("Reserva registrada com Sucesso!");
                }
            }

            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha";
                statusStrip1.Refresh();
                MessageBox.Show("Devolução não registrada no Sistema!\n\n" + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}   
