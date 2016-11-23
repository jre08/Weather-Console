/*
 * Created by SharpDevelop.
 * User: edenfield-john
 * Date: 11/22/2016
 * Time: 1:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Weather_Console;
using Newtonsoft.Json.Linq;
using System.Net; 
using System.IO;

namespace Weather_Console
{
	
	class Program
	{
		
	
		public static void Main(string[] args)
			
		{
			readJson("32443");
			
			astronomy astro = new astronomy(0);
			//almanac allmanacs = new almanac(0);
			//conditions current = new conditions(0);
			
			Console.WriteLine("Weather Underground Console");
			Console.WriteLine(" ---------------- ");
			Console.WriteLine(astro.ageOfMoon);
			Console.WriteLine(astro.precentIlluminated);
			Console.WriteLine(astro.hemisphere);
			Console.WriteLine(astro.sunset_hour);
			//Console.WriteLine(current.display_location_city);

			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static  void readJson(string city)
		{
			/*
        var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/forecast/q/" + city + ".json");
        request.ContentType = "application/json";
        var response = (HttpWebResponse)request.GetResponse();

        using (var sr = new StreamReader(response.GetResponseStream()))
        {
            Globals.forecast4 = sr.ReadToEnd();
        }
			 */
			var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			request.ContentType = "application/json";
			var response = (HttpWebResponse)request.GetResponse();

			using (var sr = new StreamReader(response.GetResponseStream()))
			{
				Globals.current = sr.ReadToEnd();
			}
			
			//JObject o = JObject.Parse(textjson);
			//Debug.Print("forecast: " +o["forecast"]["txt_forecast"]["forecastday"][0]);
			
			var request1 = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/astronomy/q/" + city + ".json");
			request.ContentType = "application/json";
			var response1 = (HttpWebResponse)request1.GetResponse();

			using (var sr = new StreamReader(response1.GetResponseStream()))
			{
				Globals.astronomy = sr.ReadToEnd();
			}
			//JObject o = JObject.Parse(textjson);
			//Debug.Print("forecast: " +o["forecast"]["txt_forecast"]["forecastday"][0]);
			System.Diagnostics.Debug.Print(Globals.astronomy);

		}
	
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

		public conditions(int num)
		{
			
			
			//            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			//            request.ContentType = "application/json";
			//            var response = (HttpWebResponse)request.GetResponse();
			//using (var sr = new StreamReader(response.GetResponseStream()))
			//            {
			//                Globals.forecast10 = sr.ReadToEnd();
			//            }
			//this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
			//this.period = (o["current_observation"]);
			
			
			this.image_url  = (o["current_observation"]["image"]["url"]);
			this.image_title =(o["current_observation"]["image"]["title"]);
			this.image_link = (o["current_observation"]["image"]["link"]);
			
			
			this.display_location_full = (o["current_observation"]["display_location"]["full"]);
			this.display_location_city =  (o["current_observation"]["display_location"]["city"]);
			this.display_location_state = (o["current_observation"]["display_location"]["state"]);
			this.display_location_state_name = (o["current_observation"]["display_location"]["state_name"]);
			this.display_location_country = (o["current_observation"]["display_location"]["country"]);
			this.display_location_country_iso3166 = (o["current_observation"]["display_location"]["country_iso3166"]);
			this.display_location_zip = (o["current_observation"]["display_location"]["zip"]);
			this.display_location_latitude = (o["current_observation"]["display_location"]["latitude"]);
			this.display_location_longitude = (o["current_observation"]["display_location"]["longitude"]);
			this.display_location_elevation = (o["current_observation"]["display_location"]["elevation"]);
			
			this.observation_location_full = (o["current_observation"]["observation_location"]["full"]);
			this.observation_location_city = (o["current_observation"]["observation_location"]["city"]);
			this.observation_location_state = (o["current_observation"]["observation_location"]["state"]);
			this.observation_location_country = (o["current_observation"]["observation_location"]["country"]);
			this.observation_location_country_iso3166 = (o["current_observation"]["observation_location"]["country_iso3166"]);
			this.observation_location_latitude = (o["current_observation"]["observation_location"]["latitude"]);
			this.observation_location_longitude = (o["current_observation"]["observation_location"]["longitude"]);
			this.observation_location_elevation = (o["current_observation"]["observation_location"]["elevation"]);
			
//			this.estimated =
			
			this.station_id = (o["current_observation"]["station_id"]);
			this.observation_time = (o["current_observation"]["observation_time"]);
			this.observation_time_rfc822 = (o["current_observation"]["observation_time_rfc822"]);
			this.observation_epoch = (o["current_observation"]["epoch"]);
			this.local_time_rfc822 = (o["current_observation"]["local_time_rfc822"]);
			this.local_epoch = (o["current_observation"]["local_epoch"]);
			this.local_tz_short = (o["current_observation"]["local_tz_short"]);
			this.local_tz_long = (o["current_observation"]["local_tz_long"]);
			this.local_tz_offset = (o["current_observation"]["local_tz_offset"]);
			this.weather = (o["current_observation"]["weather"]);
			this.temperature_string = (o["current_observation"]["temperature_string"]);
			this.temp_f = (o["current_observation"]["temp_f"]);
			this.temp_c = (o["current_observation"]["temp_c"]);
			this.relative_humidity = (o["current_observation"]["relative_humidity"]);
			this.wind_string = (o["current_observation"]["wind_string"]);
			this.wind_dir = (o["current_observation"]["wind_dir"]);
			this.wind_degrees = (o["current_observation"]["wind_degrees"]);
			this.wind_mph = (o["current_observation"]["wind_mph"]);
			this.wind_gust_mph = (o["current_observation"]["wind_gust_mph"]);
			this.wind_kph = (o["current_observation"]["wind_kph"]);
			this.wind_gust_kph = (o["current_observation"]["wind_gust_kph"]);
			this.pressure_mb = (o["current_observation"]["pressure_mb"]);
			this.pressure_in = (o["current_observation"]["pressure_in"]);
			this.pressure_trend = (o["current_observation"]["pressure_trend"]);
			this.dewpoint_string = (o["current_observation"]["dewpoint_string"]);
			this.dewpoint_f = (o["current_observation"]["dewpoint_f"]);
			this.dewpoint_c = (o["current_observation"]["dewpoint_c"]);
			this.heat_index_string = (o["current_observation"]["heat_index_string"]);
			this.heat_index_f = (o["current_observation"]["heat_index_f"]);
			this.heat_index_c = (o["current_observation"]["heat_index_c"]);
			this.windchill_string = (o["current_observation"]["windchill_string"]);
			this.windchill_f = (o["current_observation"]["windchill_f"]);
			this.windchill_c = (o["current_observation"]["windchill_c"]);
			this.feelslike_string = (o["current_observation"]["feelslike_string"]);
			this.feelslike_f = (o["current_observation"]["feelslike_f"]);
			this.feelslike_c = (o["current_observation"]["feelslike_c"]);
			this.visibility_mi = (o["current_observation"]["visibility_mi"]);
			this.visibility_km = (o["current_observation"]["visibility_km"]);
			this.solarradiation = (o["current_observation"]["solarradiation"]);
			this.UV = (o["current_observation"]["UV"]);
			this.precip_1hr_string = (o["current_observation"]["precip_1hr_string"]);
			this.precip_1hr_in = (o["current_observation"]["precip_1hr_in"]);
			this.precip_1hr_metric = (o["current_observation"]["precip_1hr_metric"]);
			this.precip_today_string = (o["current_observation"]["precip_today_string"]);
			this.precip_today_in = (o["current_observation"]["precip_today_in"]);
			this.precip_today_metric = (o["current_observation"]["precip_today_metric"]);
			this.icon = (o["current_observation"]["icon"]);
			this.icon_url = (o["current_observation"]["icon_url"]);
			this.forecast_url = (o["current_observation"]["forecast_url"]);
			this.history_url = (o["current_observation"]["history_url"]);
			this.ob_url = (o["current_observation"]["ob_url"]);

			
		}
	}
	
	
	public class alerts
	{
		JObject o = JObject.Parse(Globals.alerts);
		
		public JToken description { get; set; }
		public JToken date { get; set; }
		public JToken date_epoch { get; set; }
		public JToken expires { get; set; }
		public JToken expires_epoch { get; set; }
		public JToken message { get; set; }
		public JToken phenomena { get; set; }
		public JToken significance { get; set; }
		public JToken tz_short { get; set; }
		public JToken tz_long { get; set; }
		public JToken StormBased { get; set; }
		
		
		
		public alerts(int num)
		{
			
			
			//            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			//            request.ContentType = "application/json";
			//            var response = (HttpWebResponse)request.GetResponse();
			//using (var sr = new StreamReader(response.GetResponseStream()))
			//            {
			//                Globals.forecast10 = sr.ReadToEnd();
			//            }
			//this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
			//this.period = (o["current_observation"]);
			
			//this.length = o["alerts"].HasValues;
			JArray jarr = new JArray(o["alerts"]);
			
			
			if (jarr.Count > 0 )
			{
				this.description = (o["alerts"][num]["description"]);
				this.date = (o["alerts"][num]["date"]);
				this.date_epoch = (o["alerts"][num]["date_epoch"]);
				this.expires = (o["alerts"][num]["expires"]);
				this.expires_epoch = (o["alerts"][num]["expires_epoch"]);
				this.message = (o["alerts"][num]["message"]);
				this.phenomena = (o["alerts"][num]["phenomena"]);
				this.significance = (o["alerts"][num]["significance"]);
				this.tz_short = (o["alerts"][num]["tz_short"]);
				this.tz_long = (o["alerts"][num]["tz_long"]);
				this.StormBased = (o["alerts"][num]["StormBased"]);
			}
			
		}
		
	}
	
	public class almanac
	{
		JObject o = JObject.Parse(Globals.almanac);
		
		public JToken airport_code { get; set; }
		public JToken temp_high_normal_F { get; set; }
		public JToken temp_high_normal_C { get; set; }
		public JToken temp_high_record_F { get; set; }
		public JToken temp_high_record_C { get; set; }
		public JToken temp_high_recordyear { get; set; }
		public JToken temp_low_normal_F	 { get; set; }
		public JToken temp_low_normal_C { get; set; }
		public JToken temp_low_record_F { get; set; }
		public JToken temp_low_record_C { get; set; }
		public JToken temp_low_recordyear { get; set; }
		
		
		
		public almanac(int num)
		{
			
			
			//            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			//            request.ContentType = "application/json";
			//            var response = (HttpWebResponse)request.GetResponse();
			//using (var sr = new StreamReader(response.GetResponseStream()))
			//            {
			//                Globals.forecast10 = sr.ReadToEnd();
			//            }
			//this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
			//this.period = (o["current_observation"]);
			
			
			this.airport_code  = (o["almanac"]["airport_code"]);
			this.temp_high_normal_F  = (o["almanac"]["temp_high"]["normal"]["F"]);
			this.temp_high_normal_C  = (o["almanac"]["temp_high"]["normal"]["C"]);
			this.temp_high_record_F  = (o["almanac"]["temp_high_record_F"]);
			this.temp_high_record_C  = (o["almanac"]["temp_high_record_C"]);
			this.temp_high_recordyear  = (o["almanac"]["temp_high_recordyear"]);
			this.temp_low_normal_F	  = (o["almanac"]["temp_low"]["normal"]["F"]);
			this.temp_low_normal_C  = (o["almanac"]["temp_low"]["normal"]["C"]);
			this.temp_low_record_F  = (o["almanac"]["temp_low_record_F"]);
			this.temp_low_record_C  = (o["almanac"]["temp_low_record_C"]);
			this.temp_low_recordyear  = (o["almanac"]["temp_low_recordyear "]);
			
			
		}
		
	}
	
	
	public class astronomy
	{
		JObject o = JObject.Parse(Globals.astronomy);
		
		public JToken precentIlluminated { get; set; }
		public JToken ageOfMoon { get; set; }
		public JToken phaseofMoon { get; set; }
		public JToken hemisphere { get; set; }
		public JToken current_time_hour { get; set; }
		public JToken current_time_minute { get; set; }
		public JToken sunrise_hour { get; set; }
		public JToken sunrise_minute { get; set; }
		public JToken sunset_hour { get; set; }
		public JToken sunset_minute { get; set; }
		public JToken moonrise_hour { get; set; }
		public JToken moonrise_minute { get; set; }
		public JToken moonset_hour { get; set; }
		public JToken moonset_minute { get; set; }
		
		
		
		public astronomy(int num)
		{
			
			
			//            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			//            request.ContentType = "application/json";
			//            var response = (HttpWebResponse)request.GetResponse();
			//using (var sr = new StreamReader(response.GetResponseStream()))
			//            {
			//                Globals.forecast10 = sr.ReadToEnd();
			//            }
			//this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
			//this.period = (o["current_observation"]);
			
			
			this.precentIlluminated  = (o["moon_phase"]["percentIlluminated"]);
			this.ageOfMoon  = (o["moon_phase"]["ageOfMoon"]);
			this.phaseofMoon  = (o["moon_phase"]["phaseofMoon"]);
			this.hemisphere  = (o["moon_phase"]["hemisphere"]);
			this.current_time_hour  = (o["moon_phase"]["current_time"]["hour"]);
			this.current_time_minute  = (o["moon_phase"]["current_time"]["minute"]);
			this.sunrise_hour  = (o["moon_phase"]["sunrise"]["hour"]);
			this.sunrise_minute  = (o["moon_phase"]["sunrise"]["minute"]);
			this.sunset_hour  = (o["moon_phase"]["sunset"]["hour"]);
			this.sunset_minute  = (o["moon_phase"]["sunset"]["minute"]);

			this.moonrise_hour  = (o["moon_phase"]["moonrise"]["hour"]);
			this.moonrise_minute  = (o["moon_phase"]["moonrise"]["minute"]);
			this.moonset_hour  = (o["moon_phase"]["moonset"]["hour"]);
			this.moonset_minute  = (o["moon_phase"]["moonset"]["minute"]);
			
			
		}
		
	}
	
	public class hurricane
	{
		JObject o = JObject.Parse(Globals.current);
		
		public JToken image_url { get; set; }
		
		
		
		public hurricane(int num)
		{
			
			
			//            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			//            request.ContentType = "application/json";
			//            var response = (HttpWebResponse)request.GetResponse();
			//using (var sr = new StreamReader(response.GetResponseStream()))
			//            {
			//                Globals.forecast10 = sr.ReadToEnd();
			//            }
			//this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
			//this.period = (o["current_observation"]);
			
			
			this.image_url  = (o["current_observation"]["image"]["url"]);
			
			
		}
		
	}
	
	public class geolookup
	{
		JObject o = JObject.Parse(Globals.current);
		
		public JToken image_url { get; set; }
		
		
		
		public geolookup(int num)
		{
			
			
			//            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			//            request.ContentType = "application/json";
			//            var response = (HttpWebResponse)request.GetResponse();
			//using (var sr = new StreamReader(response.GetResponseStream()))
			//            {
			//                Globals.forecast10 = sr.ReadToEnd();
			//            }
			//this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
			//this.period = (o["current_observation"]);
			
			
			this.image_url  = (o["current_observation"]["image"]["url"]);
			
			
		}
		
	}
	
	public class history
	{
		JObject o = JObject.Parse(Globals.current);
		
		public JToken image_url { get; set; }
		
		
		
		public history(int num)
		{
			
			
			//            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			//            request.ContentType = "application/json";
			//            var response = (HttpWebResponse)request.GetResponse();
			//using (var sr = new StreamReader(response.GetResponseStream()))
			//            {
			//                Globals.forecast10 = sr.ReadToEnd();
			//            }
			//this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
			//this.period = (o["current_observation"]);
			
			
			this.image_url  = (o["current_observation"]["image"]["url"]);
			
			
		}
		
	}
	
	public class planner
	{
		JObject o = JObject.Parse(Globals.current);
		
		public JToken image_url { get; set; }
		
		
		
		public planner(int num)
		{
			
			
			//            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			//            request.ContentType = "application/json";
			//            var response = (HttpWebResponse)request.GetResponse();
			//using (var sr = new StreamReader(response.GetResponseStream()))
			//            {
			//                Globals.forecast10 = sr.ReadToEnd();
			//            }
			//this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
			//this.period = (o["current_observation"]);
			
			
			this.image_url  = (o["current_observation"]["image"]["url"]);
			
			
		}
		
	}
	
	public class tide
	{
		JObject o = JObject.Parse(Globals.current);
		
		public JToken image_url { get; set; }
		
		
		
		public tide(int num)
		{
			
			
			//            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			//            request.ContentType = "application/json";
			//            var response = (HttpWebResponse)request.GetResponse();
			//using (var sr = new StreamReader(response.GetResponseStream()))
			//            {
			//                Globals.forecast10 = sr.ReadToEnd();
			//            }
			//this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
			//this.period = (o["current_observation"]);
			
			
			this.image_url  = (o["current_observation"]["image"]["url"]);
			
			
		}
		
	}
	
	public class webcams
	{
		JObject o = JObject.Parse(Globals.current);
		
		public JToken image_url { get; set; }
		
		
		
		public webcams(int num)
		{
			
			
			//            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			//            request.ContentType = "application/json";
			//            var response = (HttpWebResponse)request.GetResponse();
			//using (var sr = new StreamReader(response.GetResponseStream()))
			//            {
			//                Globals.forecast10 = sr.ReadToEnd();
			//            }
			//this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
			//this.period = (o["current_observation"]);
			
			
			this.image_url  = (o["current_observation"]["image"]["url"]);
			
			
		}
		
	}
	
	public class yesterday
	{
		JObject o = JObject.Parse(Globals.current);
		
		public JToken image_url { get; set; }
		
		
		
		public yesterday(int num)
		{
			
			
			//            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
			//            request.ContentType = "application/json";
			//            var response = (HttpWebResponse)request.GetResponse();
			//using (var sr = new StreamReader(response.GetResponseStream()))
			//            {
			//                Globals.forecast10 = sr.ReadToEnd();
			//            }
			//this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
			//this.period = (o["current_observation"]);
			
			
			this.image_url  = (o["current_observation"]["image"]["url"]);
			
			
		}
		
	}
	}
}