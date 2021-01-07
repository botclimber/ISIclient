using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;

namespace Client
{
    public partial class ReceitasMenu : Form
    {
        MenuForm menu;
        public string token { get; set; }
        public string url { get; set; }
        public string user_type { get; set; }
        public static Recipes.Root tabela { get; set; }
        public void saveData(MenuForm menu_param, string chave, string url_param, string user_type_param)
        {
            menu = menu_param;
            token = chave;
            url = url_param;
            user_type = user_type_param;
            tabela = new Recipes.Root();
        }
        public ReceitasMenu(MenuForm menu_param, string chave, string url_param, string user_type_param)
        {
            InitializeComponent();
            saveData(menu_param, chave, url_param, user_type_param);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarReceitasList.Visible = true;
            detalhesReceitaList.Visible = false;
            infoLabel.Visible = false;
            infoTextBox.Visible = false;
            validarBtn.Visible = false;
            mostrarReceitasList.Items.Clear();
            detalhesReceitaList.Items.Clear();


            StringBuilder uri;


            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "recipes");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Headers.Add("x-access-token", token);


            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                StreamReader reader = new StreamReader(response.GetResponseStream());

                Recipes obj = new Recipes();


                Recipes.Root deserialize = JsonSerializer.Deserialize<Recipes.Root>(reader.ReadToEnd());

                foreach (Recipes.Result x in deserialize.results)
                {
                    mostrarReceitasList.Items.Add(x.id + "\t" + x.title);
                }

                tabela = deserialize;

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get id from listBox
            int index = mostrarReceitasList.SelectedIndex;
            detalhesReceitaList.Visible = true;
            infoLabel.Visible = true;
            infoTextBox.Visible = true;
            validarBtn.Visible = true;
            infoTextBox.Text = tabela.results[index].id.ToString();
            mostrarReceitasList.Items.Clear();
            mostrarReceitasList.Visible = false;
        }

        private void validarBtn_Click(object sender, EventArgs e)
        {
            StringBuilder uri;


            uri = new StringBuilder();
            uri.Append(url);
            //string idRecipe=infoTextBox.ToString();
            uri.Replace("[FUNCAO]", "recipe_details/" + infoTextBox.Text);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            request.Headers.Add("x-access-token", token);


            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                StreamReader reader = new StreamReader(response.GetResponseStream());

                RecipeInfo obj = new RecipeInfo();


                RecipeInfo.Root deserialize = JsonSerializer.Deserialize<RecipeInfo.Root>(reader.ReadToEnd());
                
                detalhesReceitaList.Items.Add(deserialize.recipe[0].title);
                detalhesReceitaList.Items.Add(deserialize.recipe[0].instructions);

                foreach(RecipeInfo.Ingredient x in deserialize.recipe[1].ingredients)
                {
                    detalhesReceitaList.Items.Add(x.name);
                }

            }
        }

        private void detalhesReceitaBtn_Click(object sender, EventArgs e)
        {
            detalhesReceitaList.Visible = true;
            infoLabel.Visible = true;
            infoTextBox.Visible = true;
            validarBtn.Visible = true;
            mostrarReceitasList.Visible = false;
            mostrarReceitasList.Items.Clear();
            detalhesReceitaList.Items.Clear();
        }
    }
}
