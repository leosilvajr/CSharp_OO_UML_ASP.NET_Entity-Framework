using System;

namespace ComposicaoExercicio.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Construtor Padrão
        public HourContract()
        { 

        }

        //Construtor com todos os argumentos.
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Metodo que retorna o valor total do contrato.
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
