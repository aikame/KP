namespace KP
{
    partial class EventMenu
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
            this.createB = new System.Windows.Forms.Button();
            this.EventView = new System.Windows.Forms.ListView();
            this.deleteB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createB
            // 
            this.createB.Location = new System.Drawing.Point(13, 395);
            this.createB.Name = "createB";
            this.createB.Size = new System.Drawing.Size(225, 43);
            this.createB.TabIndex = 1;
            this.createB.Text = "Создать событие";
            this.createB.UseVisualStyleBackColor = true;
            this.createB.Click += new System.EventHandler(this.createB_Click);
            // 
            // EventView
            // 
            this.EventView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventView.FullRowSelect = true;
            this.EventView.GridLines = true;
            this.EventView.HideSelection = false;
            this.EventView.Location = new System.Drawing.Point(12, 12);
            this.EventView.Name = "EventView";
            this.EventView.Size = new System.Drawing.Size(451, 377);
            this.EventView.TabIndex = 2;
            this.EventView.UseCompatibleStateImageBehavior = false;
            this.EventView.View = System.Windows.Forms.View.List;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(244, 395);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(219, 43);
            this.deleteB.TabIndex = 3;
            this.deleteB.Text = "Удалить событие";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // EventMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.EventView);
            this.Controls.Add(this.createB);
            this.Name = "EventMenu";
            this.Text = "EventMenu";
            this.Load += new System.EventHandler(this.EventMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createB;
        private System.Windows.Forms.ListView EventView;
        private System.Windows.Forms.Button deleteB;
    }
}