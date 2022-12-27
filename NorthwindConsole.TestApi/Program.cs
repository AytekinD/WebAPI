using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace NorthwindConsole.TestApi
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			try
			{
				HttpClient client = new HttpClient();
				client.BaseAddress = new Uri(GenelTanimlar.NorthwindApiUri);
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				var responce = client.GetAsync("api/categories").Result;
				if (responce.IsSuccessStatusCode)
				{
					var content = await responce.Content.ReadAsStringAsync();
					List<Category> categories = new List<Category>();
					categories = JsonConvert.DeserializeObject<List<Category>>(content);
				}
			}
			catch (Exception ex)
			{

				await Console.Out.WriteLineAsync(ex.Message);
			}

		}
	}
}