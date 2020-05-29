using System;
using System.Collections.Generic;
using System.Text;

namespace Generica
{
    class Lista<T> where T : IComparable
    {
        private T[] dados;
        private int quantMax;
        private int quantAtual;

        public Lista(int n)
        {
            if (n >= 2)
            {
                this.dados = new T[n];
                this.quantMax = n;
            }
            else
            {
                this.dados = new T[2];
                this.quantMax = 2;
            }
            this.quantAtual = 0;
        }

        public bool insetir(T novo)
        {
            if (quantAtual < quantMax)
            {
                dados[quantAtual] = novo;
                quantAtual++;
                return true;
            }
            else
            {
                return false;
            }

        }
        public T procurar(T obj)
        {
            foreach (T item in dados)
            {
                if (item.Equals(obj))
                {
                    return item;
                }

            }
            return default(T);
        }

        public T maior()
        {
            T maior = dados[0];
            foreach (T item in dados)
            {
                //CompareTo retorna:
                // -1 se meu objeto for menor
                // 1 se meu objeto for maior
                // 0 se meus objetos forem iguais

                if (item.CompareTo(maior) > 0)
                {
                    maior = item;
                }
            }
            return maior;
        }
        public override string ToString()
        {
            StringBuilder lista = new StringBuilder();
            foreach (T objeto in dados)
            {
                lista.AppendLine(objeto.ToString());
            }
            return lista.ToString();
        }
    }
}
