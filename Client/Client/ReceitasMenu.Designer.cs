
namespace Client
{
    partial class ReceitasMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.detalhesReceitaBtn = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.validarBtn = new System.Windows.Forms.Button();
            this.mostrarReceitasList = new System.Windows.Forms.ListBox();
            this.detalhesReceitaList = new System.Windows.Forms.ListBox();
            this.receitaAleatoriaBtn = new System.Windows.Forms.Button();
            this.inserReceitaBtn = new System.Windows.Forms.Button();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.instrucoesTB = new System.Windows.Forms.TextBox();
            this.caloriasTB = new System.Windows.Forms.TextBox();
            this.fiberTB = new System.Windows.Forms.TextBox();
            this.proteinTB = new System.Windows.Forms.TextBox();
            this.fatTB = new System.Windows.Forms.TextBox();
            this.carbsTB = new System.Windows.Forms.TextBox();
            this.urlImgTB = new System.Windows.Forms.TextBox();
            this.descricaoTB = new System.Windows.Forms.TextBox();
            this.tituloLB = new System.Windows.Forms.Label();
            this.idIngredientesLB = new System.Windows.Forms.Label();
            this.instrucoesLB = new System.Windows.Forms.Label();
            this.caloriasLB = new System.Windows.Forms.Label();
            this.fibrasLB = new System.Windows.Forms.Label();
            this.proteinaLB = new System.Windows.Forms.Label();
            this.fatLB = new System.Windows.Forms.Label();
            this.carbsLB = new System.Windows.Forms.Label();
            this.urlImgLB = new System.Windows.Forms.Label();
            this.descricaoLB = new System.Windows.Forms.Label();
            this.insrReceitaBTN = new System.Windows.Forms.Button();
            this.iDIngredTB = new System.Windows.Forms.TextBox();
            this.idIngredLB = new System.Windows.Forms.Label();
            this.uppReceitaBTN = new System.Windows.Forms.Button();
            this.uppBTN = new System.Windows.Forms.Button();
            this.eliminarReceitaBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.sairBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar Receitas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detalhesReceitaBtn
            // 
            this.detalhesReceitaBtn.Location = new System.Drawing.Point(34, 119);
            this.detalhesReceitaBtn.Name = "detalhesReceitaBtn";
            this.detalhesReceitaBtn.Size = new System.Drawing.Size(123, 51);
            this.detalhesReceitaBtn.TabIndex = 2;
            this.detalhesReceitaBtn.Text = "Detalhes de Receita";
            this.detalhesReceitaBtn.UseVisualStyleBackColor = true;
            this.detalhesReceitaBtn.Click += new System.EventHandler(this.detalhesReceitaBtn_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(327, 442);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(49, 23);
            this.infoTextBox.TabIndex = 3;
            this.infoTextBox.Visible = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(300, 445);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(21, 15);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "ID:";
            this.infoLabel.Visible = false;
            // 
            // validarBtn
            // 
            this.validarBtn.Location = new System.Drawing.Point(382, 442);
            this.validarBtn.Name = "validarBtn";
            this.validarBtn.Size = new System.Drawing.Size(64, 23);
            this.validarBtn.TabIndex = 5;
            this.validarBtn.Text = "Validar";
            this.validarBtn.UseVisualStyleBackColor = true;
            this.validarBtn.Visible = false;
            this.validarBtn.Click += new System.EventHandler(this.validarBtn_Click);
            // 
            // mostrarReceitasList
            // 
            this.mostrarReceitasList.FormattingEnabled = true;
            this.mostrarReceitasList.ItemHeight = 15;
            this.mostrarReceitasList.Location = new System.Drawing.Point(300, 39);
            this.mostrarReceitasList.Name = "mostrarReceitasList";
            this.mostrarReceitasList.Size = new System.Drawing.Size(483, 379);
            this.mostrarReceitasList.TabIndex = 1;
            this.mostrarReceitasList.Visible = false;
            this.mostrarReceitasList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // detalhesReceitaList
            // 
            this.detalhesReceitaList.AllowDrop = true;
            this.detalhesReceitaList.FormattingEnabled = true;
            this.detalhesReceitaList.HorizontalScrollbar = true;
            this.detalhesReceitaList.ItemHeight = 15;
            this.detalhesReceitaList.Location = new System.Drawing.Point(454, 39);
            this.detalhesReceitaList.MultiColumn = true;
            this.detalhesReceitaList.Name = "detalhesReceitaList";
            this.detalhesReceitaList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.detalhesReceitaList.ScrollAlwaysVisible = true;
            this.detalhesReceitaList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.detalhesReceitaList.Size = new System.Drawing.Size(483, 379);
            this.detalhesReceitaList.TabIndex = 6;
            this.detalhesReceitaList.Visible = false;
            // 
            // receitaAleatoriaBtn
            // 
            this.receitaAleatoriaBtn.Location = new System.Drawing.Point(34, 219);
            this.receitaAleatoriaBtn.Name = "receitaAleatoriaBtn";
            this.receitaAleatoriaBtn.Size = new System.Drawing.Size(123, 51);
            this.receitaAleatoriaBtn.TabIndex = 7;
            this.receitaAleatoriaBtn.Text = "Receita Aleatória";
            this.receitaAleatoriaBtn.UseVisualStyleBackColor = true;
            this.receitaAleatoriaBtn.Click += new System.EventHandler(this.receitaAleatoriaBtn_Click);
            // 
            // inserReceitaBtn
            // 
            this.inserReceitaBtn.Location = new System.Drawing.Point(34, 315);
            this.inserReceitaBtn.Name = "inserReceitaBtn";
            this.inserReceitaBtn.Size = new System.Drawing.Size(123, 51);
            this.inserReceitaBtn.TabIndex = 8;
            this.inserReceitaBtn.Text = "Inserir Receita";
            this.inserReceitaBtn.UseVisualStyleBackColor = true;
            this.inserReceitaBtn.Click += new System.EventHandler(this.inserReceitaBtn_Click);
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(1123, 23);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(102, 23);
            this.titleTB.TabIndex = 9;
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(1124, 107);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(102, 23);
            this.amountTB.TabIndex = 10;
            // 
            // instrucoesTB
            // 
            this.instrucoesTB.Location = new System.Drawing.Point(1124, 147);
            this.instrucoesTB.Name = "instrucoesTB";
            this.instrucoesTB.Size = new System.Drawing.Size(102, 23);
            this.instrucoesTB.TabIndex = 11;
            // 
            // caloriasTB
            // 
            this.caloriasTB.Location = new System.Drawing.Point(1124, 199);
            this.caloriasTB.Name = "caloriasTB";
            this.caloriasTB.Size = new System.Drawing.Size(102, 23);
            this.caloriasTB.TabIndex = 12;
            // 
            // fiberTB
            // 
            this.fiberTB.Location = new System.Drawing.Point(1124, 259);
            this.fiberTB.Name = "fiberTB";
            this.fiberTB.Size = new System.Drawing.Size(102, 23);
            this.fiberTB.TabIndex = 13;
            // 
            // proteinTB
            // 
            this.proteinTB.Location = new System.Drawing.Point(1124, 308);
            this.proteinTB.Name = "proteinTB";
            this.proteinTB.Size = new System.Drawing.Size(102, 23);
            this.proteinTB.TabIndex = 14;
            // 
            // fatTB
            // 
            this.fatTB.Location = new System.Drawing.Point(1124, 337);
            this.fatTB.Name = "fatTB";
            this.fatTB.Size = new System.Drawing.Size(102, 23);
            this.fatTB.TabIndex = 15;
            // 
            // carbsTB
            // 
            this.carbsTB.Location = new System.Drawing.Point(1124, 378);
            this.carbsTB.Name = "carbsTB";
            this.carbsTB.Size = new System.Drawing.Size(102, 23);
            this.carbsTB.TabIndex = 16;
            // 
            // urlImgTB
            // 
            this.urlImgTB.Location = new System.Drawing.Point(1124, 427);
            this.urlImgTB.Name = "urlImgTB";
            this.urlImgTB.Size = new System.Drawing.Size(102, 23);
            this.urlImgTB.TabIndex = 17;
            // 
            // descricaoTB
            // 
            this.descricaoTB.Location = new System.Drawing.Point(1124, 476);
            this.descricaoTB.Name = "descricaoTB";
            this.descricaoTB.Size = new System.Drawing.Size(102, 23);
            this.descricaoTB.TabIndex = 18;
            // 
            // tituloLB
            // 
            this.tituloLB.AutoSize = true;
            this.tituloLB.Location = new System.Drawing.Point(1050, 26);
            this.tituloLB.Name = "tituloLB";
            this.tituloLB.Size = new System.Drawing.Size(40, 15);
            this.tituloLB.TabIndex = 19;
            this.tituloLB.Text = "Titulo:";
            // 
            // idIngredientesLB
            // 
            this.idIngredientesLB.AutoSize = true;
            this.idIngredientesLB.Location = new System.Drawing.Point(952, 110);
            this.idIngredientesLB.Name = "idIngredientesLB";
            this.idIngredientesLB.Size = new System.Drawing.Size(140, 15);
            this.idIngredientesLB.TabIndex = 20;
            this.idIngredientesLB.Text = "Quantidade Ingredientes:";
            // 
            // instrucoesLB
            // 
            this.instrucoesLB.AutoSize = true;
            this.instrucoesLB.Location = new System.Drawing.Point(1025, 155);
            this.instrucoesLB.Name = "instrucoesLB";
            this.instrucoesLB.Size = new System.Drawing.Size(64, 15);
            this.instrucoesLB.TabIndex = 21;
            this.instrucoesLB.Text = "Instruções:";
            // 
            // caloriasLB
            // 
            this.caloriasLB.AutoSize = true;
            this.caloriasLB.Location = new System.Drawing.Point(1051, 202);
            this.caloriasLB.Name = "caloriasLB";
            this.caloriasLB.Size = new System.Drawing.Size(52, 15);
            this.caloriasLB.TabIndex = 22;
            this.caloriasLB.Text = "Calorias:";
            // 
            // fibrasLB
            // 
            this.fibrasLB.AutoSize = true;
            this.fibrasLB.Location = new System.Drawing.Point(1051, 262);
            this.fibrasLB.Name = "fibrasLB";
            this.fibrasLB.Size = new System.Drawing.Size(41, 15);
            this.fibrasLB.TabIndex = 23;
            this.fibrasLB.Text = "Fibras:";
            // 
            // proteinaLB
            // 
            this.proteinaLB.AutoSize = true;
            this.proteinaLB.Location = new System.Drawing.Point(1051, 311);
            this.proteinaLB.Name = "proteinaLB";
            this.proteinaLB.Size = new System.Drawing.Size(54, 15);
            this.proteinaLB.TabIndex = 24;
            this.proteinaLB.Text = "Proteina:";
            // 
            // fatLB
            // 
            this.fatLB.AutoSize = true;
            this.fatLB.Location = new System.Drawing.Point(1051, 340);
            this.fatLB.Name = "fatLB";
            this.fatLB.Size = new System.Drawing.Size(53, 15);
            this.fatLB.TabIndex = 25;
            this.fatLB.Text = "Gordura:";
            // 
            // carbsLB
            // 
            this.carbsLB.AutoSize = true;
            this.carbsLB.Location = new System.Drawing.Point(998, 386);
            this.carbsLB.Name = "carbsLB";
            this.carbsLB.Size = new System.Drawing.Size(120, 15);
            this.carbsLB.TabIndex = 26;
            this.carbsLB.Text = "Hidratos de Carbono:";
            // 
            // urlImgLB
            // 
            this.urlImgLB.AutoSize = true;
            this.urlImgLB.Location = new System.Drawing.Point(1051, 430);
            this.urlImgLB.Name = "urlImgLB";
            this.urlImgLB.Size = new System.Drawing.Size(48, 15);
            this.urlImgLB.TabIndex = 27;
            this.urlImgLB.Text = "url Img:";
            // 
            // descricaoLB
            // 
            this.descricaoLB.AutoSize = true;
            this.descricaoLB.Location = new System.Drawing.Point(1051, 479);
            this.descricaoLB.Name = "descricaoLB";
            this.descricaoLB.Size = new System.Drawing.Size(61, 15);
            this.descricaoLB.TabIndex = 28;
            this.descricaoLB.Text = "Descricao:";
            // 
            // insrReceitaBTN
            // 
            this.insrReceitaBTN.Location = new System.Drawing.Point(1128, 528);
            this.insrReceitaBTN.Name = "insrReceitaBTN";
            this.insrReceitaBTN.Size = new System.Drawing.Size(97, 23);
            this.insrReceitaBTN.TabIndex = 29;
            this.insrReceitaBTN.Text = "Inserir";
            this.insrReceitaBTN.UseVisualStyleBackColor = true;
            this.insrReceitaBTN.Click += new System.EventHandler(this.insrReceitaBTN_Click);
            // 
            // iDIngredTB
            // 
            this.iDIngredTB.Location = new System.Drawing.Point(1123, 65);
            this.iDIngredTB.Name = "iDIngredTB";
            this.iDIngredTB.Size = new System.Drawing.Size(102, 23);
            this.iDIngredTB.TabIndex = 30;
            // 
            // idIngredLB
            // 
            this.idIngredLB.AutoSize = true;
            this.idIngredLB.Location = new System.Drawing.Point(998, 73);
            this.idIngredLB.Name = "idIngredLB";
            this.idIngredLB.Size = new System.Drawing.Size(88, 15);
            this.idIngredLB.TabIndex = 31;
            this.idIngredLB.Text = "Id Ingredientes:";
            // 
            // uppReceitaBTN
            // 
            this.uppReceitaBTN.Location = new System.Drawing.Point(34, 414);
            this.uppReceitaBTN.Name = "uppReceitaBTN";
            this.uppReceitaBTN.Size = new System.Drawing.Size(123, 51);
            this.uppReceitaBTN.TabIndex = 32;
            this.uppReceitaBTN.Text = "Atualizar Receita";
            this.uppReceitaBTN.UseVisualStyleBackColor = true;
            this.uppReceitaBTN.Click += new System.EventHandler(this.uppReceitaBTN_Click);
            // 
            // uppBTN
            // 
            this.uppBTN.Location = new System.Drawing.Point(315, 497);
            this.uppBTN.Name = "uppBTN";
            this.uppBTN.Size = new System.Drawing.Size(106, 33);
            this.uppBTN.TabIndex = 33;
            this.uppBTN.Text = "Atualizar";
            this.uppBTN.UseVisualStyleBackColor = true;
            this.uppBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // eliminarReceitaBTN
            // 
            this.eliminarReceitaBTN.Location = new System.Drawing.Point(34, 528);
            this.eliminarReceitaBTN.Name = "eliminarReceitaBTN";
            this.eliminarReceitaBTN.Size = new System.Drawing.Size(123, 51);
            this.eliminarReceitaBTN.TabIndex = 34;
            this.eliminarReceitaBTN.Text = "Eliminar Receita";
            this.eliminarReceitaBTN.UseVisualStyleBackColor = true;
            this.eliminarReceitaBTN.Click += new System.EventHandler(this.eliminarReceitaBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(443, 497);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(106, 33);
            this.deleteBTN.TabIndex = 35;
            this.deleteBTN.Text = "Eliminar";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // sairBTN
            // 
            this.sairBTN.Location = new System.Drawing.Point(34, 615);
            this.sairBTN.Name = "sairBTN";
            this.sairBTN.Size = new System.Drawing.Size(123, 51);
            this.sairBTN.TabIndex = 36;
            this.sairBTN.Text = "Sair";
            this.sairBTN.UseVisualStyleBackColor = true;
            this.sairBTN.Click += new System.EventHandler(this.sairBTN_Click);
            // 
            // ReceitasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 693);
            this.Controls.Add(this.sairBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.eliminarReceitaBTN);
            this.Controls.Add(this.uppBTN);
            this.Controls.Add(this.uppReceitaBTN);
            this.Controls.Add(this.idIngredLB);
            this.Controls.Add(this.iDIngredTB);
            this.Controls.Add(this.insrReceitaBTN);
            this.Controls.Add(this.descricaoLB);
            this.Controls.Add(this.urlImgLB);
            this.Controls.Add(this.carbsLB);
            this.Controls.Add(this.fatLB);
            this.Controls.Add(this.proteinaLB);
            this.Controls.Add(this.fibrasLB);
            this.Controls.Add(this.caloriasLB);
            this.Controls.Add(this.instrucoesLB);
            this.Controls.Add(this.idIngredientesLB);
            this.Controls.Add(this.tituloLB);
            this.Controls.Add(this.descricaoTB);
            this.Controls.Add(this.urlImgTB);
            this.Controls.Add(this.carbsTB);
            this.Controls.Add(this.fatTB);
            this.Controls.Add(this.proteinTB);
            this.Controls.Add(this.fiberTB);
            this.Controls.Add(this.caloriasTB);
            this.Controls.Add(this.instrucoesTB);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.inserReceitaBtn);
            this.Controls.Add(this.receitaAleatoriaBtn);
            this.Controls.Add(this.detalhesReceitaList);
            this.Controls.Add(this.validarBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.detalhesReceitaBtn);
            this.Controls.Add(this.mostrarReceitasList);
            this.Controls.Add(this.button1);
            this.Name = "ReceitasMenu";
            this.Text = "ReceiasMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button detalhesReceitaBtn;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button validarBtn;
        private System.Windows.Forms.ListBox mostrarReceitasList;
        private System.Windows.Forms.ListBox detalhesReceitaList;
        private System.Windows.Forms.Button receitaAleatoriaBtn;
        private System.Windows.Forms.Button inserReceitaBtn;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.TextBox instrucoesTB;
        private System.Windows.Forms.TextBox caloriasTB;
        private System.Windows.Forms.TextBox fiberTB;
        private System.Windows.Forms.TextBox proteinTB;
        private System.Windows.Forms.TextBox fatTB;
        private System.Windows.Forms.TextBox carbsTB;
        private System.Windows.Forms.TextBox urlImgTB;
        private System.Windows.Forms.TextBox descricaoTB;
        private System.Windows.Forms.Label tituloLB;
        private System.Windows.Forms.Label idIngredientesLB;
        private System.Windows.Forms.Label instrucoesLB;
        private System.Windows.Forms.Label caloriasLB;
        private System.Windows.Forms.Label fibrasLB;
        private System.Windows.Forms.Label proteinaLB;
        private System.Windows.Forms.Label fatLB;
        private System.Windows.Forms.Label carbsLB;
        private System.Windows.Forms.Label urlImgLB;
        private System.Windows.Forms.Label descricaoLB;
        private System.Windows.Forms.Button insrReceitaBTN;
        private System.Windows.Forms.TextBox iDIngredTB;
        private System.Windows.Forms.Label idIngredLB;
        private System.Windows.Forms.Button uppReceitaBTN;
        private System.Windows.Forms.Button uppBTN;
        private System.Windows.Forms.Button eliminarReceitaBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button sairBTN;
    }
}