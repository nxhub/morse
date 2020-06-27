using System;
using McMaster.Extensions.CommandLineUtils;

namespace Morse.Command
{
    [Command("list", Description = "添加配置。")]
    public class ConfigListCommand
    {
        public void OnExecute()
        {
            Console.WriteLine(
                "ID\tAddress");
        }
    }
}
