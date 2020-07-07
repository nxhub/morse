using McMaster.Extensions.CommandLineUtils;
using Morse.Command;

namespace Morse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 一定要使用侧方式才能列出 options 选项
            var app = new CommandLineApplication<MainCommand>();

            // 此方式一定要设置 Convertions
            app.Conventions
                .UseDefaultConventions()
                .UseConstructorInjection();

            app.Execute(args);
        }
    }
}
