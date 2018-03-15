using System;
using System.Collections.Generic;
using System.Globalization;

namespace LISTA
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int n;


            List<Funcionarios> lista = new List<Funcionarios>(); 

            Console.Write("Quantos funcionarios serao registrados? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++){

                Console.Write("CPF: ");
                int cpf = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionarios f = new Funcionarios(cpf, nome, salario);
                lista.Add(f);

            }

            for (int j = 0; j < lista.Count; j++){
                Console.WriteLine(lista[j].cpf);
                Console.WriteLine(lista[j].nome);
                Console.WriteLine(lista[j].salario);
            }

            Console.Write("Insira o CPF do funcionario no qual deseja aumentar o salario: ");
            int cpfBuscado = int.Parse(Console.ReadLine());
            int indexCpfBuscado = lista.FindIndex(x => x.cpf == cpfBuscado);

            if(indexCpfBuscado == -1){
                Console.WriteLine("CPF INEXISTENTE");
            } else {
                Console.Write("Em quantos % deseja aumentar o salario do funcionario? ");
                double porcentagem = double.Parse(Console.ReadLine());
                lista[indexCpfBuscado].aumentaSalario(porcentagem); 
            }

            for (int j = 0; j < lista.Count; j++)
            {
                Console.WriteLine(lista[j].cpf);
                Console.WriteLine(lista[j].nome);
                Console.WriteLine(lista[j].salario);
            }



















            //int n;

            //List<Funcionarios> novoFuncionario = new List<Funcionarios>();

            //Console.Write("Quantos funcionarios serao cadastrados? ");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++){

            //    Console.WriteLine("Dados do " + i + " funcionario: ");
            //    Console.Write("CPF: ");
            //    int cpf = int.Parse(Console.ReadLine());
            //    Console.Write("Nome: ");
            //    string nome = Console.ReadLine();
            //    Console.Write("Salario: ");
            //    double salario = double.Parse(Console.ReadLine());
            //    Funcionarios funcionario = new Funcionarios(cpf, nome, salario);
            //    novoFuncionario.Add(funcionario);

            //}

            //for (int j = 0; j < novoFuncionario.Count; j++)
            //{
            //    Console.WriteLine(novoFuncionario[j].nome);
            //    Console.WriteLine(novoFuncionario[j].cpf);
            //    Console.WriteLine(novoFuncionario[j].salario);
            //}

            //Console.WriteLine();
            //Console.Write("Digite o CPF do funcionario que recebera aumento: ");
            //int cpfBuscado = int.Parse(Console.ReadLine());

            //int indexFuncionarioBuscado =  novoFuncionario.FindIndex(x => x.cpf == cpfBuscado);

            //if(indexFuncionarioBuscado == -1){
            //    Console.WriteLine("CPF INEXISTENTE");
            //} else {
            //    Console.Write("Quantos % deseja aumentar o salario do funcionario? ");
            //    double porcentagem = double.Parse(Console.ReadLine());
            //    novoFuncionario[indexFuncionarioBuscado].aumentarSalario(porcentagem);
            //}





            //for (int a = 0; a < novoFuncionario.Count; a++){
            //    Console.WriteLine(novoFuncionario[a].nome);
            //    Console.WriteLine(novoFuncionario[a].cpf);
            //    Console.WriteLine(novoFuncionario[a].salario);
            //}





















            //List<string> Lista = new List<string>();

            //Lista.Add("Gabriel");
            //Lista.Add("Mylena");
            //Lista.Add("Luna");
            //Lista.Add("Ida");
            //Lista.Add("Mitsuaki");

            ////Lista.Remove("Gabriel");
            ////Lista.RemoveAt(0);
            //int pos = Lista.FindIndex(x => x == "Gabriel");
            //Console.WriteLine(pos);

            //for (int i = 0; i < Lista.Count; i++){
            //    Console.WriteLine(Lista[i]);
            //}

        }
    }
}
