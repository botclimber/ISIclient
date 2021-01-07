
namespace Client
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.passTextbox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registarBtn = new System.Windows.Forms.Button();
            this.sairBtn = new System.Windows.Forms.Button();
            this.passRegistLabel = new System.Windows.Forms.Label();
            this.userRegistLabel = new System.Windows.Forms.Label();
            this.passRegistTextbox = new System.Windows.Forms.TextBox();
            this.emailRegistTextbox = new System.Windows.Forms.TextBox();
            this.confirmPassRegistLabel = new System.Windows.Forms.Label();
            this.confirmPassRegistTextbox = new System.Windows.Forms.TextBox();
            this.registarRegistBtn = new System.Windows.Forms.Button();
            this.cancelRegistBtn = new System.Windows.Forms.Button();
            this.nameRegistLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userRegistTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(188, 82);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(183, 23);
            this.emailTextbox.TabIndex = 0;
            // 
            // passTextbox
            // 
            this.passTextbox.Location = new System.Drawing.Point(188, 156);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.Size = new System.Drawing.Size(183, 23);
            this.passTextbox.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(39, 85);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(39, 15);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Email:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(39, 159);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(86, 15);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Palavra-Chave:";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(243, 274);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(128, 31);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registarBtn
            // 
            this.registarBtn.Location = new System.Drawing.Point(39, 274);
            this.registarBtn.Name = "registarBtn";
            this.registarBtn.Size = new System.Drawing.Size(128, 31);
            this.registarBtn.TabIndex = 5;
            this.registarBtn.Text = "Registar";
            this.registarBtn.UseVisualStyleBackColor = true;
            this.registarBtn.Click += new System.EventHandler(this.registarBtn_Click);
            // 
            // sairBtn
            // 
            this.sairBtn.Location = new System.Drawing.Point(39, 325);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(332, 31);
            this.sairBtn.TabIndex = 6;
            this.sairBtn.Text = "Sair";
            this.sairBtn.UseVisualStyleBackColor = true;
            this.sairBtn.Click += new System.EventHandler(this.sairBtn_Click);
            // 
            // passRegistLabel
            // 
            this.passRegistLabel.AutoSize = true;
            this.passRegistLabel.Location = new System.Drawing.Point(39, 159);
            this.passRegistLabel.Name = "passRegistLabel";
            this.passRegistLabel.Size = new System.Drawing.Size(86, 15);
            this.passRegistLabel.TabIndex = 10;
            this.passRegistLabel.Text = "Palavra-Chave:";
            this.passRegistLabel.Visible = false;
            // 
            // userRegistLabel
            // 
            this.userRegistLabel.AutoSize = true;
            this.userRegistLabel.Location = new System.Drawing.Point(39, 85);
            this.userRegistLabel.Name = "userRegistLabel";
            this.userRegistLabel.Size = new System.Drawing.Size(39, 15);
            this.userRegistLabel.TabIndex = 9;
            this.userRegistLabel.Text = "Email:";
            this.userRegistLabel.Visible = false;
            // 
            // passRegistTextbox
            // 
            this.passRegistTextbox.Location = new System.Drawing.Point(188, 156);
            this.passRegistTextbox.Name = "passRegistTextbox";
            this.passRegistTextbox.Size = new System.Drawing.Size(183, 23);
            this.passRegistTextbox.TabIndex = 8;
            this.passRegistTextbox.Visible = false;
            // 
            // emailRegistTextbox
            // 
            this.emailRegistTextbox.Location = new System.Drawing.Point(188, 82);
            this.emailRegistTextbox.Name = "emailRegistTextbox";
            this.emailRegistTextbox.Size = new System.Drawing.Size(183, 23);
            this.emailRegistTextbox.TabIndex = 7;
            this.emailRegistTextbox.Visible = false;
            // 
            // confirmPassRegistLabel
            // 
            this.confirmPassRegistLabel.AutoSize = true;
            this.confirmPassRegistLabel.Location = new System.Drawing.Point(39, 226);
            this.confirmPassRegistLabel.Name = "confirmPassRegistLabel";
            this.confirmPassRegistLabel.Size = new System.Drawing.Size(143, 15);
            this.confirmPassRegistLabel.TabIndex = 11;
            this.confirmPassRegistLabel.Text = "Confirmar Palavra-Chave:";
            this.confirmPassRegistLabel.Visible = false;
            // 
            // confirmPassRegistTextbox
            // 
            this.confirmPassRegistTextbox.Location = new System.Drawing.Point(188, 223);
            this.confirmPassRegistTextbox.Name = "confirmPassRegistTextbox";
            this.confirmPassRegistTextbox.Size = new System.Drawing.Size(183, 23);
            this.confirmPassRegistTextbox.TabIndex = 12;
            this.confirmPassRegistTextbox.Visible = false;
            // 
            // registarRegistBtn
            // 
            this.registarRegistBtn.Location = new System.Drawing.Point(39, 252);
            this.registarRegistBtn.Name = "registarRegistBtn";
            this.registarRegistBtn.Size = new System.Drawing.Size(332, 31);
            this.registarRegistBtn.TabIndex = 13;
            this.registarRegistBtn.Text = "Registar";
            this.registarRegistBtn.UseVisualStyleBackColor = true;
            this.registarRegistBtn.Visible = false;
            this.registarRegistBtn.Click += new System.EventHandler(this.registarRegistBtn_Click);
            // 
            // cancelRegistBtn
            // 
            this.cancelRegistBtn.Location = new System.Drawing.Point(39, 325);
            this.cancelRegistBtn.Name = "cancelRegistBtn";
            this.cancelRegistBtn.Size = new System.Drawing.Size(332, 31);
            this.cancelRegistBtn.TabIndex = 14;
            this.cancelRegistBtn.Text = "Cancelar";
            this.cancelRegistBtn.UseVisualStyleBackColor = true;
            this.cancelRegistBtn.Visible = false;
            this.cancelRegistBtn.Click += new System.EventHandler(this.cancelRegistBtn_Click);
            // 
            // nameRegistLabel
            // 
            this.nameRegistLabel.AutoSize = true;
            this.nameRegistLabel.Location = new System.Drawing.Point(39, 29);
            this.nameRegistLabel.Name = "nameRegistLabel";
            this.nameRegistLabel.Size = new System.Drawing.Size(43, 15);
            this.nameRegistLabel.TabIndex = 15;
            this.nameRegistLabel.Text = "Nome:";
            this.nameRegistLabel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-40, -88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 23);
            this.textBox1.TabIndex = 16;
            this.textBox1.Visible = false;
            // 
            // userRegistTextbox
            // 
            this.userRegistTextbox.Location = new System.Drawing.Point(188, 26);
            this.userRegistTextbox.Name = "userRegistTextbox";
            this.userRegistTextbox.Size = new System.Drawing.Size(183, 23);
            this.userRegistTextbox.TabIndex = 17;
            this.userRegistTextbox.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 387);
            this.Controls.Add(this.userRegistTextbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nameRegistLabel);
            this.Controls.Add(this.cancelRegistBtn);
            this.Controls.Add(this.registarRegistBtn);
            this.Controls.Add(this.confirmPassRegistTextbox);
            this.Controls.Add(this.confirmPassRegistLabel);
            this.Controls.Add(this.passRegistLabel);
            this.Controls.Add(this.userRegistLabel);
            this.Controls.Add(this.passRegistTextbox);
            this.Controls.Add(this.emailRegistTextbox);
            this.Controls.Add(this.sairBtn);
            this.Controls.Add(this.registarBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox passTextbox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registarBtn;
        private System.Windows.Forms.Button sairBtn;
        private System.Windows.Forms.Label passRegistLabel;
        private System.Windows.Forms.Label userRegistLabel;
        private System.Windows.Forms.TextBox passRegistTextbox;
        private System.Windows.Forms.TextBox emailRegistTextbox;
        private System.Windows.Forms.Label confirmPassRegistLabel;
        private System.Windows.Forms.TextBox confirmPassRegistTextbox;
        private System.Windows.Forms.Button registarRegistBtn;
        private System.Windows.Forms.Button cancelRegistBtn;
        private System.Windows.Forms.Label nameRegistLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox userRegistTextbox;
    }
}

