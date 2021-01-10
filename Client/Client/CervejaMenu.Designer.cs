
namespace Client
{
    partial class CervejaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CervejaMenu));
            this.mostrarCervejaBTN = new System.Windows.Forms.Button();
            this.tabelaCerveja = new System.Windows.Forms.DataGridView();
            this.sairBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.validarBtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.cervejaAleatoriaBTN = new System.Windows.Forms.Button();
            this.cervejaRecBTN = new System.Windows.Forms.Button();
            this.pesquisarBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCerveja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarCervejaBTN
            // 
            this.mostrarCervejaBTN.BackColor = System.Drawing.Color.White;
            this.mostrarCervejaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mostrarCervejaBTN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.mostrarCervejaBTN.Location = new System.Drawing.Point(12, 166);
            this.mostrarCervejaBTN.Name = "mostrarCervejaBTN";
            this.mostrarCervejaBTN.Size = new System.Drawing.Size(112, 40);
            this.mostrarCervejaBTN.TabIndex = 1;
            this.mostrarCervejaBTN.Text = "Mostrar Cerveja";
            this.mostrarCervejaBTN.UseVisualStyleBackColor = false;
            this.mostrarCervejaBTN.Click += new System.EventHandler(this.mostrarCervejaBTN_Click);
            // 
            // tabelaCerveja
            // 
            this.tabelaCerveja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCerveja.Location = new System.Drawing.Point(256, 31);
            this.tabelaCerveja.Name = "tabelaCerveja";
            this.tabelaCerveja.RowTemplate.Height = 25;
            this.tabelaCerveja.Size = new System.Drawing.Size(886, 469);
            this.tabelaCerveja.TabIndex = 2;
            this.tabelaCerveja.Visible = false;
            // 
            // sairBTN
            // 
            this.sairBTN.BackColor = System.Drawing.Color.White;
            this.sairBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sairBTN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.sairBTN.Location = new System.Drawing.Point(12, 560);
            this.sairBTN.Name = "sairBTN";
            this.sairBTN.Size = new System.Drawing.Size(112, 40);
            this.sairBTN.TabIndex = 38;
            this.sairBTN.Text = "Sair";
            this.sairBTN.UseVisualStyleBackColor = false;
            this.sairBTN.Click += new System.EventHandler(this.sairBTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Location = new System.Drawing.Point(12, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 39;
            this.button1.Text = "Detalhes Cerveja";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // validarBtn
            // 
            this.validarBtn.BackColor = System.Drawing.Color.White;
            this.validarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.validarBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.validarBtn.Location = new System.Drawing.Point(365, 526);
            this.validarBtn.Name = "validarBtn";
            this.validarBtn.Size = new System.Drawing.Size(112, 40);
            this.validarBtn.TabIndex = 42;
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
            this.infoLabel.Location = new System.Drawing.Point(261, 526);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(26, 17);
            this.infoLabel.TabIndex = 41;
            this.infoLabel.Text = "ID:";
            this.infoLabel.Visible = false;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(288, 523);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(58, 36);
            this.infoTextBox.TabIndex = 40;
            this.infoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.infoTextBox.Visible = false;
            // 
            // cervejaAleatoriaBTN
            // 
            this.cervejaAleatoriaBTN.BackColor = System.Drawing.Color.White;
            this.cervejaAleatoriaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cervejaAleatoriaBTN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cervejaAleatoriaBTN.Location = new System.Drawing.Point(12, 351);
            this.cervejaAleatoriaBTN.Name = "cervejaAleatoriaBTN";
            this.cervejaAleatoriaBTN.Size = new System.Drawing.Size(112, 40);
            this.cervejaAleatoriaBTN.TabIndex = 43;
            this.cervejaAleatoriaBTN.Text = "Cerveja Aleatória";
            this.cervejaAleatoriaBTN.UseVisualStyleBackColor = false;
            this.cervejaAleatoriaBTN.Click += new System.EventHandler(this.cervejaAleatoriaBTN_Click);
            // 
            // cervejaRecBTN
            // 
            this.cervejaRecBTN.BackColor = System.Drawing.Color.White;
            this.cervejaRecBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cervejaRecBTN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cervejaRecBTN.Location = new System.Drawing.Point(12, 442);
            this.cervejaRecBTN.Name = "cervejaRecBTN";
            this.cervejaRecBTN.Size = new System.Drawing.Size(112, 40);
            this.cervejaRecBTN.TabIndex = 44;
            this.cervejaRecBTN.Text = "Cerveja Recomendada";
            this.cervejaRecBTN.UseVisualStyleBackColor = false;
            this.cervejaRecBTN.Click += new System.EventHandler(this.cervejaRecBTN_Click);
            // 
            // pesquisarBTN
            // 
            this.pesquisarBTN.BackColor = System.Drawing.Color.White;
            this.pesquisarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pesquisarBTN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.pesquisarBTN.Location = new System.Drawing.Point(343, 587);
            this.pesquisarBTN.Name = "pesquisarBTN";
            this.pesquisarBTN.Size = new System.Drawing.Size(112, 40);
            this.pesquisarBTN.TabIndex = 45;
            this.pesquisarBTN.Text = "Pesquisar";
            this.pesquisarBTN.UseVisualStyleBackColor = false;
            this.pesquisarBTN.Click += new System.EventHandler(this.pesquisarBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // CervejaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1275, 639);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pesquisarBTN);
            this.Controls.Add(this.cervejaRecBTN);
            this.Controls.Add(this.cervejaAleatoriaBTN);
            this.Controls.Add(this.validarBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sairBTN);
            this.Controls.Add(this.tabelaCerveja);
            this.Controls.Add(this.mostrarCervejaBTN);
            this.Name = "CervejaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CervejaMenu";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCerveja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mostrarCervejaBTN;
        private System.Windows.Forms.DataGridView tabelaCerveja;
        private System.Windows.Forms.Button sairBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button validarBtn;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button cervejaAleatoriaBTN;
        private System.Windows.Forms.Button cervejaRecBTN;
        private System.Windows.Forms.Button pesquisarBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}