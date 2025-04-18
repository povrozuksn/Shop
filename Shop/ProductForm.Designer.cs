﻿namespace Shop
{
    partial class ProductForm
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
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CalLabel = new System.Windows.Forms.Label();
            this.PeriodLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.OpisTextBox = new System.Windows.Forms.TextBox();
            this.AddSelectedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(26, 21);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(64, 25);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "label1";
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.Location = new System.Drawing.Point(31, 61);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(323, 314);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPictureBox.TabIndex = 1;
            this.ProductPictureBox.TabStop = false;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(26, 413);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(64, 25);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "label1";
            // 
            // CalLabel
            // 
            this.CalLabel.AutoSize = true;
            this.CalLabel.Location = new System.Drawing.Point(425, 31);
            this.CalLabel.Name = "CalLabel";
            this.CalLabel.Size = new System.Drawing.Size(64, 25);
            this.CalLabel.TabIndex = 3;
            this.CalLabel.Text = "label1";
            // 
            // PeriodLabel
            // 
            this.PeriodLabel.AutoSize = true;
            this.PeriodLabel.Location = new System.Drawing.Point(425, 73);
            this.PeriodLabel.Name = "PeriodLabel";
            this.PeriodLabel.Size = new System.Drawing.Size(64, 25);
            this.PeriodLabel.TabIndex = 4;
            this.PeriodLabel.Text = "label1";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(425, 116);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(64, 25);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "label1";
            // 
            // OpisTextBox
            // 
            this.OpisTextBox.Location = new System.Drawing.Point(390, 159);
            this.OpisTextBox.Multiline = true;
            this.OpisTextBox.Name = "OpisTextBox";
            this.OpisTextBox.ReadOnly = true;
            this.OpisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OpisTextBox.Size = new System.Drawing.Size(377, 371);
            this.OpisTextBox.TabIndex = 6;
            // 
            // AddSelectedButton
            // 
            this.AddSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddSelectedButton.Location = new System.Drawing.Point(31, 482);
            this.AddSelectedButton.Name = "AddSelectedButton";
            this.AddSelectedButton.Size = new System.Drawing.Size(322, 47);
            this.AddSelectedButton.TabIndex = 7;
            this.AddSelectedButton.Text = "Добавить в избранное";
            this.AddSelectedButton.UseVisualStyleBackColor = false;
            this.AddSelectedButton.Click += new System.EventHandler(this.AddSelectedButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 543);
            this.Controls.Add(this.AddSelectedButton);
            this.Controls.Add(this.OpisTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PeriodLabel);
            this.Controls.Add(this.CalLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ProductPictureBox);
            this.Controls.Add(this.ProductLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CalLabel;
        private System.Windows.Forms.Label PeriodLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox OpisTextBox;
        private System.Windows.Forms.Button AddSelectedButton;
    }
}