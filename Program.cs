using System;

namespace Cliente
{
    class Cliente
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
        }  
        
            private int idcliente;
            private string nome;
            private string morada;
            private int telefone;
            private int idcarro;


        public Cliente() { }

            public Cliente(int idcliente, string nome, string morada, int telefone, int idcarro)
            {

                this.idcliente= idcliente;
                this.nome = nome;
                this.morada = morada;
                this.telefone = telefone;
                this.idcarro = idcarro;

            }
     
    }
}
