using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesPersonalizadas
{
    /*  Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data
    de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em
    dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar
    novamente a reserva com os dados atualizados. O programa não deve aceitar dados
    inválidos para a reserva, conforme as seguintes regras:
    - Alterações de reserva só podem ocorrer para datas futuras
    - A data de saída deve ser maior que a data de entrada
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-In Date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out Date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation.");


                Console.Write("Check-In Date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out Date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine($" Error in reservation: {e.Message}");
            }

        }


    }

}
