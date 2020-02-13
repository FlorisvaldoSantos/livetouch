using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WebApplication2.Models;


namespace WebApplication2
{
    public class Servico
    {
        private static string urlBase;
        private static string urlLogin;
        private static string urlCarros;
        private static string conteudo;

        public Servico()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");

            var config = builder.Build();

            urlBase = config.GetSection("API_Access:UrlBase").Value;
            urlLogin = config.GetSection("API_Access:UrlLogin").Value;
            urlCarros = config.GetSection("API_Access:UrlCarros").Value;

        }

        public Usuario GetUsuario(Login model)
        {
            Usuario usuarioLogado = new Usuario();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respToken = client.PostAsync(
                    urlBase + urlLogin, new StringContent(
                        JsonConvert.SerializeObject(new
                        {
                            username = model.Username,
                            password = model.Password

                        }), Encoding.UTF8, "application/json")).Result;

                if (respToken.StatusCode == HttpStatusCode.OK)
                {
                    conteudo = respToken.Content.ReadAsStringAsync().Result;
                    usuarioLogado = JsonConvert.DeserializeObject<Usuario>(conteudo);
                }
            }

            return usuarioLogado;
        }
        
        public List<Carro> GetCarros(Usuario model)
        {
            List<Carro> lstCarros = new List<Carro>();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                HttpResponseMessage respToken = new HttpResponseMessage();
                client.DefaultRequestHeaders.Add("Authorization", $" Bearer {model.Token}");
                respToken = client.GetAsync(urlBase + urlCarros).Result;
                    
                if (respToken.StatusCode == HttpStatusCode.OK)
                {
                    conteudo = respToken.Content.ReadAsStringAsync().Result;
                    lstCarros = JsonConvert.DeserializeObject<List<Carro>>(conteudo);
                }
            }

            return lstCarros;
        }
    }
}
