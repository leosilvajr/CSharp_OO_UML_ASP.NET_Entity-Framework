﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicio.Entities
{
  public class Contract
  {
    public int Number { get; set; }
    public DateTime Date { get; set; }
    public double TotalValue { get; set; }
    public List<Installment> Installments { get; set; }

    public Contract(int number, DateTime date, double totalValue)
    {
      Number = number;
      Date = date;
      TotalValue = totalValue;
      Installments = new List<Installment>(); //Cria uma lista com o Contrato instanciado
    }

    public void AddInstallment(Installment installment)
    {
      Installments.Add(installment);
    }
  }


}
