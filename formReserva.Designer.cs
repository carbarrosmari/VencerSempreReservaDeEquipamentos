
namespace VencerSempre
{
    partial class formReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxDisciplina = new System.Windows.Forms.ComboBox();
            this.cbxEquipamento1 = new System.Windows.Forms.ComboBox();
            this.cbxEquipamento2 = new System.Windows.Forms.ComboBox();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.txtIDR = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxEquipamento3 = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxDisciplina
            // 
            this.cbxDisciplina.FormattingEnabled = true;
            this.cbxDisciplina.Location = new System.Drawing.Point(273, 149);
            this.cbxDisciplina.Name = "cbxDisciplina";
            this.cbxDisciplina.Size = new System.Drawing.Size(355, 23);
            this.cbxDisciplina.TabIndex = 0;
            // 
            // cbxEquipamento1
            // 
            this.cbxEquipamento1.FormattingEnabled = true;
            this.cbxEquipamento1.Location = new System.Drawing.Point(273, 194);
            this.cbxEquipamento1.Name = "cbxEquipamento1";
            this.cbxEquipamento1.Size = new System.Drawing.Size(355, 23);
            this.cbxEquipamento1.TabIndex = 1;
            // 
            // cbxEquipamento2
            // 
            this.cbxEquipamento2.FormattingEnabled = true;
            this.cbxEquipamento2.Location = new System.Drawing.Point(273, 232);
            this.cbxEquipamento2.Name = "cbxEquipamento2";
            this.cbxEquipamento2.Size = new System.Drawing.Size(355, 23);
            this.cbxEquipamento2.TabIndex = 2;
            // 
            // cbxTurno
            // 
            this.cbxTurno.FormattingEnabled = true;
            this.cbxTurno.Location = new System.Drawing.Point(273, 310);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(355, 23);
            this.cbxTurno.TabIndex = 4;
            // 
            // txtIDR
            // 
            this.txtIDR.Location = new System.Drawing.Point(240, 66);
            this.txtIDR.Name = "txtIDR";
            this.txtIDR.Size = new System.Drawing.Size(100, 23);
            this.txtIDR.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(411, 66);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // cbxEquipamento3
            // 
            this.cbxEquipamento3.FormattingEnabled = true;
            this.cbxEquipamento3.Location = new System.Drawing.Point(273, 270);
            this.cbxEquipamento3.Name = "cbxEquipamento3";
            this.cbxEquipamento3.Size = new System.Drawing.Size(355, 23);
            this.cbxEquipamento3.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(273, 371);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(481, 371);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(147, 23);
            this.btnReservar.TabIndex = 9;
            this.btnReservar.Text = "Reservar Equipamento";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "IDRserva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Equipamento1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Equipamento2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Equipamento3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Turno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Disciplina:";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(273, 108);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(355, 23);
            this.txtbNome.TabIndex = 17;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // formReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.cbxEquipamento3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtIDR);
            this.Controls.Add(this.cbxTurno);
            this.Controls.Add(this.cbxEquipamento2);
            this.Controls.Add(this.cbxEquipamento1);
            this.Controls.Add(this.cbxDisciplina);
            this.Name = "formReserva";
            this.Text = "formReserva";
            this.Load += new System.EventHandler(this.formReserva_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDisciplina;
        private System.Windows.Forms.ComboBox cbxEquipamento1;
        private System.Windows.Forms.ComboBox cbxEquipamento2;
        private System.Windows.Forms.ComboBox cbxTurno;
        private System.Windows.Forms.TextBox txtIDR;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxEquipamento3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}