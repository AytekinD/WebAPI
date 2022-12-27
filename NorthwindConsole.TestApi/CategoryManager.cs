using System.Net.Http.Headers;

namespace NorthwindConsole.TestApi
{
	public class CategoryManager
	{
		List<Category> _categories;
		HttpClient _httpClient;
		public CategoryManager()
		{
			_categories = new();
			_httpClient = new();
			_httpClient.BaseAddress = new Uri(GenelTanimlar.NorthwindApiUri);
			_httpClient.DefaultRequestHeaders.Accept.Clear();
			_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

		}
		//static async Task<List<Category>> GetAllCategories()
		//{
		//	try
		//	{

		//		var responce = _httpClient.GetAsync("api/categories").Result;
		//		if (responce.IsSuccessStatusCode)
		//		{
		//			var content = await responce.Content.ReadAsStringAsync();
		//			_categories = new List<Category>();
		//			_categories = JsonConvert.DeserializeObject<List<Category>>(content);
		//		}
		//	}
		//	catch (Exception ex)
		//	{

		//		await Console.Out.WriteLineAsync(ex.Message);
		//	}
		//	return _categories;
		//}
	}
}
