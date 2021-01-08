
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
            this.label1 = new System.Windows.Forms.Label();
            this.saitBtn = new System.Windows.Forms.Button();
            this.receitasBtn = new System.Windows.Forms.Button();
            this.ingredientesBtn = new System.Windows.Forms.Button();
            this.cervejasBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "coisas";
            // 
            // saitBtn
            // 
            this.saitBtn.Location = new System.Drawing.Point(226, 461);
            this.saitBtn.Name = "saitBtn";
            this.saitBtn.Size = new System.Drawing.Size(251, 48);
            this.saitBtn.TabIndex = 1;
            this.saitBtn.Text = "Sair";
            this.saitBtn.UseVisualStyleBackColor = true;
            this.saitBtn.Click += new System.EventHandler(this.saitBtn_Click);
            // 
            // receitasBtn
            // 
            this.receitasBtn.Location = new System.Drawing.Point(31, 106);
            this.receitasBtn.Name = "receitasBtn";
            this.receitasBtn.Size = new System.Drawing.Size(147, 60);
            this.receitasBtn.TabIndex = 2;
            this.receitasBtn.Text = "Receitas";
            this.receitasBtn.UseVisualStyleBackColor = true;
            this.receitasBtn.Click += new System.EventHandler(this.receitasBtn_Click);
            // 
            // ingredientesBtn
            // 
            this.ingredientesBtn.Location = new System.Drawing.Point(226, 106);
            this.ingredientesBtn.Name = "ingredientesBtn";
            this.ingredientesBtn.Size = new System.Drawing.Size(152, 60);
            this.ingredientesBtn.TabIndex = 3;
            this.ingredientesBtn.Text = "Ingredientes";
            this.ingredientesBtn.UseVisualStyleBackColor = true;
            this.ingredientesBtn.Click += new System.EventHandler(this.ingredientesBtn_Click);
            // 
            // cervejasBtn
            // 
            this.cervejasBtn.Location = new System.Drawing.Point(448, 106);
            this.cervejasBtn.Name = "cervejasBtn";
            this.cervejasBtn.Size = new System.Drawing.Size(167, 60);
            this.cervejasBtn.TabIndex = 4;
            this.cervejasBtn.Text = "Cervejas";
            this.cervejasBtn.UseVisualStyleBackColor = true;
            this.cervejasBtn.Click += new System.EventHandler(this.cervejasBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 547);
            this.Controls.Add(this.cervejasBtn);
            this.Controls.Add(this.ingredientesBtn);
            this.Controls.Add(this.receitasBtn);
            this.Controls.Add(this.saitBtn);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saitBtn;
        private System.Windows.Forms.Button receitasBtn;
        private System.Windows.Forms.Button ingredientesBtn;
        private System.Windows.Forms.Button cervejasBtn;
    }
}