using System.Threading;

namespace NMTest.Sample
{
    public static class Program
    {
        public static void Main(string[] parameters)
        {
            for (var i = 0; i < 10; i++)
            {
                new Thread(() =>
                {
                }).Start();
            }
        }
    }
}