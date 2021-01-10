
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientesMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.mostrarIngredienteList = new System.Windows.Forms.ListBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detalhesIngredienteList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Location = new System.Drawing.Point(32, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar Ingredientes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mostrarIngredienteList
            // 
            this.mostrarIngredienteList.FormattingEnabled = true;
            this.mostrarIngredienteList.ItemHeight = 15;
            this.mostrarIngredienteList.Location = new System.Drawing.Point(266, 99);
            this.mostrarIngredienteList.Name = "mostrarIngredienteList";
            this.mostrarIngredienteList.Size = new System.Drawing.Size(483, 379);
            this.mostrarIngredienteList.TabIndex = 2;
            this.mostrarIngredienteList.Visible = false;
            this.mostrarIngredienteList.SelectedIndexChanged += new System.EventHandler(this.mostrarIngredienteList_SelectedIndexChanged);
            // 
            // detalhesIngredienteBtn
            // 
            this.detalhesIngredienteBtn.BackColor = System.Drawing.Color.White;
            this.detalhesIngredienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detalhesIngredienteBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.detalhesIngredienteBtn.Location = new System.Drawing.Point(32, 170);
            this.detalhesIngredienteBtn.Name = "detalhesIngredienteBtn";
            this.detalhesIngredienteBtn.Size = new System.Drawing.Size(112, 40);
            this.detalhesIngredienteBtn.TabIndex = 8;
            this.detalhesIngredienteBtn.Text = "Detalhes Ingrediente";
            this.detalhesIngredienteBtn.UseVisualStyleBackColor = false;
            this.detalhesIngredienteBtn.Click += new System.EventHandler(this.detalhesIngredienteBtn_Click);
            // 
            // validarBtn
            // 
            this.validarBtn.BackColor = System.Drawing.Color.White;
            this.validarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.validarBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.validarBtn.Location = new System.Drawing.Point(369, 516);
            this.validarBtn.Name = "validarBtn";
            this.validarBtn.Size = new System.Drawing.Size(112, 40);
            this.validarBtn.TabIndex = 11;
            this.validarBtn.Text = "Validar";
            this.validarBtn.UseVisualStyleBackColor = false;
            this.validarBtn.Visible = false;
            this.validarBtn.Click += new System.EventHandler(this.validarBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.White;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.infoLabel.Location = new System.Drawing.Point(267, 527);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(26, 17);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "ID:";
            this.infoLabel.Visible = false;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(305, 516);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(58, 36);
            this.infoTextBox.TabIndex = 9;
            this.infoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.infoTextBox.Visible = false;
            // 
            // inserIngredienteBtn
            // 
            this.inserIngredienteBtn.BackColor = System.Drawing.Color.White;
            this.inserIngredienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inserIngredienteBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.inserIngredienteBtn.Location = new System.Drawing.Point(32, 237);
            this.inserIngredienteBtn.Name = "inserIngredienteBtn";
            this.inserIngredienteBtn.Size = new System.Drawing.Size(112, 40);
            this.inserIngredienteBtn.TabIndex = 12;
            this.inserIngredienteBtn.Text = "Inserir Ingrediente";
            this.inserIngredienteBtn.UseVisualStyleBackColor = false;
            this.inserIngredienteBtn.Click += new System.EventHandler(this.inserIngredienteBtn_Click);
            // 
            // nomeTB
            // 
            this.nomeTB.Location = new System.Drawing.Point(348, 202);
            this.nomeTB.Name = "nomeTB";
            this.nomeTB.Size = new System.Drawing.Size(192, 23);
            this.nomeTB.TabIndex = 13;
            this.nomeTB.Visible = false;
            // 
            // tipoTB
            // 
            this.tipoTB.Location = new System.Drawing.Point(348, 260);
            this.tipoTB.Name = "tipoTB";
            this.tipoTB.Size = new System.Drawing.Size(192, 23);
            this.tipoTB.TabIndex = 14;
            this.tipoTB.Visible = false;
            // 
            // caloriasTB
            // 
            this.caloriasTB.Location = new System.Drawing.Point(348, 326);
            this.caloriasTB.Name = "caloriasTB";
            this.caloriasTB.Size = new System.Drawing.Size(192, 23);
            this.caloriasTB.TabIndex = 15;
            this.caloriasTB.Visible = false;
            // 
            // nomeLB
            // 
            this.nomeLB.AutoSize = true;
            this.nomeLB.BackColor = System.Drawing.Color.White;
            this.nomeLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomeLB.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.nomeLB.Location = new System.Drawing.Point(266, 202);
            this.nomeLB.Name = "nomeLB";
            this.nomeLB.Size = new System.Drawing.Size(57, 21);
            this.nomeLB.TabIndex = 16;
            this.nomeLB.Text = "Nome";
            this.nomeLB.Visible = false;
            // 
            // tipoLB
            // 
            this.tipoLB.AutoSize = true;
            this.tipoLB.BackColor = System.Drawing.Color.White;
            this.tipoLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipoLB.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tipoLB.Location = new System.Drawing.Point(266, 265);
            this.tipoLB.Name = "tipoLB";
            this.tipoLB.Size = new System.Drawing.Size(48, 21);
            this.tipoLB.TabIndex = 17;
            this.tipoLB.Text = "Tipo:";
            this.tipoLB.Visible = false;
            // 
            // caloriasLB
            // 
            this.caloriasLB.AutoSize = true;
            this.caloriasLB.BackColor = System.Drawing.Color.White;
            this.caloriasLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caloriasLB.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.caloriasLB.Location = new System.Drawing.Point(266, 326);
            this.caloriasLB.Name = "caloriasLB";
            this.caloriasLB.Size = new System.Drawing.Size(75, 21);
            this.caloriasLB.TabIndex = 18;
            this.caloriasLB.Text = "Calorias:";
            this.caloriasLB.Visible = false;
            // 
            // insrIngredienteBTN
            // 
            this.insrIngredienteBTN.BackColor = System.Drawing.Color.White;
            this.insrIngredienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insrIngredienteBTN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.insrIngredienteBTN.Location = new System.Drawing.Point(369, 516);
            this.insrIngredienteBTN.Name = "insrIngredienteBTN";
            this.insrIngredienteBTN.Size = new System.Drawing.Size(112, 40);
            this.insrIngredienteBTN.TabIndex = 30;
            this.insrIngredienteBTN.Text = "Inserir";
            this.insrIngredienteBTN.UseVisualStyleBackColor = false;
            this.insrIngredienteBTN.Visible = false;
            this.insrIngredienteBTN.Click += new System.EventHandler(this.insrIngredienteBTN_Click);
            // 
            // uppIngredienteBTN
            // 
            this.uppIngredienteBTN.BackColor = System.Drawing.Color.White;
            this.uppIngredienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uppIngredienteBTN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.uppIngredienteBTN.Location = new System.Drawing.Point(32, 300);
            this.uppIngredienteBTN.Name = "uppIngredienteBTN";
            this.uppIngredienteBTN.Size = new System.Drawing.Size(112, 40);
            this.uppIngredienteBTN.TabIndex = 33;
            this.uppIngredienteBTN.Text = "Atualizar Ingrediente";
            this.uppIngredienteBTN.UseVisualStyleBackColor = false;
            this.uppIngredienteBTN.Click += new System.EventHandler(this.uppIngredienteBTN_Click);
            // 
            // uppBTN
            // 
            this.uppBTN.BackColor = System.Drawing.Color.White;
            this.uppBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uppBTN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.uppBTN.Location = new System.Drawing.Point(369, 516);
            this.uppBTN.Name = "uppBTN";
            this.uppBTN.Size = new System.Drawing.Size(112, 40);
            this.uppBTN.TabIndex = 34;
            this.uppBTN.Text = "Atualizar";
            this.uppBTN.UseVisualStyleBackColor = false;
            this.uppBTN.Visible = false;
            this.uppBTN.Click += new System.EventHandler(this.uppBTN_Click);
            // 
            // eliminarIngredienteBTN
            // 
            this.eliminarIngredienteBTN.BackColor = System.Drawing.Color.White;
            this.eliminarIngredienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eliminarIngredienteBTN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.eliminarIngredienteBTN.Location = new System.Drawing.Point(32, 364);
            this.eliminarIngredienteBTN.Name = "eliminarIngredienteBTN";
            this.eliminarIngredienteBTN.Size = new System.Drawing.Size(112, 40);
            this.eliminarIngredienteBTN.TabIndex = 35;
            this.eliminarIngredienteBTN.Text = "Eliminar Ingrediente";
            this.eliminarIngredienteBTN.UseVisualStyleBackColor = false;
            this.eliminarIngredienteBTN.Click += new System.EventHandler(this.eliminarReceitaBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.White;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBTN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.deleteBTN.Location = new System.Drawing.Point(369, 516);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(112, 40);
            this.deleteBTN.TabIndex = 36;
            this.deleteBTN.Text = "Eliminar";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Visible = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // sairBTN
            // 
            this.sairBTN.BackColor = System.Drawing.Color.White;
            this.sairBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sairBTN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.sairBTN.Location = new System.Drawing.Point(32, 527);
            this.sairBTN.Name = "sairBTN";
            this.sairBTN.Size = new System.Drawing.Size(112, 40);
            this.sairBTN.TabIndex = 37;
            this.sairBTN.Text = "Sair";
            this.sairBTN.UseVisualStyleBackColor = false;
            this.sairBTN.Click += new System.EventHandler(this.sairBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // detalhesIngredienteList
            // 
            this.detalhesIngredienteList.FormattingEnabled = true;
            this.detalhesIngredienteList.ItemHeight = 15;
            this.detalhesIngredienteList.Location = new System.Drawing.Point(267, 99);
            this.detalhesIngredienteList.Name = "detalhesIngredienteList";
            this.detalhesIngredienteList.Size = new System.Drawing.Size(482, 379);
            this.detalhesIngredienteList.TabIndex = 40;
            this.detalhesIngredienteList.Visible = false;
            // 
            // IngredientesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(861, 601);
            this.Controls.Add(this.detalhesIngredienteList);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.mostrarIngredienteList);
            this.Controls.Add(this.button1);
            this.Name = "IngredientesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngredientesMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox mostrarIngredienteList;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox detalhesIngredienteList;
    }
}