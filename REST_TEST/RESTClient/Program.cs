using SharedLibrary;

namespace RESTClient

{
    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();
      private static string baseUrl = "https://localhost:5291/WeatherForecastController/";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
