
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.destaque1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCerveja)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mostrarCervejaBTN
            // 
            this.mostrarCervejaBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.mostrarCervejaBTN.FlatAppearance.BorderSize = 0;
            this.mostrarCervejaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostrarCervejaBTN.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mostrarCervejaBTN.ForeColor = System.Drawing.Color.White;
            this.mostrarCervejaBTN.Image = ((System.Drawing.Image)(resources.GetObject("mostrarCervejaBTN.Image")));
            this.mostrarCervejaBTN.Location = new System.Drawing.Point(0, 100);
            this.mostrarCervejaBTN.Name = "mostrarCervejaBTN";
            this.mostrarCervejaBTN.Size = new System.Drawing.Size(220, 75);
            this.mostrarCervejaBTN.TabIndex = 1;
            this.mostrarCervejaBTN.Text = "Ver";
            this.mostrarCervejaBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mostrarCervejaBTN.UseVisualStyleBackColor = false;
            this.mostrarCervejaBTN.Click += new System.EventHandler(this.mostrarCervejaBTN_Click);
            // 
            // tabelaCerveja
            // 
            this.tabelaCerveja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCerveja.Location = new System.Drawing.Point(278, 95);
            this.tabelaCerveja.Name = "tabelaCerveja";
            this.tabelaCerveja.RowTemplate.Height = 25;
            this.tabelaCerveja.Size = new System.Drawing.Size(752, 323);
            this.tabelaCerveja.TabIndex = 2;
            this.tabelaCerveja.Visible = false;
            // 
            // sairBTN
            // 
            this.sairBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.sairBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sairBTN.FlatAppearance.BorderSize = 0;
            this.sairBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairBTN.Font = new System.Drawing.Font("Inter Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sairBTN.ForeColor = System.Drawing.Color.White;
            this.sairBTN.Image = ((System.Drawing.Image)(resources.GetObject("sairBTN.Image")));
            this.sairBTN.Location = new System.Drawing.Point(0, 529);
            this.sairBTN.Name = "sairBTN";
            this.sairBTN.Size = new System.Drawing.Size(220, 110);
            this.sairBTN.TabIndex = 38;
            this.sairBTN.UseVisualStyleBackColor = false;
            this.sairBTN.Click += new System.EventHandler(this.sairBTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 75);
            this.button1.TabIndex = 39;
            this.button1.Text = "Detalhes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // validarBtn
            // 
            this.validarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.validarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.validarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validarBtn.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.validarBtn.ForeColor = System.Drawing.Color.White;
            this.validarBtn.Location = new System.Drawing.Point(644, 459);
            this.validarBtn.Name = "validarBtn";
            this.validarBtn.Size = new System.Drawing.Size(112, 40);
            this.validarBtn.TabIndex = 42;
            this.validarBtn.Text = "Pesquisar";
            this.validarBtn.UseVisualStyleBackColor = false;
            this.validarBtn.Visible = false;
            this.validarBtn.Click += new System.EventHandler(this.validarBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.infoLabel.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(541, 471);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(24, 16);
            this.infoLabel.TabIndex = 41;
            this.infoLabel.Text = "ID:";
            this.infoLabel.Visible = false;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(571, 459);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(58, 40);
            this.infoTextBox.TabIndex = 40;
            this.infoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.infoTextBox.Visible = false;
            // 
            // cervejaAleatoriaBTN
            // 
            this.cervejaAleatoriaBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.cervejaAleatoriaBTN.FlatAppearance.BorderSize = 0;
            this.cervejaAleatoriaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cervejaAleatoriaBTN.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cervejaAleatoriaBTN.ForeColor = System.Drawing.Color.White;
            this.cervejaAleatoriaBTN.Image = ((System.Drawing.Image)(resources.GetObject("cervejaAleatoriaBTN.Image")));
            this.cervejaAleatoriaBTN.Location = new System.Drawing.Point(0, 262);
            this.cervejaAleatoriaBTN.Name = "cervejaAleatoriaBTN";
            this.cervejaAleatoriaBTN.Size = new System.Drawing.Size(220, 75);
            this.cervejaAleatoriaBTN.TabIndex = 43;
            this.cervejaAleatoriaBTN.Text = "Aleatória";
            this.cervejaAleatoriaBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cervejaAleatoriaBTN.UseVisualStyleBackColor = false;
            this.cervejaAleatoriaBTN.Click += new System.EventHandler(this.cervejaAleatoriaBTN_Click);
            // 
            // cervejaRecBTN
            // 
            this.cervejaRecBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.cervejaRecBTN.FlatAppearance.BorderSize = 0;
            this.cervejaRecBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cervejaRecBTN.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cervejaRecBTN.ForeColor = System.Drawing.Color.White;
            this.cervejaRecBTN.Image = ((System.Drawing.Image)(resources.GetObject("cervejaRecBTN.Image")));
            this.cervejaRecBTN.Location = new System.Drawing.Point(0, 343);
            this.cervejaRecBTN.Name = "cervejaRecBTN";
            this.cervejaRecBTN.Size = new System.Drawing.Size(220, 75);
            this.cervejaRecBTN.TabIndex = 44;
            this.cervejaRecBTN.Text = "Recomendada";
            this.cervejaRecBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cervejaRecBTN.UseVisualStyleBackColor = false;
            this.cervejaRecBTN.Click += new System.EventHandler(this.cervejaRecBTN_Click);
            // 
            // pesquisarBTN
            // 
            this.pesquisarBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pesquisarBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pesquisarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisarBTN.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pesquisarBTN.ForeColor = System.Drawing.Color.White;
            this.pesquisarBTN.Location = new System.Drawing.Point(644, 459);
            this.pesquisarBTN.Name = "pesquisarBTN";
            this.pesquisarBTN.Size = new System.Drawing.Size(112, 40);
            this.pesquisarBTN.TabIndex = 45;
            this.pesquisarBTN.Text = "Pesquisar";
            this.pesquisarBTN.UseVisualStyleBackColor = false;
            this.pesquisarBTN.Visible = false;
            this.pesquisarBTN.Click += new System.EventHandler(this.pesquisarBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.destaque1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cervejaRecBTN);
            this.panel1.Controls.Add(this.mostrarCervejaBTN);
            this.panel1.Controls.Add(this.cervejaAleatoriaBTN);
            this.panel1.Controls.Add(this.sairBTN);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 639);
            this.panel1.TabIndex = 46;
            // 
            // destaque1
            // 
            this.destaque1.BackColor = System.Drawing.Color.White;
            this.destaque1.Location = new System.Drawing.Point(213, 100);
            this.destaque1.Name = "destaque1";
            this.destaque1.Size = new System.Drawing.Size(7, 75);
            this.destaque1.TabIndex = 43;
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
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CERVEJAS";
            // 
            // CervejaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1086, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pesquisarBTN);
            this.Controls.Add(this.validarBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.tabelaCerveja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CervejaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CervejaMenu";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCerveja)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel destaque1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}