using System;
using System.Threading;

namespace Chat
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var stop = new ManualResetEvent(false);

            Console.CancelKeyPress +=
                (sender, e) =>
                    {
                        Console.WriteLine("^C");
                        stop.Set();

                        // *Don't* kill the process.
                        e.Cancel = true;
                    };

            const string url = "http://+/Chat";
            using (WebApplication.Start(url))
            {
                Console.WriteLine("Listening on {0}; press Ctrl+C to quit.", url);
                stop.WaitOne();
            }
        }
    }
}