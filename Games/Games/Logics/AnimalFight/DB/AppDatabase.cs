using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Games.Logics.Animal_Fight.DB
{
    class AppDatabase
    {
        public string DbPath { get => @"C:\Users\ahmadrezam\Desktop\CShatpPractice\Games\Games\Logics\AnimalFight\DB\Database.txt"; }

        public Fighter[] GetFighters()
        {
            string[] dbLines = File.ReadAllLines(DbPath);
            Fighter[] fighters = new Fighter[dbLines.Length];

            for(int i = 0; i < dbLines.Length; i++) {
                fighters[i] = CreateFighter(dbLines[i]);
            }

            return fighters;

        }

        private Fighter CreateFighter(string line)
        {
            string[] lineData = line.Split(",");

            return new Fighter(lineData[0], Int16.Parse(lineData[1]));
        }

    }
}
