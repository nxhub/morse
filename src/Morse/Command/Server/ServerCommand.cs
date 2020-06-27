using McMaster.Extensions.CommandLineUtils;

namespace Morse.Command
{
    [Command("server", Description = "服务器管理。")]
    [Subcommand(typeof(ServerStartCommand))]
    public class ServerCommand
    {
        public int OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();

            return 1;
        }
    }
}
