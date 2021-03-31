using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02Exercicio05
{
    class Aperitivo : ItemMenu
    {
        private float preco;

        public Aperitivo(String nome_, float preco_)
        {
            base.nome = nome_;
            this.preco = preco_;
        }

        public override void ImprimirPreco()
        {
            Console.WriteLine("Preço: R$" + this.preco);
        }
    }
}
