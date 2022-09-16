using System;
namespace uppgift2._13
{
    class program
    {
        static void Main(string[]args)
        {
            int Fabian = 10000;
            int Hashim = 12000;
            int Abel = 2000;
            int medellönen = Fabian + Hashim + Abel / 3; //nice
            int total = 24000;
            Console.WriteLine("Medellönen blir " + medellönen + " eftersom all lön tillsamans blir " + total); //duktig
            Console.ReadLine(); 
        }
    }
}