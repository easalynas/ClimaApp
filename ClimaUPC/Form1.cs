using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ClimaUPC
{
    public partial class Form1 : Form
    {

        //RestService _restService;
        public Form1()
        {
            InitializeComponent();
           

           // _restService = new RestService();
            
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {

            var response = await RestHelper.GetAll();

            dataGridView1.DataSource = response;

           // if (!string.IsNullOrWhiteSpace(txtCiudad.Text))
            //{
              //  PostViewModel weatherData = await _restService.GetWeatherDataAsync(GenerateRequestUri(Constantes.OpenWeatherMapEndpoint));
                
                //dataGridView1.DataSource = weatherData;
           // }

            //string respuesta = await GetHttp();
            //List<PostViewModel> lst = JsonConvert.DeserializeObject<List<PostViewModel>>(respuesta);
            //dataGridView1.DataSource = lst;
        }

        //string GenerateRequestUri(string endpoint)
        //{
         //   string requestUri = endpoint;
          //  requestUri += $"?q={txtCiudad.Text}";
          //  requestUri += "&units=imperial";
          //  requestUri += $"&APPID={Constantes.OpenWeatherMapAPIKey}";
          //  return requestUri;
        //}

       
    }
}
