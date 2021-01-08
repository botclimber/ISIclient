
namespace Client
{
    partial class IngredientesMenu
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
            this.mostrarIngredienteList = new System.Windows.Forms.ListBox();
            this.detalhesIngredienteList = new System.Windows.Forms.ListBox();
            this.detalhesIngredienteBtn = new System.Windows.Forms.Button();
            this.validarBtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.inserIngredienteBtn = new System.Windows.Forms.Button();
            this.nomeTB = new System.Windows.Forms.TextBox();
            this.tipoTB = new System.Windows.Forms.TextBox();
            this.caloriasTB = new System.Windows.Forms.TextBox();
            this.nomeLB = new System.Windows.Forms.Label();
            this.tipoLB = new System.Windows.Forms.Label();
            this.caloriasLB = new System.Windows.Forms.Label();
            this.insrIngredienteBTN = new System.Windows.Forms.Button();
            this.uppIngredienteBTN = new System.Windows.Forms.Button();
            this.uppBTN = new System.Windows.Forms.Button();
            this.eliminarIngredienteBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.sairBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar Ingredientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mostrarIngredienteList
            // 
            this.mostrarIngredienteList.FormattingEnabled = true;
            this.mostrarIngredienteList.ItemHeight = 15;
            this.mostrarIngredienteList.Location = new System.Drawing.Point(348, 23);
            this.mostrarIngredienteList.Name = "mostrarIngredienteList";
            this.mostrarIngredienteList.Size = new System.Drawing.Size(483, 379);
            this.mostrarIngredienteList.TabIndex = 2;
            this.mostrarIngredienteList.Visible = false;
            this.mostrarIngredienteList.SelectedIndexChanged += new System.EventHandler(this.mostrarIngredienteList_SelectedIndexChanged);
            // 
            // detalhesIngredienteList
            // 
            this.detalhesIngredienteList.AllowDrop = true;
            this.detalhesIngredienteList.FormattingEnabled = true;
            this.detalhesIngredienteList.HorizontalScrollbar = true;
            this.detalhesIngredienteList.ItemHeight = 15;
            this.detalhesIngredienteList.Location = new System.Drawing.Point(487, 23);
            this.detalhesIngredienteList.MultiColumn = true;
            this.detalhesIngredienteList.Name = "detalhesIngredienteList";
            this.detalhesIngredienteList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.detalhesIngredienteList.ScrollAlwaysVisible = true;
            this.detalhesIngredienteList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.detalhesIngredienteList.Size = new System.Drawing.Size(483, 379);
            this.detalhesIngredienteList.TabIndex = 7;
            this.detalhesIngredienteList.Visible = false;
            // 
            // detalhesIngredienteBtn
            // 
            this.detalhesIngredienteBtn.Location = new System.Drawing.Point(12, 108);
            this.detalhesIngredienteBtn.Name = "detalhesIngredienteBtn";
            this.detalhesIngredienteBtn.Size = new System.Drawing.Size(143, 50);
            this.detalhesIngredienteBtn.TabIndex = 8;
            this.detalhesIngredienteBtn.Text = "Detalhes Ingrediente";
            this.detalhesIngredienteBtn.UseVisualStyleBackColor = true;
            this.detalhesIngredienteBtn.Click += new System.EventHandler(this.detalhesIngredienteBtn_Click);
            // 
            // validarBtn
            // 
            this.validarBtn.Location = new System.Drawing.Point(441, 428);
            this.validarBtn.Name = "validarBtn";
            this.validarBtn.Size = new System.Drawing.Size(64, 23);
            this.validarBtn.TabIndex = 11;
            this.validarBtn.Text = "Validar";
            this.validarBtn.UseVisualStyleBackColor = true;
            this.validarBtn.Visible = false;
            this.validarBtn.Click += new System.EventHandler(this.validarBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(359, 431);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(21, 15);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "ID:";
            this.infoLabel.Visible = false;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(386, 428);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(49, 23);
            this.infoTextBox.TabIndex = 9;
            this.infoTextBox.Visible = false;
            // 
            // inserIngredienteBtn
            // 
            this.inserIngredienteBtn.Location = new System.Drawing.Point(12, 193);
            this.inserIngredienteBtn.Name = "inserIngredienteBtn";
            this.inserIngredienteBtn.Size = new System.Drawing.Size(143, 50);
            this.inserIngredienteBtn.TabIndex = 12;
            this.inserIngredienteBtn.Text = "Inserir Ingrediente";
            this.inserIngredienteBtn.UseVisualStyleBackColor = true;
            // 
            // nomeTB
            // 
            this.nomeTB.Location = new System.Drawing.Point(1114, 68);
            this.nomeTB.Name = "nomeTB";
            this.nomeTB.Size = new System.Drawing.Size(99, 23);
            this.nomeTB.TabIndex = 13;
            // 
            // tipoTB
            // 
            this.tipoTB.Location = new System.Drawing.Point(1114, 126);
            this.tipoTB.Name = "tipoTB";
            this.tipoTB.Size = new System.Drawing.Size(99, 23);
            this.tipoTB.TabIndex = 14;
            // 
            // caloriasTB
            // 
            this.caloriasTB.Location = new System.Drawing.Point(1114, 192);
            this.caloriasTB.Name = "caloriasTB";
            this.caloriasTB.Size = new System.Drawing.Size(99, 23);
            this.caloriasTB.TabIndex = 15;
            // 
            // nomeLB
            // 
            this.nomeLB.AutoSize = true;
            this.nomeLB.Location = new System.Drawing.Point(1032, 68);
            this.nomeLB.Name = "nomeLB";
            this.nomeLB.Size = new System.Drawing.Size(40, 15);
            this.nomeLB.TabIndex = 16;
            this.nomeLB.Text = "Nome";
            // 
            // tipoLB
            // 
            this.tipoLB.AutoSize = true;
            this.tipoLB.Location = new System.Drawing.Point(1032, 131);
            this.tipoLB.Name = "tipoLB";
            this.tipoLB.Size = new System.Drawing.Size(33, 15);
            this.tipoLB.TabIndex = 17;
            this.tipoLB.Text = "Tipo:";
            // 
            // caloriasLB
            // 
            this.caloriasLB.AutoSize = true;
            this.caloriasLB.Location = new System.Drawing.Point(1032, 192);
            this.caloriasLB.Name = "caloriasLB";
            this.caloriasLB.Size = new System.Drawing.Size(52, 15);
            this.caloriasLB.TabIndex = 18;
            this.caloriasLB.Text = "Calorias:";
            // 
            // insrIngredienteBTN
            // 
            this.insrIngredienteBTN.Location = new System.Drawing.Point(1068, 244);
            this.insrIngredienteBTN.Name = "insrIngredienteBTN";
            this.insrIngredienteBTN.Size = new System.Drawing.Size(97, 23);
            this.insrIngredienteBTN.TabIndex = 30;
            this.insrIngredienteBTN.Text = "Inserir";
            this.insrIngredienteBTN.UseVisualStyleBackColor = true;
            this.insrIngredienteBTN.Click += new System.EventHandler(this.insrIngredienteBTN_Click);
            // 
            // uppIngredienteBTN
            // 
            this.uppIngredienteBTN.Location = new System.Drawing.Point(12, 285);
            this.uppIngredienteBTN.Name = "uppIngredienteBTN";
            this.uppIngredienteBTN.Size = new System.Drawing.Size(143, 50);
            this.uppIngredienteBTN.TabIndex = 33;
            this.uppIngredienteBTN.Text = "Atualizar Ingrediente";
            this.uppIngredienteBTN.UseVisualStyleBackColor = true;
            this.uppIngredienteBTN.Click += new System.EventHandler(this.uppIngredienteBTN_Click);
            // 
            // uppBTN
            // 
            this.uppBTN.Location = new System.Drawing.Point(348, 484);
            this.uppBTN.Name = "uppBTN";
            this.uppBTN.Size = new System.Drawing.Size(106, 33);
            this.uppBTN.TabIndex = 34;
            this.uppBTN.Text = "Atualizar";
            this.uppBTN.UseVisualStyleBackColor = true;
            this.uppBTN.Click += new System.EventHandler(this.uppBTN_Click);
            // 
            // eliminarIngredienteBTN
            // 
            this.eliminarIngredienteBTN.Location = new System.Drawing.Point(12, 373);
            this.eliminarIngredienteBTN.Name = "eliminarIngredienteBTN";
            this.eliminarIngredienteBTN.Size = new System.Drawing.Size(143, 50);
            this.eliminarIngredienteBTN.TabIndex = 35;
            this.eliminarIngredienteBTN.Text = "Eliminar Ingrediente";
            this.eliminarIngredienteBTN.UseVisualStyleBackColor = true;
            this.eliminarIngredienteBTN.Click += new System.EventHandler(this.eliminarReceitaBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(476, 484);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(106, 33);
            this.deleteBTN.TabIndex = 36;
            this.deleteBTN.Text = "Eliminar";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // sairBTN
            // 
            this.sairBTN.Location = new System.Drawing.Point(12, 456);
            this.sairBTN.Name = "sairBTN";
            this.sairBTN.Size = new System.Drawing.Size(143, 50);
            this.sairBTN.TabIndex = 37;
            this.sairBTN.Text = "Sair";
            this.sairBTN.UseVisualStyleBackColor = true;
            this.sairBTN.Click += new System.EventHandler(this.sairBTN_Click);
            // 
            // IngredientesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 556);
            this.Controls.Add(this.sairBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.eliminarIngredienteBTN);
            this.Controls.Add(this.uppBTN);
            this.Controls.Add(this.uppIngredienteBTN);
            this.Controls.Add(this.insrIngredienteBTN);
            this.Controls.Add(this.caloriasLB);
            this.Controls.Add(this.tipoLB);
            this.Controls.Add(this.nomeLB);
            this.Controls.Add(this.caloriasTB);
            this.Controls.Add(this.tipoTB);
            this.Controls.Add(this.nomeTB);
            this.Controls.Add(this.inserIngredienteBtn);
            this.Controls.Add(this.validarBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.detalhesIngredienteBtn);
            this.Controls.Add(this.detalhesIngredienteList);
            this.Controls.Add(this.mostrarIngredienteList);
            this.Controls.Add(this.button1);
            this.Name = "IngredientesMenu";
            this.Text = "IngredientesMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox mostrarIngredienteList;
        private System.Windows.Forms.ListBox detalhesIngredienteList;
        private System.Windows.Forms.Button detalhesIngredienteBtn;
        private System.Windows.Forms.Button validarBtn;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button inserIngredienteBtn;
        private System.Windows.Forms.TextBox nomeTB;
        private System.Windows.Forms.TextBox tipoTB;
        private System.Windows.Forms.TextBox caloriasTB;
        private System.Windows.Forms.Label nomeLB;
        private System.Windows.Forms.Label tipoLB;
        private System.Windows.Forms.Label caloriasLB;
        private System.Windows.Forms.Button insrIngredienteBTN;
        private System.Windows.Forms.Button uppIngredienteBTN;
        private System.Windows.Forms.Button uppBTN;
        private System.Windows.Forms.Button eliminarIngredienteBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button sairBTN;
    }
}