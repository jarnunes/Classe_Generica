using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generica
{
    class Pessoa //Todas as classes herdam implicitamente de Object
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
