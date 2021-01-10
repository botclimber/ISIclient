
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
            this.detalhesIngredienteList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.destaque = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mostrarIngredienteList
            // 
            this.mostrarIngredienteList.FormattingEnabled = true;
            this.mostrarIngredienteList.ItemHeight = 15;
            this.mostrarIngredienteList.Location = new System.Drawing.Point(265, 77);
            this.mostrarIngredienteList.Name = "mostrarIngredienteList";
            this.mostrarIngredienteList.Size = new System.Drawing.Size(483, 379);
            this.mostrarIngredienteList.TabIndex = 2;
            this.mostrarIngredienteList.Visible = false;
            this.mostrarIngredienteList.SelectedIndexChanged += new System.EventHandler(this.mostrarIngredienteList_SelectedIndexChanged);
            // 
            // detalhesIngredienteBtn
            // 
            this.detalhesIngredienteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.detalhesIngredienteBtn.FlatAppearance.BorderSize = 0;
            this.detalhesIngredienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detalhesIngredienteBtn.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detalhesIngredienteBtn.ForeColor = System.Drawing.Color.White;
            this.detalhesIngredienteBtn.Image = ((System.Drawing.Image)(resources.GetObject("detalhesIngredienteBtn.Image")));
            this.detalhesIngredienteBtn.Location = new System.Drawing.Point(0, 175);
            this.detalhesIngredienteBtn.Name = "detalhesIngredienteBtn";
            this.detalhesIngredienteBtn.Size = new System.Drawing.Size(220, 75);
            this.detalhesIngredienteBtn.TabIndex = 8;
            this.detalhesIngredienteBtn.Text = "Detalhes";
            this.detalhesIngredienteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.detalhesIngredienteBtn.UseVisualStyleBackColor = false;
            this.detalhesIngredienteBtn.Click += new System.EventHandler(this.detalhesIngredienteBtn_Click);
            // 
            // validarBtn
            // 
            this.validarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.validarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.validarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validarBtn.Font = new System.Drawing.Font("Inter Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.validarBtn.ForeColor = System.Drawing.Color.White;
            this.validarBtn.Location = new System.Drawing.Point(148, 7);
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
            this.infoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.infoLabel.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(45, 18);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(24, 16);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "ID:";
            this.infoLabel.Visible = false;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(84, 7);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(58, 40);
            this.infoTextBox.TabIndex = 9;
            this.infoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.infoTextBox.Visible = false;
            // 
            // inserIngredienteBtn
            // 
            this.inserIngredienteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.inserIngredienteBtn.FlatAppearance.BorderSize = 0;
            this.inserIngredienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inserIngredienteBtn.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inserIngredienteBtn.ForeColor = System.Drawing.Color.White;
            this.inserIngredienteBtn.Image = ((System.Drawing.Image)(resources.GetObject("inserIngredienteBtn.Image")));
            this.inserIngredienteBtn.Location = new System.Drawing.Point(0, 250);
            this.inserIngredienteBtn.Name = "inserIngredienteBtn";
            this.inserIngredienteBtn.Size = new System.Drawing.Size(220, 75);
            this.inserIngredienteBtn.TabIndex = 12;
            this.inserIngredienteBtn.Text = "Inserir";
            this.inserIngredienteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.nomeLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.nomeLB.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomeLB.ForeColor = System.Drawing.Color.White;
            this.nomeLB.Location = new System.Drawing.Point(266, 202);
            this.nomeLB.Name = "nomeLB";
            this.nomeLB.Size = new System.Drawing.Size(54, 19);
            this.nomeLB.TabIndex = 16;
            this.nomeLB.Text = "Nome";
            this.nomeLB.Visible = false;
            // 
            // tipoLB
            // 
            this.tipoLB.AutoSize = true;
            this.tipoLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tipoLB.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipoLB.ForeColor = System.Drawing.Color.White;
            this.tipoLB.Location = new System.Drawing.Point(266, 265);
            this.tipoLB.Name = "tipoLB";
            this.tipoLB.Size = new System.Drawing.Size(48, 19);
            this.tipoLB.TabIndex = 17;
            this.tipoLB.Text = "Tipo:";
            this.tipoLB.Visible = false;
            // 
            // caloriasLB
            // 
            this.caloriasLB.AutoSize = true;
            this.caloriasLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.caloriasLB.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caloriasLB.ForeColor = System.Drawing.Color.White;
            this.caloriasLB.Location = new System.Drawing.Point(266, 326);
            this.caloriasLB.Name = "caloriasLB";
            this.caloriasLB.Size = new System.Drawing.Size(77, 19);
            this.caloriasLB.TabIndex = 18;
            this.caloriasLB.Text = "Calorias:";
            this.caloriasLB.Visible = false;
            // 
            // insrIngredienteBTN
            // 
            this.insrIngredienteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.insrIngredienteBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insrIngredienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insrIngredienteBTN.Font = new System.Drawing.Font("Inter Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insrIngredienteBTN.ForeColor = System.Drawing.Color.White;
            this.insrIngredienteBTN.Location = new System.Drawing.Point(148, 7);
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
            this.uppIngredienteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.uppIngredienteBTN.FlatAppearance.BorderSize = 0;
            this.uppIngredienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uppIngredienteBTN.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uppIngredienteBTN.ForeColor = System.Drawing.Color.White;
            this.uppIngredienteBTN.Image = ((System.Drawing.Image)(resources.GetObject("uppIngredienteBTN.Image")));
            this.uppIngredienteBTN.Location = new System.Drawing.Point(0, 325);
            this.uppIngredienteBTN.Name = "uppIngredienteBTN";
            this.uppIngredienteBTN.Size = new System.Drawing.Size(220, 75);
            this.uppIngredienteBTN.TabIndex = 33;
            this.uppIngredienteBTN.Text = "Editar";
            this.uppIngredienteBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.uppIngredienteBTN.UseVisualStyleBackColor = false;
            this.uppIngredienteBTN.Click += new System.EventHandler(this.uppIngredienteBTN_Click);
            // 
            // uppBTN
            // 
            this.uppBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.uppBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.uppBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uppBTN.Font = new System.Drawing.Font("Inter Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uppBTN.ForeColor = System.Drawing.Color.White;
            this.uppBTN.Location = new System.Drawing.Point(148, 7);
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
            this.eliminarIngredienteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.eliminarIngredienteBTN.FlatAppearance.BorderSize = 0;
            this.eliminarIngredienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarIngredienteBTN.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eliminarIngredienteBTN.ForeColor = System.Drawing.Color.White;
            this.eliminarIngredienteBTN.Image = ((System.Drawing.Image)(resources.GetObject("eliminarIngredienteBTN.Image")));
            this.eliminarIngredienteBTN.Location = new System.Drawing.Point(0, 400);
            this.eliminarIngredienteBTN.Name = "eliminarIngredienteBTN";
            this.eliminarIngredienteBTN.Size = new System.Drawing.Size(220, 75);
            this.eliminarIngredienteBTN.TabIndex = 35;
            this.eliminarIngredienteBTN.Text = "Eliminar";
            this.eliminarIngredienteBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eliminarIngredienteBTN.UseVisualStyleBackColor = false;
            this.eliminarIngredienteBTN.Click += new System.EventHandler(this.eliminarReceitaBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.deleteBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Inter Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBTN.ForeColor = System.Drawing.Color.White;
            this.deleteBTN.Location = new System.Drawing.Point(148, 7);
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
            this.sairBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.sairBTN.FlatAppearance.BorderSize = 0;
            this.sairBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairBTN.Font = new System.Drawing.Font("Inter Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sairBTN.ForeColor = System.Drawing.Color.White;
            this.sairBTN.Image = ((System.Drawing.Image)(resources.GetObject("sairBTN.Image")));
            this.sairBTN.Location = new System.Drawing.Point(0, 475);
            this.sairBTN.Name = "sairBTN";
            this.sairBTN.Size = new System.Drawing.Size(220, 100);
            this.sairBTN.TabIndex = 37;
            this.sairBTN.UseVisualStyleBackColor = false;
            this.sairBTN.Click += new System.EventHandler(this.sairBTN_Click);
            // 
            // detalhesIngredienteList
            // 
            this.detalhesIngredienteList.FormattingEnabled = true;
            this.detalhesIngredienteList.ItemHeight = 15;
            this.detalhesIngredienteList.Location = new System.Drawing.Point(265, 77);
            this.detalhesIngredienteList.Name = "detalhesIngredienteList";
            this.detalhesIngredienteList.Size = new System.Drawing.Size(482, 379);
            this.detalhesIngredienteList.TabIndex = 40;
            this.detalhesIngredienteList.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.destaque);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.sairBTN);
            this.panel1.Controls.Add(this.detalhesIngredienteBtn);
            this.panel1.Controls.Add(this.inserIngredienteBtn);
            this.panel1.Controls.Add(this.eliminarIngredienteBTN);
            this.panel1.Controls.Add(this.uppIngredienteBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 601);
            this.panel1.TabIndex = 41;
            // 
            // destaque
            // 
            this.destaque.BackColor = System.Drawing.Color.White;
            this.destaque.Location = new System.Drawing.Point(213, 100);
            this.destaque.Name = "destaque";
            this.destaque.Size = new System.Drawing.Size(7, 75);
            this.destaque.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGREDIENTES";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deleteBTN);
            this.panel3.Controls.Add(this.infoTextBox);
            this.panel3.Controls.Add(this.infoLabel);
            this.panel3.Controls.Add(this.validarBtn);
            this.panel3.Controls.Add(this.uppBTN);
            this.panel3.Controls.Add(this.insrIngredienteBTN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(220, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 120);
            this.panel3.TabIndex = 42;
            // 
            // IngredientesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(861, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detalhesIngredienteList);
            this.Controls.Add(this.caloriasLB);
            this.Controls.Add(this.tipoLB);
            this.Controls.Add(this.nomeLB);
            this.Controls.Add(this.caloriasTB);
            this.Controls.Add(this.tipoTB);
            this.Controls.Add(this.nomeTB);
            this.Controls.Add(this.mostrarIngredienteList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngredientesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngredientesMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.ListBox detalhesIngredienteList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel destaque;
    }
}