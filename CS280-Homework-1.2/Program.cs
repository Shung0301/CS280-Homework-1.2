using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.SerialNumber = 5566f;
            pokemon.PokemonName = "小瓷怪";

            Console.WriteLine("寶可夢編號:{0}, 寶可夢名稱:{1}"
                , pokemon.SerialNumber, pokemon.PokemonName);
        }
    }
}