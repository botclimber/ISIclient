using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Client
{
    public partial class CervejaMenu : Form
    {
        MenuForm menu;
        public string token { get; set; }
        public string url { get; set; }
        public string user_type { get; set; }
        //public static Ingredients.Root tabela { get; set; }

        public void saveData(MenuForm menu_param, string chave, string url_param, string user_type_param)
        {
            menu = menu_param;
            token = chave;
            url = url_param;
            user_type = user_type_param;
            //tabela = new Ingredients.Root();
        }

        public CervejaMenu(MenuForm menu_param, string chave, string url_param, string user_type_param)
        {
            InitializeComponent();
            saveData(menu_param, chave, url_param, user_type_param);
        }

        private void mostrarCervejaBTN_Click(object sender, EventArgs e)
        {
            destaque1.Height = mostrarCervejaBTN.Height;
            destaque1.Top = mostrarCervejaBTN.Top;

            validarBtn.Visible = false;
            pesquisarBTN.Visible = false;
            infoTextBox.Visible = false;
            infoLabel.Visible = false;


            tabelaCerveja.Visible = true;



            StringBuilder uri;


            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "beers/");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Headers.Add("x-access-token", token);
            request.Method = "GET";

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                StreamReader reader = new StreamReader(response.GetResponseStream());



                BeerAll.Root deserialize = JsonSerializer.Deserialize<BeerAll.Root>(reader.ReadToEnd());


                tabelaCerveja.DataSource = deserialize.results;
            }
        }

        private void sairBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            destaque1.Height = button1.Height;
            destaque1.Top = button1.Top;

            infoTextBox.Clear();
            tabelaCerveja.Visible = true;
            infoLabel.Text = "ID:";
            infoLabel.Visible = true;
            infoTextBox.Visible = true;
            validarBtn.Visible = true;
            pesquisarBTN.Visible = false;


        }

        private void validarBtn_Click(object sender, EventArgs e)
        {



            StringBuilder uri;


            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "beers/" + infoTextBox.Text);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Headers.Add("x-access-token", token);
            request.Method = "GET";

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                StreamReader reader = new StreamReader(response.GetResponseStream());



                Beer.RootBeerDetail deserialize = JsonSerializer.Deserialize<Beer.RootBeerDetail>(reader.ReadToEnd());


                tabelaCerveja.DataSource = deserialize.results;
            }
        }

        private void cervejaAleatoriaBTN_Click(object sender, EventArgs e)
        {
            destaque1.Height = cervejaAleatoriaBTN.Height;
            destaque1.Top = cervejaAleatoriaBTN.Top;

            tabelaCerveja.Visible = true;

            validarBtn.Visible = false;
            pesquisarBTN.Visible = false;
            infoTextBox.Visible = false;
            infoLabel.Visible = false;

            StringBuilder uri;


            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "beers/random");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Headers.Add("x-access-token", token);
            request.Method = "GET";

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                StreamReader reader = new StreamReader(response.GetResponseStream());



                Beer.RootBeerRandom deserialize = JsonSerializer.Deserialize<Beer.RootBeerRandom>(reader.ReadToEnd());


                tabelaCerveja.DataSource = deserialize.results;

            }
        }

        private void cervejaRecBTN_Click(object sender, EventArgs e)
        {
            destaque1.Height = cervejaRecBTN.Height;
            destaque1.Top = cervejaRecBTN.Top;

            infoTextBox.Visible = true;

            validarBtn.Visible = false;
            pesquisarBTN.Visible = true;
            infoTextBox.Visible = true;
            infoTextBox.Clear();
            infoLabel.Visible = true;
            infoLabel.Text = "Comida:";
        }

        private void pesquisarBTN_Click(object sender, EventArgs e)
        {
            tabelaCerveja.Visible = true;

            StringBuilder uri;


            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "beers/" + infoTextBox.Text);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Headers.Add("x-access-token", token);
            request.Method = "GET";

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                StreamReader reader = new StreamReader(response.GetResponseStream());



                Beer.RootRecomended deserialize = JsonSerializer.Deserialize<Beer.RootRecomended>(reader.ReadToEnd());


                tabelaCerveja.DataSource = deserialize.beers.beer_info;

            }
        }
    }
}
