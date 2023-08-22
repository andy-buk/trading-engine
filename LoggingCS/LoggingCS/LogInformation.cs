using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Logging
{
    public record LogInformation(LogLevel LogLevel, string Module, string Message, DateTime Now, int ThreadID, string ThreadName);
}

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { };
}