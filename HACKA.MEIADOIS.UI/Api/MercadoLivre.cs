using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Api
{
    public class MercadoLivre
    {

        public List<Result> ObterResultados()
        {
            var client = new RestClient("https://api.mercadolibre.com");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("sites/MLB/search?q={busca}", Method.GET);
            request.AddParameter("official_store", "all"); // adds to POST or URL querystring based on Method
            request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

            // easily add HTTP Headers
            request.AddHeader("header", "value");

            // add files to upload (works with compatible verbs)
            //request.AddFile(path);

            // execute the request
            //IRestResponse response = client.Execute(request);
            //var content = response.Content; // raw content as string


            //Console.WriteLine("Content: " + content);
            // or automatically deserialize result
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            RestResponse<Resultados> resultados = (RestResponse<Resultados>)client.Execute<Resultados>(request);
            if (resultados.IsSuccessful)
            {
                List<Result> listResult = resultados.Data.results as List<Result>;
                return listResult;
                /*
                var name = resultados.Data.results;
                var mean = resultados.Data.results.Select(i => i.price).Average();
                Console.WriteLine(mean);
                return true;*/
            }
            else
            {
                return null;
            }

            // easy async support
            // client.ExecuteAsync(request, response => {
            //    Console.WriteLine(response.Content);
            // });

            // async with deserialization
            // var asyncHandle = client.ExecuteAsync<Person>(request, response => {
            //     Console.WriteLine(response.Data.Name);
            //  });

            // abort the request on demand
            //asyncHandle.Abort();
        }

       

    }
}