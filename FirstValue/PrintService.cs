using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstValue
{
  class PrintService<T>
  {
    //Variavel com Vetor de inteiros, e inicio com a capacidade de 10 numeros inteiros.
    private T[] _values = new T[10];

    //Variavel para contar os numeros inteiros.
    private int _count = 0;

    public void AddValue(T value)
    {
      if (_count ==10)
      {
        throw new InvalidOperationException("PrintService is Full");
      }
      _values[_count] = value;
      _count++;
    }

    public T First()
    {
      if (_count == 0)
      {
        throw new InvalidOperationException("PrintService is Empty");
      }
      return _values[0];
    }

    public void Print()
    {
      Console.Write("[");
      for (int i = 0; i < _count - 1; i++)
      {
        Console.Write(_values[i]+ ", ");
      }
      if (_count > 0)
      {
        Console.Write(_values[_count-1]);
      }
      Console.Write("]");
    }
  }
}
