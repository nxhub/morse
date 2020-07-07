using System;
using McMaster.Extensions.CommandLineUtils;

namespace Morse.Command
{
    [Command("delete", Description = "删除配置。")]
    public class ConfigDeleteCommand
    {
        [Option(Description = "配置 ID。")]
        public string Id { get; set; }

        public void OnExecute()
        {
            Console.WriteLine(this.Id);
        }
    }
}
