using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Windows;

namespace PildorasInformaticas.ApiRest
{
    class DBApi
    {
        const string URLBASE = "https://robmax.com.mx/demos/vehicles/api";
        const string TOKEN = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2Njc5MzM3ODksImRhdGEiOnsiaWQiOiIxIiwibm9tYnJlIjoiVVJJRUwifX0.x1QZXCDYsK9YovsmJm3Xh3_CrkqfaL94QjILhUn7Mh4";

        public dynamic Post(string url, string json, string autorizacion = null)
        {
            try
            {
                var client = new RestClient(URLBASE + url);
                var request = new RestRequest(Method.POST);
                //request.AddHeader("content-type", "application/json");
                request.AddHeader("X-Token-Vehicular", TOKEN);
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                if (autorizacion != null)
                {
                    request.AddHeader("Authorization", autorizacion);
                }

                IRestResponse response = client.Execute(request);
                dynamic datos = JsonConvert.DeserializeObject(response.Content);
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }



        public dynamic Get(string url, bool token = false)
        {
            try
            {
                var client = new RestClient(URLBASE + url);
                //var request = new RestRequest($"/item/{id}", Method.GET);
                var request = new RestRequest(Method.GET);

                if (token)
                {
                    request.AddHeader("X-Token-Vehicular", TOKEN);
                }

                IRestResponse response = client.Execute(request);
                return JsonConvert.DeserializeObject(response.Content);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
           
        }
    }
}
