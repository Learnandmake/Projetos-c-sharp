using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Functions
{
    class executer
    {

        public static string GetIp()
        { return new WebClient().DownloadString("https://api.ipify.org/"); }

        public static string Getlocation(string ip)
        {
            return localization.GetCityname(ip);
        }

        public string GetTemperatura(string city)
        {
            List<string> infos = climatempo.GetInfoCity(city);
            if (infos[0] == "error")
            { }
            string message = string.Format("graus:{0}," +
             "sensação termica{1} graus" +
              "mininmas de {2} graus" +
              "maxima de {3} graus" +
              "humidade do ar{4}%",
               infos[5],
         infos[8],
          infos[6],
           infos[6],
           infos[7],
            infos[10]);
            return message;


        }

        public string Getgraus(string city)
        {
            List<string> infos = climatempo.GetInfoCity(city);
            if (infos[0] == "error")
            { }
            string message = string.Format("C°:{0}",infos[5]);
    
            return message;


        }
    }
}
