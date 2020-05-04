using System;

namespace Pecas
{
    class Pecas
    {
        static void Main(string[] args)
        {
            Pecas pecas = new Pecas();
        }

        private int idpecas;
        private int idfuncionario;
        private string nome;
        private string designacao;
        private double custounitario;
        private double quantidade;


        public Pecas() { }

        public Pecas(int idpecas, int idfuncionario, string nome, string designacao, double custounitario, double quantidade)
        {

            this.idpecas = idpecas;
            this.idfuncionario = idfuncionario;
            this.nome = nome;
            this.designacao = designacao;
            this.custounitario = custounitario;
            this.quantidade = quantidade;
        }


    }
}
