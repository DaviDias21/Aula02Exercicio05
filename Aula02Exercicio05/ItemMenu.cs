using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02Exercicio05
{
    class ItemMenu
    {
        protected String nome;

        public ItemMenu()
        {

        }

        public void ImprimirNome()
        {
            Console.WriteLine("Nome: " + this.nome);
        }

        public virtual void ImprimirPreco()
        {

        }
    }
}
