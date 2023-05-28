namespace KP
{
    partial class RequestEdit
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
            this.artbox = new System.Windows.Forms.TextBox();
            this.descbox = new System.Windows.Forms.TextBox();
            this.saveB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // artbox
            // 
            this.artbox.Location = new System.Drawing.Point(12, 58);
            this.artbox.Name = "artbox";
            this.artbox.Size = new System.Drawing.Size(371, 20);
            this.artbox.TabIndex = 0;
            // 
            // descbox
            // 
            this.descbox.Location = new System.Drawing.Point(12, 112);
            this.descbox.Multiline = true;
            this.descbox.Name = "descbox";
            this.descbox.Size = new System.Drawing.Size(371, 300);
            this.descbox.TabIndex = 1;
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(13, 419);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(172, 40);
            this.saveB.TabIndex = 2;
            this.saveB.Text = "Сохранить";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(207, 418);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(176, 40);
            this.cancelB.TabIndex = 3;
            this.cancelB.Text = "Отменить";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Заголовок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Описание";
            // 
            // RequestEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.descbox);
            this.Controls.Add(this.artbox);
            this.Name = "RequestEdit";
            this.Text = "RequestEdit";
            this.Load += new System.EventHandler(this.RequestEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox artbox;
        private System.Windows.Forms.TextBox descbox;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}