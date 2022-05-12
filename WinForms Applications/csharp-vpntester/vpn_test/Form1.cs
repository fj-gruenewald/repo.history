using System;
using System.Collections;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using RestSharp;

namespace vpn_test
{
    public partial class home : MaterialForm
    {
        public home()
        {
            InitializeComponent();

            //initialisieren der Form (Design)
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800, Primary.Blue500, Accent.Blue200, TextShade.WHITE);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttn_start_Click(object sender, EventArgs e)
        {
            string iploc = string.Empty;

            //abrufen der API
            var client = new RestClient("https://ipapi.co/json/");
            var request = new RestRequest()
            {
                Method = Method.GET
            };

            var response = client.Execute(request);

            //formatieren der seriellen Daten
            var dic = JsonConvert.DeserializeObject<IDictionary>(response.Content);

            foreach (var key in dic.Keys)
            {
                iploc += key.ToString() + ":" + dic[key] + "\r\n";
            }

            //eintragen der Daten in variablen (für eventuellen weiteren gebrauch)
            var ip = dic["ip"];
            var city = dic["city"];
            var region = dic["region"];
            var country = dic["country_name"];
            var postal = dic["postal"];
            var latitude = dic["latitude"];
            var longitude = dic["longitude"];
            var asn = dic["asn"];
            var org = dic["org"];

            //setzten des Label Text
            lbl_ip.Text = Convert.ToString(ip);
            lbl_country.Text = Convert.ToString(country);
            lbl_asn.Text = Convert.ToString(asn);
            lbl_city.Text = Convert.ToString(city);
            lbl_coord.Text = Convert.ToString(latitude + " - " + longitude);
            lbl_org.Text = Convert.ToString(org);
            lbl_postal.Text = Convert.ToString(postal);
            lbl_region.Text = Convert.ToString(region);          
        }


    }
}
