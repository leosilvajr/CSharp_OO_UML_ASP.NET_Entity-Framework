using ComposicaoExercicio.Entities.Enums;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace ComposicaoExercicio.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        //Composição   //Associação entre Worker e Departament
        public Departament Departament { get; set; }  //Associação entre duas classes diferentes.
                            

                                                              //Instanciando lista pra garantir que ela nao seja nula
        public List<HourContract> Contracts { get; set; }  = new List<HourContract> { };
            //Um trabalhador tem varios contratos.

        //Construtor vazio
        public Worker()
        {

        }

        //Construtor com argumentos. (Sem a Lista de COntratos)
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        //Metodo que Adiciona um contrato ao trabalhador.
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        //Metodo que Remove um contrato ao trabalhador.
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract); 
        }
                
        //Ganhos do Funcionario
        public double Income(int year, int month)
        {
            double sum = BaseSalary; //Valor inicial que o Trabalhador sempre vai ganhar.

            //para cada HourContract na minha Lista de Contratct
            foreach (HourContract contract in Contracts)
            {
                //Se o ano do meu Contrato for igual ao ano que recebi como argumento e o mes também , significa
                //que esse contrato vai ter que entrar na soma.
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
