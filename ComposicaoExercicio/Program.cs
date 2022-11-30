using ComposicaoExercicio.Entities;
using ComposicaoExercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar do usuario um mês
 *  e mostrar qual foi o salário do funcionário nesse mes.
 */ 

namespace ComposicaoExercicio
{
     class Program
    {
        static void Main(string[] args)
        {

            //Dados do trabalhador e do departamento.
            Console.Write("Enter a departament's name: "); //Entre com o nome do departament.
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: "); //Entre com os dados do trabalhador.
            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Level: ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando os objetos.
            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contract to his worker ? ");//Quantos contratos para esse trabalhador ?
            int n = int.Parse(Console.ReadLine());

            //for para executar n vezes;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter {i} contract data: "); //Interpolação.

                Console.Write("Date (DD/MM/YYYY): "); ;
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valurPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hour)");
                int hours = int.Parse(Console.ReadLine());

                //Instanciando o contrato.
                HourContract contract = new HourContract(date, valurPerHour, hours);
                //Adicionando o contrato ao trabalhador na lista.
                worker.AddContract(contract);
            }

            //Entre com o mes e ano para calcular o ganho.
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            //Substring Recortar o mes e o ano para formatação
            int month = int.Parse(monthAndYear.Substring(0, 2));  //pega as duas primeiras posiçoes da string monthAndYear
            int year = int.Parse(monthAndYear.Substring(3)); ;   //pega da posição 3 ate o final da string monthAndYear

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.Write($"Income for: {monthAndYear}: {worker.Income(year,month).ToString("F2")}");
        }
    }
}
