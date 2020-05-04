using Microsoft.VisualBasic;
using System;

namespace CarroCliente
{
    class CarroCliente
    {
        static void Main(string[] args)
        {
            CarroCliente carrocliente = new CarroCliente();
        }
        private int idcarro;
        private int idcliente;
        private string modelo;
        private string placa;
        private DateAndTime data;
        

        public CarroCliente() { }

        public CarroCliente(int idcarro, int idcliente, string modelo, string placa, DateAndTime data)
        {

            this.idcarro = idcarro;
            this.idcliente = idcliente;
            this.modelo = modelo;
            this.placa = placa;
            this.data = data;
        }



    }
}
