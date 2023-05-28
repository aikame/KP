namespace KP
{
    partial class Auth
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
            this.NameMls = new System.Windows.Forms.Label();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameMls
            // 
            this.NameMls.AutoSize = true;
            this.NameMls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameMls.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameMls.Location = new System.Drawing.Point(98, 39);
            this.NameMls.Name = "NameMls";
            this.NameMls.Size = new System.Drawing.Size(121, 58);
            this.NameMls.TabIndex = 0;
            this.NameMls.Text = "MLS";
            // 
            // loginbox
            // 
            this.loginbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginbox.Location = new System.Drawing.Point(74, 190);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(181, 20);
            this.loginbox.TabIndex = 1;
            // 
            // passwordbox
            // 
            this.passwordbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordbox.Location = new System.Drawing.Point(74, 270);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(181, 20);
            this.passwordbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(120, 331);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 5;
            this.Enter.Text = "Войти";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(325, 501);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.NameMls);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Auth";
            this.Text = "MLS (Авторизация)";            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameMls;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Enter;
    }
}

