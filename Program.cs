using System;
using Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_Csharp.src.Entities;

namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            knight arus = new knight("Arus", 23, "knight");
            Wizard Wizard = new Wizard("Jennica", 23, "White Wizard");
            

            Console.WriteLine(arus.Attack(1));
           
            Console.WriteLine(Wizard.Attack(7));
           
        }
    }
}
