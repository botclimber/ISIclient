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
            tabelaCerveja.Visible = true;



            StringBuilder uri;


            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "beers/chicken");
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



                Beer.Root deserialize = JsonSerializer.Deserialize<Beer.Root>(reader.ReadToEnd());


                tabelaCerveja.DataSource = deserialize.beers.beer_info;
            }
        }

        private void sairBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }
    }
}
