using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Weather_Console;


namespace SharpWeather
{
    public class conditions
    {
        JObject o = JObject.Parse(Globals.current);
        
        public JToken image_url { get; set; }
        public JToken image_title { get; set; }
        public JToken image_link { get; set; }
        public JToken display_location_full { get; set; }
		public JToken display_location_city { get; set; }
		public JToken display_location_state { get; set; }
		public JToken display_location_state_name { get; set; }
		public JToken display_location_country { get; set; }
		public JToken display_location_country_iso3166 { get; set; }
		public JToken display_location_zip { get; set; }
		public JToken display_location_latitude { get; set; }
		public JToken display_location_longitude { get; set; }
		public JToken display_location_elevation { get; set; }
		public JToken observation_location_full { get; set; }
		public JToken observation_location_city { get; set; }
		public JToken observation_location_state { get; set; }
		public JToken observation_location_country { get; set; }
		public JToken observation_location_country_iso3166 { get; set; }
		public JToken observation_location_latitude { get; set; }
		public JToken observation_location_longitude { get; set; }
		public JToken observation_location_elevation { get; set; }
		public JToken estimated { get; set; }
		public JToken station_id { get; set; }
		public JToken observation_time { get; set; }
		public JToken observation_time_rfc822 { get; set; }
		public JToken observation_epoch { get; set; }
		public JToken local_time_rfc822 { get; set; }
		public JToken local_epoch { get; set; }
		public JToken local_tz_short { get; set; }
		public JToken local_tz_long { get; set; }
		public JToken local_tz_offset { get; set; }
		public JToken weather { get; set; }
		public JToken temperature_string { get; set; }
		public JToken temp_f { get; set; }
		public JToken temp_c { get; set; }
		public JToken relative_humidity { get; set; }
		public JToken wind_string { get; set; }
		public JToken wind_dir { get; set; }
		public JToken wind_degrees { get; set; }
		public JToken wind_mph { get; set; }
		public JToken wind_gust_mph { get; set; }
		public JToken wind_kph { get; set; }
		public JToken wind_gust_kph { get; set; }
		public JToken pressure_mb { get; set; }
		public JToken pressure_in { get; set; }
		public JToken pressure_trend { get; set; }
		public JToken dewpoint_string { get; set; }
		public JToken dewpoint_f { get; set; }
		public JToken dewpoint_c { get; set; }
		public JToken heat_index_string { get; set; }
		public JToken heat_index_f { get; set; }
		public JToken heat_index_c { get; set; }
		public JToken windchill_string { get; set; }
		public JToken windchill_f { get; set; }
		public JToken windchill_c { get; set; }
		public JToken feelslike_string { get; set; }
		public JToken feelslike_f { get; set; }
		public JToken feelslike_c { get; set; }
		public JToken visibility_mi { get; set; }
		public JToken visibility_km { get; set; }
		public JToken solarradiation { get; set; }
		public JToken UV { get; set; }
		public JToken precip_1hr_string { get; set; }
		public JToken precip_1hr_in { get; set; }
		public JToken precip_1hr_metric { get; set; }
		public JToken precip_today_string { get; set; }
		public JToken precip_today_in { get; set; }
		public JToken precip_today_metric { get; set; }
		public JToken icon { get; set; }
		public JToken icon_url { get; set; }
		public JToken forecast_url { get; set; }
		public JToken history_url { get; set; }
		public JToken ob_url { get; set; }

        public conditions(string city, int num)
        {
        	
        	
            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();
using (var sr = new StreamReader(response.GetResponseStream()))
            {
                Globals.forecast10 = sr.ReadToEnd();
            }
            
            //this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);

            
        }
    }
}
