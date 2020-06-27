using McMaster.Extensions.CommandLineUtils;

namespace Morse.Command
{
    [Command("delete", Description = "添加配置。")]
    public class ConfigDeleteCommand
    {
        [Option(Description = "配置 ID。")]
        public string Id { get; set; }

        public void OnExecute()
        {

        }
    }
}
