using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Functions
{
    class climatempo
    {
        private const string Key = "5a5286b1d1333fa09b4098df90443b4b";
        public static List<string> GetInfoCity(string city)
        {
            List<string> infos = new List<string>();

            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("http://api.openweathermap.org/data/2.5/weather?id=524901&appid=5a5286b1d1333fa09b4098df90443b4b");
                    var json = web.DownloadString(url);
                    var result = JsonConvert.DeserializeObject<ClimaTempoapp.root>(json);
                    ClimaTempoapp.root outPut = result;

                    infos.Add(outPut.nome);
                    infos.Add(outPut.coord.lon.ToString());
                    infos.Add(outPut.coord.lat.ToString());
                    infos.Add(outPut.weather[0].main.ToString());
                    infos.Add(outPut.weather[0].description.ToString());
                    infos.Add(outPut.main.temp.ToString());
                    infos.Add(outPut.main.temp_min.ToString());
                    infos.Add(outPut.main.temp_max.ToString());
                    infos.Add(outPut.main.feels_like.ToString());
                    infos.Add(Math.Round((outPut.main.pressure / 1013), 2).ToString());
                    infos.Add(outPut.main.humidity.ToString());
                    infos.Add(outPut.wind.speed.ToString());
                    infos.Add(outPut.wind.deg.ToString());
                    return infos;

                }

            }

            catch (Exception)
            {
                MessageBox.Show("algo deu errado");
                infos.Clear();
                infos.Add("error");
            }
            return infos;
        }

    }
}
