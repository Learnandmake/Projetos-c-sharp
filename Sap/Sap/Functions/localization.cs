using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Functions
{
    class localization
    {

        string city; 
       
            try
            {
                using (WebClient webC = new WebClient())
                {
                    string url = string.Format("https://api.ipify.org/", ip);
        var Json = webC.DownloadString(url);
        var result = JsonConvert.DeserializeObject<functions.localizationapp.root>(Json);

        localizationapp.root saida = result;
        city = saida.city;
                }

}
            catch (Exception)
            { city = "Sao Paulo"; }

            return city;
    }
}
