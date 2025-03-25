using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Help;
using System.CommandLine.Invocation;
using System.CommandLine.Parsing;
using System.Text;

namespace PlcTagParser
{

    public class Cli
    {
        static string Display()
        {
                return @"
        ____  _     ____   _____  _    ____ 
        |  _ \| |   / ___| |_   _|/ \  / ___|
        | |_) | |  | |       | | / _ \| |  _ 
        |  __/| |__| |___    | |/ ___ \ |_| |
        |_|   |_____\____|   |_/_/   \_\____|
        ____   _    ____  ____  _____ ____  
        |  _ \ / \  |  _ \/ ___|| ____|  _ \ 
        | |_) / _ \ | |_) \___ \|  _| | |_) |
        |  __/ ___ \|  _ < ___) | |___|  _ < 
        |_| /_/   \_\_| \_\____/|_____|_| \_\  
        ";
        }

        public static async Task<int> ProcessCommandLineArgs(string[] args)
        {
            // Create the root command
            var rootCommand = new RootCommand("PLC Tag Parser CLI");

            var cli = new CommandLineBuilder(rootCommand)
                .UseDefaults()
                .UseHelp(ctx =>
                {
                    ctx.HelpBuilder.CustomizeLayout( _ =>
                        HelpBuilder.Default
                            .GetLayout()
                            .Skip(1) // Skip the default command description section.
                            .Prepend( _ => _.Output.WriteLine(Display())));
                })
                .Build();
            
            return await cli.InvokeAsync(args);
        }
    }
}