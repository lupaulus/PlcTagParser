using System.Threading.Tasks;

namespace PlcTagParser
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
           return await Cli.ProcessCommandLineArgs(args);
        }
    }
}