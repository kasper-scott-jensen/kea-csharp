using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace exam._7._Advanced_Topics
{
    
    public static class ConcurrentExecution
    {
        
        // TASKS
        public static void Tasks()
        {
            Task task1 = Task.Run(() =>
            {
                Console.WriteLine("Running Task 1 ...");
                Thread.Sleep(2000);
                Console.WriteLine("Finished Task 1.");
            });
            
            Task task2 = Task.Run(() =>
            {
                Console.WriteLine("Running Task 2 ...");
                Console.WriteLine("Waiting for input for Task 2 ...");
                Console.ReadKey();
                Console.WriteLine("Finished Task 2.");
            });

            Task.WaitAll(task1, task2);
            Console.WriteLine("All tasks finished.");
        }
        
        // PARALLEL
        public static void Parallels()
        {
            List<int> numbers = new List<int>
            {
                1, 2, 3, 4, 5
            };

            Parallel.ForEach(numbers, number =>
            {
                Console.WriteLine($"Processing number {number} ...");
                Thread.Sleep(1500);
                Console.WriteLine($"Finished number {number}.");
            });
        }

        // SIMPLE THREAD
        public static void SimpleThread()
        {
            Thread thread = new Thread(() => { Console.WriteLine("Hello from a thread."); });
            thread.Start();
        }
        
    }
    
}