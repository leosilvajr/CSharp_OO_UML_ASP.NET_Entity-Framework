using Interfaces.Entities;
using System;

namespace Interfaces.Services
{
    public class RentalService
    {
        public double  PricePerHour { get; private set; } //Private: eu só posso obter e nao modificar.
        public double  PricePerDay { get; private set; }




        /* Inversão de controle por meio de injeção de dependencia.
         * A classe RentalService nao instancia mais a dependencia dela
         * Ela vai receber o ITaxService _taxService e simplesmente vai atribuir
         */
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        /// <summary>
        /// Processar um CarRental e gerar a  nota de pagamento.
        /// </summary>
        /// <param name="carRental"></param>
        public void ProcessInvoice (CarRental carRental)
        {
            //Calcular diferença entre o horario que foi alugado o carro e o horario de entrega.
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {                                    //Math.Ceiling : Arredonda pra cima.          
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}
