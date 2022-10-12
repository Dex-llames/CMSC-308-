using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSC308_ACTIVITY1_LLAMES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Email = { "Raiden.booba@gmail.com", "Kazuha.emo@gmail.com", "Bennet.unluky@gmail.com" };
            string[] Username = {"RaidenShogun", "KaedeharaKazuha", "BestBoy" };
            string[] Password = {"Archon", "WanderingSamurai", "Benny'sAdventureTeam" };


            Console.Write("Index:  ");
            int index1=Convert.ToInt32( Console.ReadLine());

            
            Console.WriteLine("Email: " + Email[index1]);
            Console.WriteLine("Username:  " + Username[index1]);
            Console.WriteLine("Password:  " + Password[index1]);
            Console.ReadKey();

        }
    }
}
