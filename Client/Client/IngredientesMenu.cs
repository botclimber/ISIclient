using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Client
{
    public partial class IngredientesMenu : Form
    {
        MenuForm menu;
        public string token { get; set; }
        public string url { get; set; }
        public string user_type { get; set; }
        public static Ingredients.Root tabela { get; set; }

        public void saveData(MenuForm menu_param, string chave, string url_param, string user_type_param)
        {
            menu = menu_param;
            token = chave;
            url = url_param;
            user_type = user_type_param;
            tabela = new Ingredients.Root();
        }
        public IngredientesMenu(MenuForm menu_param, string chave, string url_param, string user_type_param)
        {
            InitializeComponent();
            saveData(menu_param, chave, url_param, user_type_param);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarIngredienteList.Items.Clear();
            detalhesIngredienteList.Items.Clear();
            mostrarIngredienteList.Visible = true;
            


            StringBuilder uri;


            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "ingredients/");
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



                Ingredients.Root deserialize = JsonSerializer.Deserialize<Ingredients.Root>(reader.ReadToEnd());

                foreach (Ingredients.Content x in deserialize.content)
                {
                    mostrarIngredienteList.Items.Add(x.id + "\t" + x.name);
                }

                tabela = deserialize;

            }
        }

        private void detalhesIngredienteBtn_Click(object sender, EventArgs e)
        {
            detalhesIngredienteList.Visible = true;
            infoLabel.Visible = true;
            infoTextBox.Visible = true;
            validarBtn.Visible = true;
            mostrarIngredienteList.Visible = false;
            infoTextBox.Clear();
            mostrarIngredienteList.Items.Clear();
            detalhesIngredienteList.Items.Clear();
        }

        private void mostrarIngredienteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = mostrarIngredienteList.SelectedIndex;
            detalhesIngredienteList.Visible = true;
            infoLabel.Visible = true;
            infoTextBox.Visible = true;
            validarBtn.Visible = true;
            infoTextBox.Text = tabela.content[index].id.ToString();
            mostrarIngredienteList.Items.Clear();
            mostrarIngredienteList.Visible = false;
        }

        private void validarBtn_Click(object sender, EventArgs e)
        {
            StringBuilder uri;


            uri = new StringBuilder();
            uri.Append(url);
            //string idRecipe=infoTextBox.ToString();
            uri.Replace("[FUNCAO]", "ingredient_details/" + infoTextBox.Text);
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



                IngredientsInfo.Root deserialize = JsonSerializer.Deserialize<IngredientsInfo.Root>(reader.ReadToEnd());

                foreach (IngredientsInfo.Content x in deserialize.content)
                {
                    detalhesIngredienteList.Items.Add(x.ingredient.id);
                    detalhesIngredienteList.Items.Add(x.ingredient.name);
                    detalhesIngredienteList.Items.Add(x.ingredient.calories);
                }

            }
        }

        private void insrIngredienteBTN_Click(object sender, EventArgs e)
        {
            inserIngrediente newRec = new inserIngrediente();
            string jsonString;

            StringBuilder uri;
            ///Contrução do request
            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "create_ingredient/");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            request.Headers.Add("x-access-token", token);


            newRec.nome_ingredient = nomeTB.Text;
            newRec.type = tipoTB.Text;
            newRec.calories= Int32.Parse(caloriasTB.Text);

            jsonString = JsonSerializer.Serialize<inserIngrediente>(newRec);
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

        private void uppIngredienteBTN_Click(object sender, EventArgs e)
        {
            infoLabel.Visible = true;
            infoTextBox.Visible = true;
        }

        private void uppBTN_Click(object sender, EventArgs e)
        {
            inserIngrediente newRec = new inserIngrediente();
            


            string jsonString;

            StringBuilder uri;
            ///Contrução do request
            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "update_ingredient/" + infoTextBox.Text);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            request.Headers.Add("x-access-token", token);


            newRec.nome_ingredient = nomeTB.Text;
            //newRec.calories = Int32.Parse(caloriasTB.Text);
           

            jsonString = JsonSerializer.Serialize<inserIngrediente>(newRec);
            MessageBox.Show(jsonString);
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
            uri.Replace("[FUNCAO]", "delete_ingredient/" + infoTextBox.Text);
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

    public class inserIngrediente
    {
        public string nome_ingredient { get; set; }
        public string type { get; set; }
        public int calories { get; set; }
    }
}
