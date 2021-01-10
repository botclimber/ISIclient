
namespace Client
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.saitBtn = new System.Windows.Forms.Button();
            this.receitasBtn = new System.Windows.Forms.Button();
            this.ingredientesBtn = new System.Windows.Forms.Button();
            this.cervejasBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saitBtn
            // 
            this.saitBtn.BackColor = System.Drawing.Color.White;
            this.saitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saitBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.saitBtn.Location = new System.Drawing.Point(226, 461);
            this.saitBtn.Name = "saitBtn";
            this.saitBtn.Size = new System.Drawing.Size(251, 48);
            this.saitBtn.TabIndex = 1;
            this.saitBtn.Text = "Sair";
            this.saitBtn.UseVisualStyleBackColor = false;
            this.saitBtn.Click += new System.EventHandler(this.saitBtn_Click);
            // 
            // receitasBtn
            // 
            this.receitasBtn.BackColor = System.Drawing.Color.White;
            this.receitasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receitasBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receitasBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.receitasBtn.Location = new System.Drawing.Point(61, 228);
            this.receitasBtn.Name = "receitasBtn";
            this.receitasBtn.Size = new System.Drawing.Size(147, 60);
            this.receitasBtn.TabIndex = 2;
            this.receitasBtn.Text = "Receitas";
            this.receitasBtn.UseVisualStyleBackColor = false;
            this.receitasBtn.Click += new System.EventHandler(this.receitasBtn_Click);
            // 
            // ingredientesBtn
            // 
            this.ingredientesBtn.BackColor = System.Drawing.Color.White;
            this.ingredientesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredientesBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ingredientesBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ingredientesBtn.Location = new System.Drawing.Point(256, 228);
            this.ingredientesBtn.Name = "ingredientesBtn";
            this.ingredientesBtn.Size = new System.Drawing.Size(152, 60);
            this.ingredientesBtn.TabIndex = 3;
            this.ingredientesBtn.Text = "Ingredientes";
            this.ingredientesBtn.UseVisualStyleBackColor = false;
            this.ingredientesBtn.Click += new System.EventHandler(this.ingredientesBtn_Click);
            // 
            // cervejasBtn
            // 
            this.cervejasBtn.BackColor = System.Drawing.Color.White;
            this.cervejasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cervejasBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cervejasBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cervejasBtn.Location = new System.Drawing.Point(478, 228);
            this.cervejasBtn.Name = "cervejasBtn";
            this.cervejasBtn.Size = new System.Drawing.Size(167, 60);
            this.cervejasBtn.TabIndex = 4;
            this.cervejasBtn.Text = "Cervejas";
            this.cervejasBtn.UseVisualStyleBackColor = false;
            this.cervejasBtn.Click += new System.EventHandler(this.cervejasBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 547);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cervejasBtn);
            this.Controls.Add(this.ingredientesBtn);
            this.Controls.Add(this.receitasBtn);
            this.Controls.Add(this.saitBtn);
            this.DoubleBuffered = true;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - QuickRecipes";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saitBtn;
        private System.Windows.Forms.Button receitasBtn;
        private System.Windows.Forms.Button ingredientesBtn;
        private System.Windows.Forms.Button cervejasBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}