using McMaster.Extensions.CommandLineUtils;

namespace Morse.Command
{
    [Command(Description = "摩尔电码模拟程序。")]
    [Subcommand(typeof(ServerCommand))]
    [Subcommand(typeof(ConfigCommand))]
    [HelpOption(Inherited = true)]
    public class MainCommand
    {
        public int OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();

            return 1;
        }
    }
}
