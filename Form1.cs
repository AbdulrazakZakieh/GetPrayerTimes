using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettıngPrayersTime
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void getDataButton_Click(object sender, EventArgs e)
		{
			HttpClient httpClient = new HttpClient();
			string endpoint = "http://api.aladhan.com/v1/calendarByCity";
			string parameters = "?city=London&country=United%20Kingdom&method=2&month=04&year=2020";
			string uri = endpoint + parameters;
			HttpResponseMessage responseMessage =  httpClient.GetAsync(uri).Result;
			string response = responseMessage.Content.ReadAsStringAsync().Result;
			dynamic resultObject =  JsonConvert.DeserializeObject(response);
			fajrLabel.Text = resultObject.data[0].timings.Fajr;
			zuhrLabel.Text = resultObject.data[0].timings.Dhuhr;
			asrLabel.Text = resultObject.data[0].timings.Asr;
			maghrebLabel.Text = resultObject.data[0].timings.Maghrib;
			ishaLabel.Text = resultObject.data[0].timings.Isha;
		}
	}
}
