using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FourRealms.Design.Demo.Player;
using FourRealms.Design.Life;
using FourRealms.Design.Item;
using FourRealms.Design.Item.Weapon;

namespace FourRealms.Design.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("这是一个测试：");

            Player1 player1 = new Player1();
            Player2 player2 = new Player2();

            Console.WriteLine(player1);
            Console.WriteLine(player2);

            player1.Attack(player2);
            player2.Attack(player1);

            Console.ReadLine();
        }
    }
}
