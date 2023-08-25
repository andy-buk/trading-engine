using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    public record OrderRecord(long OrderId, uint Quantity, long Price, bool IsBuySide, string Username, int SecurityId, uint TheoreticalQueuePosition);
}

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { };
}