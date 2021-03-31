using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02Exercicio05
{
    class Bebida : ItemMenu
    {
        private float precoPequeno;
        private float precoMedio;
        private float precoGrande;

        public Bebida(String nome_, float precoPequeno_, float precoMedio_, float precoGrande_)
        {
            base.nome = nome_;
            this.precoPequeno = precoPequeno_;
            this.precoMedio = precoMedio_;
            this.precoGrande = precoGrande_;
        }

        public override void ImprimirPreco()
        {
            Console.WriteLine("Preço (Tamanho Pequeno): R$" + this.precoPequeno);
            Console.WriteLine("Preço (Tamanho Médio): R$" + this.precoMedio);
            Console.WriteLine("Preço (Tamanho Grande): R$" + this.precoGrande);
        }

    }
}
