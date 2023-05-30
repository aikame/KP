namespace KP
{
    partial class RequestMenu
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
            this.ReqBox = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // createB
            // 
            this.createB.Location = new System.Drawing.Point(13, 397);
            this.createB.Name = "createB";
            this.createB.Size = new System.Drawing.Size(426, 41);
            this.createB.TabIndex = 1;
            this.createB.Text = "Создать заявку";
            this.createB.UseVisualStyleBackColor = true;
            this.createB.Click += new System.EventHandler(this.createReq_Click);
            // 
            // ReqBox
            // 
            this.ReqBox.AllowColumnReorder = true;
            this.ReqBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReqBox.FullRowSelect = true;
            this.ReqBox.GridLines = true;
            this.ReqBox.HideSelection = false;
            this.ReqBox.Location = new System.Drawing.Point(13, 12);
            this.ReqBox.MultiSelect = false;
            this.ReqBox.Name = "ReqBox";
            this.ReqBox.Size = new System.Drawing.Size(426, 379);
            this.ReqBox.TabIndex = 2;
            this.ReqBox.UseCompatibleStateImageBehavior = false;
            this.ReqBox.View = System.Windows.Forms.View.List;
            this.ReqBox.DoubleClick += new System.EventHandler(this.ReqBox_DoubleClick);
            // 
            // RequestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.ReqBox);
            this.Controls.Add(this.createB);
            this.Name = "RequestMenu";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Button createB;
        private System.Windows.Forms.ListView ReqBox;
    }
}