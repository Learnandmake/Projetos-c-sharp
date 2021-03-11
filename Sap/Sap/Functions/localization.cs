using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sap.Functions
{
    class localization
    {
        public static string GetCityname(string ip)
        {
            string city;

            try
            {
                using (WebClient webC = new WebClient())
                {
                    string url = string.Format("https://api.ipify.org/", ip);
                    var Json = webC.DownloadString(url);
                    var result = JsonConvert.DeserializeObject<localizationapp.root>(Json);

                    localizationapp.root saida = result;
                    city = saida.city;
                }

            }
            catch (Exception)
            { city = "São Paulo"; }

            return city;
        }

    }
}