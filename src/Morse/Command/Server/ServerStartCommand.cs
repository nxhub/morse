using System;
using McMaster.Extensions.CommandLineUtils;

namespace Morse.Command
{
    [Command("start", Description = "启动服务器。")]
    public class ServerStartCommand
    {
        [Option(Description = "监听端口。")]
        public int Port { get; set; }

        public void OnExecute()
        {
            Console.WriteLine($"port: {this.Port}");
        }
    }
}
