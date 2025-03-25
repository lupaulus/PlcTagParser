using System.Collections.Generic;

namespace PlcTagParser
{
    public interface IHandler
    {
        string Convert(List<string> args);
    }
}