namespace KP
{
    partial class UserEdit
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
            this.components = new System.ComponentModel.Container();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.AccoutLevelBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AccountLevelLabel = new System.Windows.Forms.Label();
            this.saveB = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(12, 55);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(233, 20);
            this.LoginBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(12, 101);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(233, 20);
            this.PasswordBox.TabIndex = 1;
            // 
            // AccoutLevelBox
            // 
            this.AccoutLevelBox.AllowDrop = true;
            this.AccoutLevelBox.FormattingEnabled = true;
            this.AccoutLevelBox.Items.AddRange(new object[] {
            "Музыкант",
            "Менеджер",
            "Директор"});
            this.AccoutLevelBox.Location = new System.Drawing.Point(12, 150);
            this.AccoutLevelBox.Name = "AccoutLevelBox";
            this.AccoutLevelBox.Size = new System.Drawing.Size(121, 21);
            this.AccoutLevelBox.TabIndex = 2;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(13, 36);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(13, 85);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            // 
            // AccountLevelLabel
            // 
            this.AccountLevelLabel.AutoSize = true;
            this.AccountLevelLabel.Location = new System.Drawing.Point(13, 134);
            this.AccountLevelLabel.Name = "AccountLevelLabel";
            this.AccountLevelLabel.Size = new System.Drawing.Size(65, 13);
            this.AccountLevelLabel.TabIndex = 5;
            this.AccountLevelLabel.Text = "Должность";
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(12, 414);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(188, 39);
            this.saveB.TabIndex = 6;
            this.saveB.Text = "Сохранить";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // CancelB
            // 
            this.CancelB.Location = new System.Drawing.Point(206, 414);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(176, 39);
            this.CancelB.TabIndex = 7;
            this.CancelB.Text = "Отменить";
            this.CancelB.UseVisualStyleBackColor = true;
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 465);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.AccountLevelLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.AccoutLevelBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Name = "UserEdit";
            this.Text = "Создание/Редактирование пользователя";
            this.Load += new System.EventHandler(this.UserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.ComboBox AccoutLevelBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label AccountLevelLabel;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button CancelB;
    }
}