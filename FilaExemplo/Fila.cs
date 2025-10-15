using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FilaExemplo;

namespace FilaExemplo
{
    public class Fila
    {
        private Pessoa head;
        private Pessoa tail;

        public Fila()
        {
            head = null;
            tail = null;
        }

        public Pessoa CriarFila()
        {
            Console.WriteLine("Digite o nome:");
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.Nome = Console.ReadLine()!;
            return novaPessoa;
        }

        public void InserirPessoa(Pessoa novaPessoa)
        {
            if (head == null)
            {
                head = tail = novaPessoa;
            }
            else
            {
                tail.Proximo = novaPessoa;
                tail = novaPessoa;
            }
        }

        public void RemoverPessoa()
        {
            if (head == null)
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                head = head.Proximo;
                if (head == null)
                    tail = null;
            }
        }

        public int VerificaTamanhoDaFila()
        {
            int contador = 0;
            Pessoa aux = head;
            while (aux != null)
            {
                contador++;
                aux = aux.Proximo;
            }
            return contador;
        }

        public void ImprimirFila()
        {
            if (head == null)
            {
                Console.WriteLine("Fila Vazia");
                return;
            }

            Pessoa aux = head;
            while (aux != null)
            {
                Console.WriteLine(aux.Nome);
                aux = aux.Proximo;
            }
        }
    }

}
