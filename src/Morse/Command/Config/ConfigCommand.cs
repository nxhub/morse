using McMaster.Extensions.CommandLineUtils;

namespace Morse.Command
{
    [Command("config", Description = "服务器连接配置管理。")]
    [Subcommand(typeof(ConfigListCommand))]
    [Subcommand(typeof(ConfigAddCommand))]
    [Subcommand(typeof(ConfigDeleteCommand))]
    public class ConfigCommand
    {
        public int OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();

            return 1;
        }
    }
}
