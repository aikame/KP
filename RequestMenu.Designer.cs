﻿namespace KP
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
            this.createReq = new System.Windows.Forms.Button();
            this.ReqBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createReq
            // 
            this.createReq.Location = new System.Drawing.Point(13, 414);
            this.createReq.Name = "createReq";
            this.createReq.Size = new System.Drawing.Size(426, 24);
            this.createReq.TabIndex = 1;
            this.createReq.Text = "Создать заявку";
            this.createReq.UseVisualStyleBackColor = true;
            this.createReq.Click += new System.EventHandler(this.createReq_Click);
            // 
            // ReqBox
            // 
            this.ReqBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReqBox.FormattingEnabled = true;
            this.ReqBox.ItemHeight = 24;
            this.ReqBox.Location = new System.Drawing.Point(13, 12);
            this.ReqBox.Margin = new System.Windows.Forms.Padding(30);
            this.ReqBox.Name = "ReqBox";
            this.ReqBox.Size = new System.Drawing.Size(426, 388);
            this.ReqBox.TabIndex = 2;
            this.ReqBox.DoubleClick += new System.EventHandler(this.ReqBox_DoubleClick);
            // 
            // RequestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.ReqBox);
            this.Controls.Add(this.createReq);
            this.Name = "RequestMenu";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Button createReq;
        private System.Windows.Forms.ListBox ReqBox;
    }
}