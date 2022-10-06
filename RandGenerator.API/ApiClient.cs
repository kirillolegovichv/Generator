using RestSharp;

namespace RandGenerator.API
{
    public class ApiClient
    {
        static string baseUrl = "https://127.0.0.1/";

        public ApiClient()
        {

        }

        public void AddSequence(int[] sequence)
        {
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest("sequence", Method.Post);
            request.AddJsonBody(sequence);
        }

        
    }
}
