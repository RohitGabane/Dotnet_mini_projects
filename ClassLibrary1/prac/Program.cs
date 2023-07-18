
namespace prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";

            // Define and run the task.
            Task taskA = Task.Run(() => Console.WriteLine("Hello from taskA."));
            Task taskB = Task.Run(() => Console.WriteLine("Hello from taskB."));
            Task taskC = Task.Run(() => Console.WriteLine("Hello from taskC."));


            // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.", Thread.CurrentThread.Name);
            taskA.Wait();

            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}