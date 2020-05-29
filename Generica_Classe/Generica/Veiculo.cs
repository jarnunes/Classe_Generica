using System;
using System.Collections.Generic;
using System.Text;

namespace Generica
{
    class Veiculo : IComparable
    {
        public string placa;
        public string modelo;
        public Veiculo(string placa, string mod)
        {
            this.placa = placa;
            this.modelo = mod;
        }

        public int CompareTo(object obj)
        {
            Veiculo outro = (Veiculo)(obj);
            int resultado = this.placa.CompareTo(outro.placa);
            return resultado;
        }

        public override bool Equals(object obj)
        {
            Veiculo aux = (Veiculo)(obj);
            if (aux.placa.Equals(this.placa))
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine($"Modelo: {this.modelo}");
            aux.AppendLine($"Placa: {this.placa}");
            return aux.ToString();
        }
    }
}
