namespace Shop
{
    partial class SelectedForm
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
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.MailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(600, 50);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(201, 25);
            this.TotalPriceLabel.TabIndex = 0;
            this.TotalPriceLabel.Text = "Общая стоимость : ";
            // 
            // MailButton
            // 
            this.MailButton.Location = new System.Drawing.Point(12, 12);
            this.MailButton.Name = "MailButton";
            this.MailButton.Size = new System.Drawing.Size(241, 43);
            this.MailButton.TabIndex = 1;
            this.MailButton.Text = "Отправить на Email";
            this.MailButton.UseVisualStyleBackColor = true;
            this.MailButton.Click += new System.EventHandler(this.MailButton_Click);
            // 
            // SelectedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1381, 534);
            this.Controls.Add(this.MailButton);
            this.Controls.Add(this.TotalPriceLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectedForm";
            this.Text = "SelectedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Button MailButton;
    }
}