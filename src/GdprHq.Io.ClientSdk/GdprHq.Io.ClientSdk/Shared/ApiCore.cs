using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace GdprHq.Io.ClientSdk.Shared
{
    public class ApiCore : Interfaces.IApiCore
    {
        public string Call(Shared.Enums.ApiMethodEnum apiMethodsEnum, string url, string jsonData)
        {
            try
            {
                var webRequest = WebRequest.Create(ApiSettings.ApiUri() + url) as HttpWebRequest;
                if (webRequest != null)
                {
                    webRequest.Method = apiMethodsEnum.ToString();
                    webRequest.Timeout = ApiSettings.Timeout();

                    if (apiMethodsEnum == Enums.ApiMethodEnum.PUT || apiMethodsEnum == Enums.ApiMethodEnum.POST)
                    {
                        webRequest.ContentType = "application/json";
                        String json = jsonData;
                        using (StreamWriter writer = new StreamWriter(webRequest.GetRequestStream()))
                        {
                            writer.Write(json);
                            writer.Flush();
                            writer.Close();
                        }
                    }
                }

                WebResponse response = webRequest.GetResponse();
                if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                {
                    System.IO.Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                    response.Close();

                    return responseFromServer;
                }
                else
                {
                    response.Close();
                    throw new Exception(((HttpWebResponse)response).StatusCode.ToString());
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
