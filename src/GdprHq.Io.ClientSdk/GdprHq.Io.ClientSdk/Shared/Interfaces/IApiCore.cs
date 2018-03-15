using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Shared.Interfaces
{
    public interface IApiCore
    {
        string Call(Shared.Enums.ApiMethodEnum apiMethodsEnum, string url, string jsonData);
    }
}
