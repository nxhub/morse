using McMaster.Extensions.CommandLineUtils;
using Morse.Command;

namespace Morse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CommandLineApplication.Execute<MainCommand>();
        }
    }
}
