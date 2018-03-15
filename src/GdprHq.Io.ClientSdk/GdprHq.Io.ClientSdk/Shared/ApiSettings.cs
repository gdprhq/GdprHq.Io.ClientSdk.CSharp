using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Shared
{
    public static class ApiSettings
    {
        /// <summary>
        /// Returns true if the default API is used.
        /// </summary>
        /// <returns></returns>
        public static bool IsApiEnabled()
        {
            return true;
        }

        /// <summary>
        /// Returns the URL of the default API.
        /// </summary>
        /// <returns></returns>
        public static Uri ApiUri()
        {
            return new Uri("http://localhost:56265");
        }

        /// <summary>
        /// Returns default timeout used for calls to the API.
        /// </summary>
        /// <returns></returns>
        public static int Timeout()
        {
            return 2000;
        }
    }
}
