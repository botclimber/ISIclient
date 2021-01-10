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
            if(user_type=="common")
            {
                inserIngredienteBtn.Visible = false;
                uppIngredienteBTN.Visible = false;
                eliminarIngredienteBTN.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            destaque.Height = button1.Height;
            destaque.Top = button1.Top;

            mostrarIngredienteList.Items.Clear();
            mostrarIngredienteList.Visible = true;
            

            infoLabel.Visible = false;
            infoTextBox.Visible = false;
            infoTextBox.Clear();
            insrIngredienteBTN.Visible = false;
            nomeLB.Visible = false;
            nomeTB.Visible = false;
            nomeTB.Clear();
            tipoLB.Visible = false;
            tipoTB.Visible = false;
            tipoTB.Clear();
            caloriasLB.Visible = false;
            caloriasTB.Visible = false;
            caloriasTB.Clear();
            detalhesIngredienteList.Visible = false;
            uppBTN.Visible = false;
            deleteBTN.Visible = false;
            validarBtn.Visible = false;



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
            destaque.Height = detalhesIngredienteBtn.Height;
            destaque.Top = detalhesIngredienteBtn.Top;


            detalhesIngredienteList.Visible = true;
            detalhesIngredienteList.Items.Clear();
            infoLabel.Visible = true;
            infoTextBox.Visible = true;
            validarBtn.Visible = true;
            mostrarIngredienteList.Visible = false;
            infoTextBox.Clear();
            mostrarIngredienteList.Items.Clear();

           insrIngredienteBTN.Visible = false;
            nomeLB.Visible = false;
            nomeTB.Visible = false;
            nomeTB.Clear();
            tipoLB.Visible = false;
            tipoTB.Visible = false;
            tipoTB.Clear();
            caloriasLB.Visible = false;
            caloriasTB.Visible = false;
            caloriasTB.Clear();
            uppBTN.Visible = false;
            deleteBTN.Visible = false;
            validarBtn.Visible = true;
        }

        private void mostrarIngredienteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = mostrarIngredienteList.SelectedIndex;
            detalhesIngredienteList.Items.Clear();
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
            detalhesIngredienteList.Items.Clear();
            StringBuilder uri;


            uri = new StringBuilder();
            uri.Append(url);
            //string idRecipe=infoTextBox.ToString();
            uri.Replace("[FUNCAO]", "ingredient_details/" + infoTextBox.Text);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            request.Headers.Add("x-access-token", token);
            request.Method = "GET";

            try
            {

            


            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                StreamReader reader = new StreamReader(response.GetResponseStream());



                IngredientsInfo.Root deserialize = JsonSerializer.Deserialize<IngredientsInfo.Root>(reader.ReadToEnd());
                    if(deserialize.content!= null)
                    { 
                IngredientsInfo.Ingredient aux = deserialize.content[0].ingredient;

                var receitasstring =new System.Text.StringBuilder();

                foreach (IngredientsInfo.Recipe x in deserialize.content[0].recipes)
                    receitasstring.Append(x.title + ", ");

                detalhesIngredienteList.Items.Add("Nome: " + aux.name);
                detalhesIngredienteList.Items.Add("Tipo: " + aux.type);
                detalhesIngredienteList.Items.Add("Calorias: " + aux.calories);
                detalhesIngredienteList.Items.Add("Receitas: " + receitasstring);

                detalhesIngredienteList.Text = aux.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Este ID não existe! Tente de novo!");
                    }

                }
            }
            catch (Exception mensage)
            {
                MessageBox.Show("Ocorreu um erro!\n" + mensage);
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


            try
            {

            

            var response = (HttpWebResponse)request.GetResponse();

            string result;
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                result = rdr.ReadToEnd();
            }
            MessageBox.Show(result);

            }
            catch (Exception mensage)
            {
                MessageBox.Show("Ocorreu um erro!\n" + mensage);
            }
        }

        private void uppIngredienteBTN_Click(object sender, EventArgs e)
        {
            destaque.Height = uppIngredienteBTN.Height;
            destaque.Top = uppIngredienteBTN.Top;

            infoLabel.Visible = true;
            infoTextBox.Visible = true;
            infoTextBox.Clear();
            insrIngredienteBTN.Visible = false;
            nomeLB.Visible = true;
            nomeTB.Visible = true;
            nomeTB.Clear();
            tipoLB.Visible = true;
            tipoTB.Visible = true;
            tipoTB.Clear();
            caloriasLB.Visible = true;
            caloriasTB.Visible = true;
            caloriasTB.Clear();
            detalhesIngredienteList.Visible = false;
            uppBTN.Visible = true;
            deleteBTN.Visible = false;
            validarBtn.Visible = false;
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

            if(nomeTB.Text == "")
            {
                nomeTB.Text = null;
            }
            else
            {
                newRec.nome_ingredient = nomeTB.Text;
            }

            if (tipoTB.Text == "")
            {
                tipoTB.Text = null;
            }
            else
            {
                newRec.type = tipoTB.Text;
            }

            if (caloriasTB.Text == "")
            {
                caloriasTB.Text = null;
            }
            else
            {
                newRec.calories = Int32.Parse(caloriasTB.Text);
            }

            
            
           

            jsonString = JsonSerializer.Serialize<inserIngrediente>(newRec);
            byte[] postBytes = Encoding.UTF8.GetBytes(jsonString);

            request.Method = "PUT";
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";
            request.ContentLength = postBytes.Length;

            Stream requestStream = request.GetRequestStream();
            // send it
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();

            try
            {

            

            var response = (HttpWebResponse)request.GetResponse();

            string result;
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                result = rdr.ReadToEnd();
            }
            MessageBox.Show(result);
            }
            catch (Exception mensage)
            {
                MessageBox.Show("Ocorreu um erro!\n" + mensage);
            }

        }

        private void eliminarReceitaBTN_Click(object sender, EventArgs e)
        {
            destaque.Height = eliminarIngredienteBTN.Height;
            destaque.Top = eliminarIngredienteBTN.Top;

            infoLabel.Visible = true;
            infoTextBox.Visible = true;

            mostrarIngredienteList.Items.Clear();
            mostrarIngredienteList.Visible = false;
            infoTextBox.Clear();
            insrIngredienteBTN.Visible = false;
            nomeLB.Visible = false;
            nomeTB.Visible = false;
            nomeTB.Clear();
            tipoLB.Visible = false;
            tipoTB.Visible = false;
            tipoTB.Clear();
            caloriasLB.Visible = false;
            caloriasTB.Visible = false;
            caloriasTB.Clear();
            detalhesIngredienteList.Visible = false;
            uppBTN.Visible = false;
            deleteBTN.Visible = true; 
            validarBtn.Visible = false;


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

            try
            {

            var response = (HttpWebResponse)request.GetResponse();

            string result;
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                result = rdr.ReadToEnd();
            }
            MessageBox.Show(result);
            }
            catch (Exception mensage)
            {
                MessageBox.Show("Ocorreu um erro!\n" + mensage);
            }
        }

        private void sairBTN_Click(object sender, EventArgs e)
        {
            destaque.Height = sairBTN.Height;
            destaque.Top = sairBTN.Top;

            this.Close();
            menu.Show();
        }

        private void inserIngredienteBtn_Click(object sender, EventArgs e)
        {
            destaque.Height = inserIngredienteBtn.Height;
            destaque.Top = inserIngredienteBtn.Top;

            infoLabel.Visible = false;
            infoTextBox.Visible = false;
            infoTextBox.Clear();
            insrIngredienteBTN.Visible = true;
            nomeLB.Visible = true;
            nomeTB.Visible = true;
            nomeTB.Clear();
            tipoLB.Visible = true;
            tipoTB.Visible = true;
            tipoTB.Clear();
            caloriasLB.Visible = true;
            caloriasTB.Visible = true;
            caloriasTB.Clear();
            detalhesIngredienteList.Visible = false;
            mostrarIngredienteList.Visible = false;
            uppBTN.Visible = false;
            deleteBTN.Visible = false;
            validarBtn.Visible = false;

        }
    }

    public class inserIngrediente
    {
        public string nome_ingredient { get; set; }
        public string type { get; set; }
        public int calories { get; set; }
    }
}
