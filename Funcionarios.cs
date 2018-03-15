
using System;
using System.Globalization;

namespace LISTA

{
    public class Funcionarios
    {

        public int cpf { get; set; }
        public string nome { get; set; }
        public double salario { get; private set; }

        public Funcionarios(int cpf, string nome, double salario)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }

        public void aumentaSalario(double porcentagem)
        {
            //1000 = 1000 * 0,6+1
            // salario = 1000 * 1,6
            salario = salario * (porcentagem / 100 + 1);

        }

    }
}
