namespace KP
{
    partial class Users
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
            this.AddB = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            this.usersBox = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(12, 401);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(186, 43);
            this.AddB.TabIndex = 1;
            this.AddB.Text = "Создать пользователя";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.Location = new System.Drawing.Point(209, 401);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(186, 43);
            this.DeleteB.TabIndex = 2;
            this.DeleteB.Text = "Удалить пользователя";
            this.DeleteB.UseVisualStyleBackColor = true;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // usersBox
            // 
            this.usersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersBox.FullRowSelect = true;
            this.usersBox.GridLines = true;
            this.usersBox.HideSelection = false;
            this.usersBox.Location = new System.Drawing.Point(12, 12);
            this.usersBox.Name = "usersBox";
            this.usersBox.Size = new System.Drawing.Size(383, 383);
            this.usersBox.TabIndex = 3;
            this.usersBox.UseCompatibleStateImageBehavior = false;
            this.usersBox.View = System.Windows.Forms.View.List;
            this.usersBox.DoubleClick += new System.EventHandler(this.UsersBox_DoubleClick);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 448);
            this.Controls.Add(this.usersBox);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.AddB);
            this.Name = "Users";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.ListView usersBox;
    }
}