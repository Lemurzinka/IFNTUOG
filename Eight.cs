using System.Net.Http;
using System.Threading.Tasks;

public class AsyncRequests
{
    private static readonly HttpClient httpClient = new HttpClient();

    public async Task<string[]> MakeRequestsAsync(string url1, string url2, string url3)
    {
        Task<string> task1 = httpClient.GetStringAsync(url1);
        Task<string> task2 = httpClient.GetStringAsync(url2);
        Task<string> task3 = httpClient.GetStringAsync(url3);

        
        string[] results = await Task.WhenAll(task1, task2, task3);

        return results;
    }
    static async Task Main(string[] args)
    {
        AsyncRequests asyncRequests = new AsyncRequests();

       
        string url1 = "https://djinni.co/";
        string url2 = "https://simpsonsua.tv/";
        string url3 = "https://www.englishdom.com/ua/course/";

        try
        {
          
            string[] results = await asyncRequests.MakeRequestsAsync(url1, url2, url3);

          
            Console.WriteLine("Result 1:");
            Console.WriteLine(results[0]);

            Console.WriteLine("\nResult 2:");
            Console.WriteLine(results[1]);

            Console.WriteLine("\nResult 3:");
            Console.WriteLine(results[2]);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
