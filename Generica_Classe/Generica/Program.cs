using System;

namespace Generica
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo onde foi usado a substituição implicita -a nas classes
            Lista<Prova> provas = new Lista<Prova>(2);
            Lista<Pessoa> galera = new Lista<Pessoa>(2);
            Lista<Veiculo> garagem = new Lista<Veiculo>(2);

            Prova pv1 = new Prova(20, new DateTime(2020, 05, 05));
            Prova pv2 = new Prova(25, new DateTime(2020, 05, 15));
            Pessoa ps1 = new Pessoa("03030289206", "Jardel Nunes", new DateTime(1996, 12, 08));
            Pessoa ps2 = new Pessoa("303023947893", "Gabriel Meliodas", new DateTime(1991, 06, 13));
            Pessoa ps3 = new Pessoa("203023957893", "Naruto  Meliodas", new DateTime(1801, 06, 13));
            Pessoa ps4 = new Pessoa("803023947893", "Goku Meliodas", new DateTime(1200, 06, 13));


            Veiculo car1 = new Veiculo("ABF-2345", "Gol");
            Veiculo car2 = new Veiculo("FBF-6345", "Pajero");

            provas.insetir(pv1);
            provas.insetir(pv2);
            galera.insetir(ps1);
            galera.insetir(ps2);
            garagem.insetir(car1);
            garagem.insetir(car2);

            Console.WriteLine("\"Maior \" da galera:");
            Console.WriteLine(galera.maior().ToString());

            Console.WriteLine("\"Maior \"  prova:");
            Console.WriteLine(provas.maior().ToString());

            Console.WriteLine("\"Maior \" da Veiculo:");
            Console.WriteLine(garagem.maior().ToString());

            Console.WriteLine("Minhas pessoas: ");
            Console.WriteLine(galera.ToString());
            Console.WriteLine("Minhas provas: ");
            Console.WriteLine(provas.ToString());
            Console.WriteLine("Meus Carros: ");
            Console.WriteLine(garagem.ToString());

            #endregion
            #region Substituição explicita
            Pessoa[] pessoas = new Pessoa[4];
            pessoas[0] = ps1;
            pessoas[1] = ps2;
            pessoas[2] = ps3;
            pessoas[3] = ps4;

            Array.Sort(pessoas); //Comparação generica implicita
            
            Console.WriteLine("============================");
            foreach (Pessoa p in pessoas)
                Console.WriteLine(p.ToString());
            Console.WriteLine("***********************");
            Array.Sort(pessoas, Pessoa.comparaNomes); //comparação explicita
            foreach (Pessoa p in pessoas)
                Console.WriteLine(p.ToString());
            Pessoa quem = Array.Find(pessoas, p => (p.CPF == "03030289206"));
            Console.WriteLine(quem);
            #endregion
        }
    }
}
