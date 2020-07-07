using System;
using McMaster.Extensions.CommandLineUtils;

namespace Morse.Command
{
    [Command("add", Description = "添加配置。")]
    public class ConfigAddCommand
    {
        [Option(Description = "服务器地址。")]
        public string Address { get; set; }

        public void OnExecute()
        {
            Console.WriteLine(this.Address);
        }
    }
}
