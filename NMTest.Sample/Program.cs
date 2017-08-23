using System.Threading;

namespace NMTest.Sample
{
    public static class Program
    {
        public static void Main(string[] parameters)
        {
            // your code goes here
            
            for (var i = 0; i < 10; i++)
            {
                new Thread(() =>
                {
                    // your code goes here   
                }).Start();
            }
        }
    }
}