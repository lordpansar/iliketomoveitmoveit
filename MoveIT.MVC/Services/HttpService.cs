using MoveIT.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MoveIT.MVC.Services
{
    public class HttpService
    {
        static HttpClient client;

        public HttpService()
        {
            client = new HttpClient();
        }

        public async void CreateProductAsync(OfferViewModel offer)
        {
            client.BaseAddress = new Uri("https://localhost:44338/api/offer");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage response = await client.PostAsJsonAsync(
            //    "api/products", offer);

            var response = await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            //return response.Headers.Location;
        }
    }
}
