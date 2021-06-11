using System;
using System.Collections.Generic;
using System.Text;

namespace VencerSempre.Classes
{
    public class Reserva
    {
        private int Codigo { get; set; }
        public Pessoa Cliente { get; }
        public Equipamento Item { get; set; }
        public DateTime DataReserva { get; set; }        
        public string Turno { get; set; }
        public string Disciplina { get; set; }
        public string Nome { get; internal set; }
        public string IdReserva { get; internal set; }
        public string Equipamento1 { get; internal set; }
        public string Equipamento2 { get; internal set; }
        public string Equipamento3 { get; internal set; }
        public string IDReserva { get; internal set; }

        private static int _codigoReserva = 0;

        private static List<Reserva> listaReserva = new List<Reserva>();
        internal DateTime Data;        

        public Reserva (Pessoa _nome, Equipamento _item)
        {
            Cliente = _nome;
            Item = _item;
            DataReserva = DateTime.Now;
            _codigoReserva++;
            Codigo = _codigoReserva;
            listaReserva.Add(this);
        }

        public Reserva()
        {
        }
    }
}
