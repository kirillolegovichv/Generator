using RestSharp;

namespace RandGenerator.API
{
    public class ApiClient
    {
        private string _baseUrl = "https://127.0.0.1/";

        public ApiClient()
        {

        }

        public void AddSequence(int[] sequence)
        {
            RestClient client = new RestClient(_baseUrl);
            RestRequest request = new RestRequest();
            request.AddJsonBody(sequence);
            RestResponse response = client.Post(request);
        }

        
    }
}
