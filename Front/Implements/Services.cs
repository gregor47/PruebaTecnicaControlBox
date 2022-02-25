using Front.Interfaces;
using Front.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front.Implements
{
    public class Services : IServices
    {
        private readonly IConfiguration _configuration;
        public Services(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<Oficinas>> GetOficinas(string idOficina)
        {
            string url = _configuration.GetValue<string>("UrlGetOficinas");
            RestClient client = new RestClient(url);
            var request = new RestRequest();
            request.Method = Method.Get;
            client.AddDefaultParameter("id", idOficina);
            var response = await client.GetAsync(request);
            if (!String.IsNullOrEmpty(response.Content))
            {
                return JsonConvert.DeserializeObject<List<Oficinas>>(response.Content);
            }
            else
            {
                return null;
            }
        }
        public async Task<List<Corresponsales>> GetCorresponsales()
        {
            string url = _configuration.GetValue<string>("UrlGetCorresponsales");
            RestClient client = new RestClient(url);
            var request = new RestRequest();
            request.Method = Method.Get;
            var response = await client.GetAsync(request);
            if (!String.IsNullOrEmpty(response.Content))
            {
                return JsonConvert.DeserializeObject<List<Corresponsales>>(response.Content);
            }
            else
            {
                return null;
            }
        }
    }
}
