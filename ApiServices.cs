using Newtonsoft.Json;

namespace PostListApp;

public class ApiService
{
    public async Task<List<Root>> GetPosts()
    {
        var httpClient = new HttpClient();
        var response = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
        return JsonConvert.DeserializeObject<List<Root>>(response);
    }
}