using System;
using System.Collections.Generic;
using System.Text;

namespace Generica
{
    class Prova : IComparable
    {
        public double valor;
        public DateTime data;

        public Prova(double valor, DateTime data)
        {
            this.valor = valor;
            this.data = data;
        }
        public override bool Equals(object obj)
        {
            Prova aux = (Prova)(obj); //conversão de um objeto para pessoa.
            if (aux.valor.Equals(this.valor) && aux.data.Equals(this.data))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine($"Data: {this.data.ToString("dd/MM")}");
            aux.AppendLine($"Valor: {this.valor} pontos");
            return aux.ToString();
        }

        public int CompareTo(object obj)
        {
            Prova outra = (Prova)(obj);
            if (this.data < outra.data)
                return -1;
            else if (this.data > outra.data)
                return 1;
            else
                return 0;
        }


    }
}
