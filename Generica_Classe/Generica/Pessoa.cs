using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Generica
{
    class Pessoa : IComparable  //Todas as classes herdam implicitamente de Object
    {
        public string CPF;
        public string nome;
        public DateTime nasc;

        public Pessoa(string cpf, string nome, DateTime dataNas)
        {
            this.CPF = cpf;
            this.nome = nome;
            this.nasc = dataNas;
        }

        /// <summary>
        /// Método para ser usado no main com  comparação explicita
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static int comparaNomes(Pessoa p1, Pessoa p2)
        {
            int result = p1.nome.CompareTo(p2.nome);
            return result;
        }
        public int CompareTo(object obj)
        {
            Pessoa outra = (Pessoa)(obj);
            if (this.nasc < outra.nasc)
                return -1;
            else if (this.nasc > outra.nasc)
                return 1;
            else
                return 0;

        }

        public override bool Equals(object obj)
        {
            Pessoa aux = (Pessoa)(obj); //conversão de um objeto para pessoa.
            if (aux.CPF.Equals(this.CPF))
                return true;
            else
                return false;
        }


        public override string ToString()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine($"Nome: {this.nome}");
            aux.AppendLine($"CPF: {this.CPF}");
            aux.AppendLine($"Data Nascimento: {this.nasc.ToString("dd/MM/yyyy")}");
            aux.AppendLine($"Idade: {DateTime.Now.Subtract(this.nasc).TotalDays.ToString("0")}");
            return aux.ToString();
        }
    }
}
