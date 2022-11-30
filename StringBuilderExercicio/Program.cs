using StringBuilderExercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExercicio
{
    //Instancie manualmente os objetos monstrador abaixo e mostre-os na tela do terminal.
    public class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nive trip !"); //Tenha uma boa viagem !
            Comment c2 = new Comment("Wow that's awesome !"); //Uau, isso é incrível !

            //Instanciando o Post
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",  //Viajar para Nova Zelândia
                "I'm going to visit this wonderful country!",  //Eu vou visitar este país maravilhoso
                12
                );

            //Adicionar os Comments no Post
            p1.AddComment(c1);
            p1.AddComment(c2);


            //Instanciando o Post
            Comment c3 = new Comment("Good Night."); //Boa noite 
            Comment c4 = new Comment("May the Force be with you");   //Que a força esteja com você

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good Night guys",   //Boa noite galera
                "See you tomorrow",   // Vejo você amanha.
                5
                );
            //Adicionar os Comments no Post
            p2.AddComment(c3);
            p2.AddComment(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);  
        }
    }
}
