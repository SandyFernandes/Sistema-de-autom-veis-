
using System;

namespace Funcionarios
{
    class Funcionarios
    {
        static void Main(string[] args)
        {
           Funcionarios funcionarios = new Funcionarios();
        }

        private int idfuncionario;
        private string nome;
        private string morada;
        private string cargo;
        private int telefone;
        private DateTime dataadmissao;


        public Funcionarios() { }

        public Funcionarios(int idfuncionario, string nome, string morada, string cargo, int telefone, DateTime dataadmissao)
        {

            this.idfuncionario = idfuncionario;
            this.nome = nome;
            this.morada = morada;
            this.cargo = cargo;
            this.telefone = telefone;
            this.dataadmissao = dataadmissao;
            

        }

    }
}
