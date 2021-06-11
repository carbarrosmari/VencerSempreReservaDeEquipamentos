using System;
using System.Collections.Generic;
using System.Text;

namespace VencerSempre
{
    public class Equipamento
    {
        public int Codigo { get; set; }

        public String Descricao { get; set; }
        private static int _codigoEquipamento = 0;
        public static List<Equipamento> listaEquipamento = new List<Equipamento>();
    }
}
