using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Text.Json;
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
        public static Recipes.Result individual { get; set; }
        public int opcSeg { get; set; }
        public void saveData(MenuForm menu_param, string chave, string url_param, string user_type_param)
        {
            menu = menu_param;
            token = chave;
            url = url_param;
            user_type = user_type_param;
            tabela = new Recipes.Root();
            individual = new Recipes.Result();
            opcSeg = 0;
            
        }
        public ReceitasMenu(MenuForm menu_param, string chave, string url_param, string user_type_param)
        {
            InitializeComponent();
            saveData(menu_param, chave, url_param, user_type_param);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoTextBox.Clear();
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
            request.Method = "GET";


            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                StreamReader reader = new StreamReader(response.GetResponseStream());



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
            if (opcSeg == 0)
            {
                int index = mostrarReceitasList.SelectedIndex;
                detalhesReceitaList.Visible = true;
                infoLabel.Visible = true;
                infoTextBox.Visible = true;
                validarBtn.Visible = true;
                infoTextBox.Text = tabela.results[index].id.ToString();
                mostrarReceitasList.Items.Clear();
                mostrarReceitasList.Visible = false;
            }
            else
            {
                detalhesReceitaList.Visible = true;
                infoLabel.Visible = true;
                infoTextBox.Visible = true;
                validarBtn.Visible = true;
                infoTextBox.Text = individual.id.ToString();
                mostrarReceitasList.Items.Clear();
                mostrarReceitasList.Visible = false;

                opcSeg = 0;
            }
            
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
            request.Method = "GET";

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
            infoTextBox.Clear();
            mostrarReceitasList.Items.Clear();
            detalhesReceitaList.Items.Clear();
        }

        private void receitaAleatoriaBtn_Click(object sender, EventArgs e)
        {
            detalhesReceitaList.Visible = false;
            infoLabel.Visible = false;
            infoTextBox.Visible = false;
            validarBtn.Visible = false;
            mostrarReceitasList.Visible = true;
            infoTextBox.Clear();
            mostrarReceitasList.Items.Clear();
            detalhesReceitaList.Items.Clear();

            StringBuilder uri;


            uri = new StringBuilder();
            uri.Append(url);
            //string idRecipe=infoTextBox.ToString();
            uri.Replace("[FUNCAO]", "rand_recipes/");
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

                Recipes obj = new Recipes();


                Recipes.Result deserialize = JsonSerializer.Deserialize<Recipes.Result>(reader.ReadToEnd());
                opcSeg = 1;
                individual = deserialize;
                mostrarReceitasList.Items.Add(deserialize.id + "\t" + deserialize.title);
            }

        }

        private void insrReceitaBTN_Click(object sender, EventArgs e)
        {
            inserReceita newRec = new inserReceita();
            string jsonString;

            StringBuilder uri;
            ///Contrução do request
            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "create_recipe/");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            request.Headers.Add("x-access-token", token);


            newRec.title = titleTB.Text;
            string s = iDIngredTB.Text;
            newRec.id = Array.ConvertAll(s.Split(','), int.Parse);
            s = amountTB.Text;
            newRec.amount = Array.ConvertAll(s.Split(','), int.Parse);
            newRec.instructions = instrucoesTB.Text;
            newRec.calories = Int32.Parse(caloriasTB.Text);
            newRec.fiber = Int32.Parse(fiberTB.Text);
            newRec.protein = Int32.Parse(proteinTB.Text);
            newRec.fat = Int32.Parse(fatTB.Text);
            newRec.carbs = Int32.Parse(carbsTB.Text);
            newRec.url_image = urlImgTB.Text;
            newRec.visible = "1";
            newRec.description = descricaoTB.Text;

            jsonString = JsonSerializer.Serialize<inserReceita>(newRec);
            byte[] postBytes = Encoding.UTF8.GetBytes(jsonString);

            request.Method = "POST";
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";
            request.ContentLength = postBytes.Length;

            Stream requestStream = request.GetRequestStream();
            // send it
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();


            var response = (HttpWebResponse)request.GetResponse();

            string result;
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                result = rdr.ReadToEnd();
            }
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inserReceita newRec = new inserReceita();
            //newRec.title = null;
            //newRec.id = null;
            //newRec.amount = null;
            //newRec.calories = null;
            //newRec.fiber = null;
            //newRec.protein = null;
            //newRec.fat = null;
            //newRec.carbs = null;
            //newRec.url_image = null;
            //newRec.visible = null;
            //newRec.description = null;
            
        
        string jsonString;

            StringBuilder uri;
            ///Contrução do request
            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "update_recipe/" + infoTextBox.Text);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            request.Headers.Add("x-access-token", token);


            newRec.title = titleTB.Text;
            //string s = iDIngredTB.Text;
            //newRec.id = Array.ConvertAll(s.Split(','), int.Parse);
            //s = amountTB.Text;
            //newRec.amount = Array.ConvertAll(s.Split(','), int.Parse);
            //newRec.instructions = instrucoesTB.Text;
            //newRec.calories = Int32.Parse(caloriasTB.Text);
            //newRec.fiber = Int32.Parse(fiberTB.Text);
            //newRec.protein = Int32.Parse(proteinTB.Text);
            //newRec.fat = Int32.Parse(fatTB.Text);
            //newRec.carbs = Int32.Parse(carbsTB.Text);
            //newRec.url_image = urlImgTB.Text;
            //newRec.visible = "1";
            //newRec.description = descricaoTB.Text;

            jsonString = JsonSerializer.Serialize<inserReceita>(newRec);
            byte[] postBytes = Encoding.UTF8.GetBytes(jsonString);

            request.Method = "PUT";
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";
            request.ContentLength = postBytes.Length;

            Stream requestStream = request.GetRequestStream();
            // send it
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();


            var response = (HttpWebResponse)request.GetResponse();

            string result;
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                result = rdr.ReadToEnd();
            }
            MessageBox.Show(result);
        }

        private void uppReceitaBTN_Click(object sender, EventArgs e)
        {
            infoLabel.Visible = true;
            infoTextBox.Visible = true;
        }

        private void inserReceitaBtn_Click(object sender, EventArgs e)
        {

        }

        private void eliminarReceitaBTN_Click(object sender, EventArgs e)
        {
            infoLabel.Visible = true;
            infoTextBox.Visible = true;

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            StringBuilder uri;
            ///Contrução do request
            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "delete_recipe/" + infoTextBox.Text);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            request.Headers.Add("x-access-token", token);

           
            request.Method = "DELETE";

            

            var response = (HttpWebResponse)request.GetResponse();

            string result;
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                result = rdr.ReadToEnd();
            }
            MessageBox.Show(result);



        }

        private void sairBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }
    }

    public class inserReceita
    {
        public string title { get; set; }
        public int[] id { get; set; }
        public int[] amount { get; set; }
        public string instructions { get; set; }
        public int calories { get; set; }
        public int fiber { get; set; }
        public int protein { get; set; }
        public int fat { get; set; }
        public int carbs { get; set; }
        public string url_image { get; set; }
        public string visible { get; set; }
        public string description { get; set; }

    }
}
