﻿namespace Shop
{
    partial class DeleteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DelComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DelTextBox = new System.Windows.Forms.TextBox();
            this.DelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удаление объектов";
            // 
            // DelComboBox
            // 
            this.DelComboBox.FormattingEnabled = true;
            this.DelComboBox.Location = new System.Drawing.Point(33, 101);
            this.DelComboBox.Name = "DelComboBox";
            this.DelComboBox.Size = new System.Drawing.Size(303, 33);
            this.DelComboBox.TabIndex = 1;
            this.DelComboBox.SelectedIndexChanged += new System.EventHandler(this.DelComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите объект для удаления";
            // 
            // DelTextBox
            // 
            this.DelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelTextBox.ForeColor = System.Drawing.Color.Red;
            this.DelTextBox.Location = new System.Drawing.Point(32, 168);
            this.DelTextBox.Name = "DelTextBox";
            this.DelTextBox.ReadOnly = true;
            this.DelTextBox.Size = new System.Drawing.Size(304, 34);
            this.DelTextBox.TabIndex = 3;
            this.DelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(37, 252);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(298, 55);
            this.DelButton.TabIndex = 4;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 342);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.DelTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DelComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DelComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DelTextBox;
        private System.Windows.Forms.Button DelButton;
    }
}