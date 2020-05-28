using System;
using System.Collections.Generic;
using System.Text;

namespace Generica
{
    class Lista<T>
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
