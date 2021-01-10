using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;

namespace Client
{
    public partial class LoginForm : Form
    {
        public string url = "http://127.0.0.1:5000/api/v1/[FUNCAO]";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registarBtn_Click(object sender, EventArgs e)
        {
            this.userLabel.Visible = false;
            this.emailTextbox.Visible = false;
            this.emailTextbox.Clear();
            this.passLabel.Visible = false;
            this.passTextbox.Visible = false;
            this.passTextbox.Clear();
            this.loginBtn.Visible = false;
            this.registarBtn.Visible = false;
            this.sairBtn.Visible = false;
            this.Text = "Registar";
            this.userRegistLabel.Visible = true;
            this.emailRegistTextbox.Visible = true;
            this.emailRegistTextbox.Clear();
            this.userRegistTextbox.Clear();
            this.passRegistLabel.Visible = true;
            this.passRegistTextbox.Visible = true;
            this.passRegistTextbox.Clear();
            this.confirmPassRegistTextbox.Visible = true;
            this.confirmPassRegistTextbox.Clear();
            this.confirmPassRegistLabel.Visible = true;
            this.registarRegistBtn.Visible = true;
            this.cancelRegistBtn.Visible = true;
            this.nameRegistLabel.Visible = true;
            this.userRegistTextbox.Visible = true;
        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelRegistBtn_Click(object sender, EventArgs e)
        {
            this.nameRegistLabel.Visible = false;
            this.userRegistTextbox.Visible = false;
            this.userRegistLabel.Visible = false;
            this.emailRegistTextbox.Visible = false;
            this.emailRegistTextbox.Clear();
            this.passRegistLabel.Visible = false;
            this.passRegistTextbox.Visible = false;
            this.passRegistTextbox.Clear();
            this.confirmPassRegistTextbox.Visible = false;
            this.confirmPassRegistTextbox.Clear();
            this.confirmPassRegistLabel.Visible = false;
            this.registarRegistBtn.Visible = false;
            this.cancelRegistBtn.Visible = false;
            this.Text = "Login";
            this.userLabel.Visible = true;
            this.emailTextbox.Visible = true;
            this.emailTextbox.Clear();
            this.passLabel.Visible = true;
            this.passTextbox.Visible = true;
            this.passTextbox.Clear();
            this.loginBtn.Visible = true;
            this.registarBtn.Visible = true;
            this.sairBtn.Visible = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            StringBuilder uri;
            ///Contrução do request
            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "login/");
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("UTF-8").GetBytes(emailTextbox.Text + ":" + passTextbox.Text));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());
            request.Headers.Add("Authorization", "Basic " + encoded);
            
            string result;
            var response = (HttpWebResponse)request.GetResponse();
            StreamReader rdr;
            using (rdr = new StreamReader(response.GetResponseStream()))
            {
                result = rdr.ReadToEnd();
            }
            
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }
            else
            {
                MessageBox.Show("Bem-Vindo!");
                Recipes.Key deserialize = JsonSerializer.Deserialize<Recipes.Key>(result);
                MenuForm menu = new MenuForm(deserialize.token, this, url, deserialize.user_type);
                menu.Show();
                this.Hide();

            }
        }

        private void registarRegistBtn_Click(object sender, EventArgs e)
        {
            registo newReg = new registo();
            string jsonString;


            if(passRegistTextbox.Text==confirmPassRegistTextbox.Text)
            { 

            StringBuilder uri;
            ///Contrução do request
            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[FUNCAO]", "auth/");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.ToString());

            newReg.name = userRegistTextbox.Text;
            newReg.email = emailRegistTextbox.Text;
            newReg.password = passRegistTextbox.Text;

            jsonString = JsonSerializer.Serialize<registo>(newReg);
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
            if (result=="200\n")
            {
                MessageBox.Show("Registado com sucesso!");
                this.userLabel.Visible = true;
                this.emailTextbox.Visible = true;
                this.emailTextbox.Clear();
                this.passLabel.Visible = true;
                this.passTextbox.Visible = true;
                this.passTextbox.Clear();
                this.loginBtn.Visible = true;
                this.registarBtn.Visible = true;
                this.sairBtn.Visible = true;
                this.Text = "Login";
                this.userRegistLabel.Visible = false;
                this.emailRegistTextbox.Visible = false;
                this.emailRegistTextbox.Clear();
                this.passRegistLabel.Visible = false;
                this.passRegistTextbox.Visible = false;
                this.passRegistTextbox.Clear();
                this.confirmPassRegistTextbox.Visible = false;
                this.confirmPassRegistTextbox.Clear();
                this.confirmPassRegistLabel.Visible = false;
                this.registarRegistBtn.Visible = false;
                this.cancelRegistBtn.Visible = false;
                this.nameRegistLabel.Visible = false;
                this.userRegistTextbox.Visible = false;
            }
            else
            {
                MessageBox.Show("Ocorreu um erro no Registo! Tente de novo!");
            }
            }
            else
            {
                MessageBox.Show("As palavras-chaves não coincidem! Tente de novo!");
                passRegistTextbox.Clear();
                confirmPassRegistTextbox.Clear();
            }

        }
    }

    public class registo
    {
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }

    }
}
