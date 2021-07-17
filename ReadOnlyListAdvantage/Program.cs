using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ReadOnlyListAdvantage
{
    class Program
    {
        static void Main(string[] args)
        {
            var winnerList = new List<string>();
            for (int i = 1; i < 10000; i++)
            {
                var enumeration = TimeForMultipleEnumeration();
                var collection = TimeForReadOnlyCollection();
                var winner = collection < enumeration ? nameof(collection) : collection == enumeration ? "Draw" : nameof(enumeration);
                Console.WriteLine($"{i}). Winner is {winner}");
                winnerList.Add(winner);
            }
            var result = winnerList.GroupBy(x => x).Select(x => new
            {
                Player = x.Key,
                Count = x.Count()
            });
            result.ToList().ForEach(x => Console.WriteLine($"Player - {x.Player}, Result - {x.Count}"));
            
        }

        static TimeSpan TimeForMultipleEnumeration()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var names = Enumerable.Range(1, 1000).Select(x => x.ToString());
            foreach (var name in names)
            {
                
            }
            foreach (var name in names)
            {
                
            }
            stopWatch.Stop();
            var value = stopWatch.Elapsed;
            return value;
        }
        
        static TimeSpan TimeForReadOnlyCollection()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var names = Enumerable.Range(1, 1000).Select(x => x.ToString()).AsReadOnlyList();
            foreach (var name in names)
            {
                
            }
            foreach (var name in names)
            {
                
            }
            stopWatch.Stop();
            var value = stopWatch.Elapsed;
            return value;
        }
    }
}
