
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
            this.mostrarCervejaBTN = new System.Windows.Forms.Button();
            this.tabelaCerveja = new System.Windows.Forms.DataGridView();
            this.sairBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCerveja)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarCervejaBTN
            // 
            this.mostrarCervejaBTN.Location = new System.Drawing.Point(12, 31);
            this.mostrarCervejaBTN.Name = "mostrarCervejaBTN";
            this.mostrarCervejaBTN.Size = new System.Drawing.Size(143, 50);
            this.mostrarCervejaBTN.TabIndex = 1;
            this.mostrarCervejaBTN.Text = "Mostrar Cerveja";
            this.mostrarCervejaBTN.UseVisualStyleBackColor = true;
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
            this.sairBTN.Location = new System.Drawing.Point(12, 560);
            this.sairBTN.Name = "sairBTN";
            this.sairBTN.Size = new System.Drawing.Size(143, 50);
            this.sairBTN.TabIndex = 38;
            this.sairBTN.Text = "Sair";
            this.sairBTN.UseVisualStyleBackColor = true;
            this.sairBTN.Click += new System.EventHandler(this.sairBTN_Click);
            // 
            // CervejaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 639);
            this.Controls.Add(this.sairBTN);
            this.Controls.Add(this.tabelaCerveja);
            this.Controls.Add(this.mostrarCervejaBTN);
            this.Name = "CervejaMenu";
            this.Text = "CervejaMenu";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCerveja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mostrarCervejaBTN;
        private System.Windows.Forms.DataGridView tabelaCerveja;
        private System.Windows.Forms.Button sairBTN;
    }
}