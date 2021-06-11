using System;
using System.Collections.Generic;
using System.Text;

namespace VencerSempre
{
    public class Devolucao
    {
        private int Codigo { get; set; }
        public Pessoa Cliente { get; }
        public Equipamento Item { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Turno { get; set; }
        public string Disciplina { get; set; }
        public string Equipamento { get; internal set; }
        public string Nome { get; internal set; }
        public string IdReserva { get; internal set; }
        public string Equipamento1 { get; internal set; }
        public string Equipamento2 { get; internal set; }
        public string Equipamento3 { get; internal set; }
        public string IDDevolucao { get; internal set; }

        private static int _codigoDevolucao = 0;

        private static List<Devolucao> listaDevolucao = new List<Devolucao>();
        internal DateTime Data;

        public Devolucao(Pessoa _nome, Equipamento _item)
        {
            Cliente = _nome;
            Item = _item;
            DataDevolucao = DateTime.Now;
            _codigoDevolucao++;
            Codigo = _codigoDevolucao;
            listaDevolucao.Add(this);
        }

        public Devolucao()
        {
        }
    }
}
