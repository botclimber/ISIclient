using System;
using System.Windows.Forms;

namespace Client
{
    public partial class MenuForm : Form
    {
        public string token { get; set; }
        public LoginForm login;
        public string url { get; set; }
        public string user_type { get; set; }
        public void saveData(string token_param, LoginForm obj, string url_param, string user_type_param)
        {
            login = obj;
            token = token_param;
            url = url_param;
            user_type = user_type_param;
        }
        public MenuForm(string token_param, LoginForm obj, string url_param, string user_type_param)
        {
            InitializeComponent();
            saveData(token_param, obj, url_param, user_type_param);

        }

        private void saitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void receitasBtn_Click(object sender, EventArgs e)
        {
            
            ReceitasMenu receitas = new ReceitasMenu(this, token, url, user_type);
            receitas.Show();
            this.Hide();
        }

        private void ingredientesBtn_Click(object sender, EventArgs e)
        {
            IngredientesMenu ingredientes = new IngredientesMenu(this, token, url, user_type);
            ingredientes.Show();
            this.Hide();
        }

        private void cervejasBtn_Click(object sender, EventArgs e)
        {
            CervejaMenu cervejaMenu = new CervejaMenu(this, token, url, user_type);
            cervejaMenu.Show();
            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
