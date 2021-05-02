using ClimApp.Models;
using ClimApp.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;




namespace ClimApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
                        
            var response = await RestHelper.GetAll();
            txtResult.Text = RestHelper.BeautifyJson(response);

        }

        private async void button2_Click(object sender, EventArgs e)
        {
                       
            var response = await RestHelper.Get(txtCiudad.Text);
            txtResult.Text = RestHelper.BeautifyJson(response);

        }
    }
}
