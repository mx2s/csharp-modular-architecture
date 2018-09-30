using System;
using Main.DAL.Models;

namespace Main
{
    class Program
    {
        static void Main(string[] args) {
            var all = User.All();
            Console.WriteLine("RR");
        }
    }
}