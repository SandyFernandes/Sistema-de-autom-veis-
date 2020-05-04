using System;

namespace Reparacao
{
    class Reparacao
    {
        static void Main(string[] args)
        {
            Reparacao reparacao = new Reparacao();
        }
        private int idcarro;
        private int idpecas;
        private int idfuncionario;
        private int idcliente;
        private double pecospecas;
        private DateTime datareparacao;
        private string pecasutilizadas;
        private double custoreparacao;
        private double pecosmaoobrafuncionario;
        private double respectivocustos;


        public Reparacao() { }

        public Reparacao(int idcarro, int idpecas, int idfuncionario, int idcliente, double pecospecas, 
        DateTime datareparacao,string pecasutilizadas, double custoreparacao,double pecosmaoobrafuncionario, double respectivocustos)
        {

            this.idcarro = idcarro;
            this.idpecas = idpecas;
            this.idfuncionario = idfuncionario;
            this.idcliente = idcliente;
            this.pecospecas = pecospecas;
            this.datareparacao = datareparacao;
            this.pecasutilizadas = pecasutilizadas;
            this.custoreparacao = custoreparacao;
            this.pecosmaoobrafuncionario = pecosmaoobrafuncionario;
            this.respectivocustos = respectivocustos;
        }
    }
}
