namespace KP
{
    partial class EventEdit
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
            this.arttext = new System.Windows.Forms.TextBox();
            this.desctext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.showCompB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arttext
            // 
            this.arttext.Location = new System.Drawing.Point(12, 115);
            this.arttext.Name = "arttext";
            this.arttext.Size = new System.Drawing.Size(370, 20);
            this.arttext.TabIndex = 0;
            // 
            // desctext
            // 
            this.desctext.Location = new System.Drawing.Point(12, 196);
            this.desctext.Multiline = true;
            this.desctext.Name = "desctext";
            this.desctext.Size = new System.Drawing.Size(370, 213);
            this.desctext.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тема заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текст заявки";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(16, 452);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(178, 31);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.UseWaitCursor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // CancelB
            // 
            this.CancelB.Location = new System.Drawing.Point(200, 452);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(182, 31);
            this.CancelB.TabIndex = 5;
            this.CancelB.Text = "Отмена";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.UseWaitCursor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(13, 425);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(52, 13);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "%автор%";
            // 
            // showCompB
            // 
            this.showCompB.Location = new System.Drawing.Point(16, 26);
            this.showCompB.Name = "showCompB";
            this.showCompB.Size = new System.Drawing.Size(350, 31);
            this.showCompB.TabIndex = 7;
            this.showCompB.Text = "Показать участников";
            this.showCompB.UseVisualStyleBackColor = true;
            this.showCompB.UseWaitCursor = true;
            this.showCompB.Click += new System.EventHandler(this.showCompB_Click);
            // 
            // EventEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 505);
            this.Controls.Add(this.showCompB);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desctext);
            this.Controls.Add(this.arttext);
            this.Name = "EventEdit";
            this.Text = "Создание/Редактирование события";
            this.Load += new System.EventHandler(this.EventEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arttext;
        private System.Windows.Forms.TextBox desctext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Button showCompB;
    }
}