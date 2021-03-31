using System;

namespace Aula02Exercicio05
{
    class ClasseTeste
    {
        static void Main(string[] args)
        {
            ItemMenu[] cardapioLanchonete = new ItemMenu[5];

            cardapioLanchonete[0] = new Aperitivo("Batata Frita", 5f);
            cardapioLanchonete[1] = new Aperitivo("Frango a Passarinho", 8f);
            cardapioLanchonete[2] = new Bebida("Água", 1f, 4f, 5f);
            cardapioLanchonete[3] = new Bebida("Suco", 2f, 4.5f, 6f);
            cardapioLanchonete[4] = new Bebida("Refrigerante", 2.5f, 5f, 6.5f);

            ImprimirCardapio(cardapioLanchonete);

            Console.ReadLine();
           
        }

        public static void ImprimirCardapio(ItemMenu[] cardapio)
        {
            int indiceCardapio = 0;

            Console.WriteLine("CARDÁPIO:\n");
            foreach(ItemMenu item_ in cardapio)
            {
                Console.WriteLine("Item " + (indiceCardapio + 1)+":");
                item_.ImprimirNome();
                item_.ImprimirPreco();
                Console.WriteLine();
                indiceCardapio++;
            }
        }
    }
}
