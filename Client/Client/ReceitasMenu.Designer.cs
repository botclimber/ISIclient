
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
            this.mostrarReceitasList = new System.Windows.Forms.ListBox();
            this.detalhesReceitaBtn = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.validarBtn = new System.Windows.Forms.Button();
            this.detalhesReceitaTxtB = new System.Windows.Forms.TextBox();
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
            // mostrarReceitasList
            // 
            this.mostrarReceitasList.FormattingEnabled = true;
            this.mostrarReceitasList.ItemHeight = 15;
            this.mostrarReceitasList.Location = new System.Drawing.Point(300, 39);
            this.mostrarReceitasList.Name = "mostrarReceitasList";
            this.mostrarReceitasList.Size = new System.Drawing.Size(483, 379);
            this.mostrarReceitasList.TabIndex = 1;
            this.mostrarReceitasList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // detalhesReceitaBtn
            // 
            this.detalhesReceitaBtn.Location = new System.Drawing.Point(34, 119);
            this.detalhesReceitaBtn.Name = "detalhesReceitaBtn";
            this.detalhesReceitaBtn.Size = new System.Drawing.Size(123, 51);
            this.detalhesReceitaBtn.TabIndex = 2;
            this.detalhesReceitaBtn.Text = "Detalhes de Receita";
            this.detalhesReceitaBtn.UseVisualStyleBackColor = true;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(327, 442);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(49, 23);
            this.infoTextBox.TabIndex = 3;
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
            this.validarBtn.Click += new System.EventHandler(this.validarBtn_Click);
            // 
            // detalhesReceitaTxtB
            // 
            this.detalhesReceitaTxtB.Location = new System.Drawing.Point(396, 40);
            this.detalhesReceitaTxtB.Multiline = true;
            this.detalhesReceitaTxtB.Name = "detalhesReceitaTxtB";
            this.detalhesReceitaTxtB.Size = new System.Drawing.Size(360, 378);
            this.detalhesReceitaTxtB.TabIndex = 6;
            this.detalhesReceitaTxtB.Visible = false;
            // 
            // ReceitasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 639);
            this.Controls.Add(this.detalhesReceitaTxtB);
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
        private System.Windows.Forms.ListBox mostrarReceitasList;
        private System.Windows.Forms.Button detalhesReceitaBtn;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button validarBtn;
        private System.Windows.Forms.TextBox detalhesReceitaTxtB;
    }
}