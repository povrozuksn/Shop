namespace Shop
{
    partial class RegForm
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SecondnameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.REPasswordTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваше имя";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(17, 37);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(353, 30);
            this.NameTB.TabIndex = 1;
            // 
            // SecondnameTB
            // 
            this.SecondnameTB.Location = new System.Drawing.Point(17, 108);
            this.SecondnameTB.Name = "SecondnameTB";
            this.SecondnameTB.Size = new System.Drawing.Size(353, 30);
            this.SecondnameTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ваша фамилия";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(17, 191);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(353, 30);
            this.LoginTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(17, 274);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(353, 30);
            this.PasswordTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пароль";
            // 
            // REPasswordTB
            // 
            this.REPasswordTB.Location = new System.Drawing.Point(17, 355);
            this.REPasswordTB.Name = "REPasswordTB";
            this.REPasswordTB.Size = new System.Drawing.Size(353, 30);
            this.REPasswordTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Подтверждение пароля";
            // 
            // RegButton
            // 
            this.RegButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RegButton.Location = new System.Drawing.Point(0, 440);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(389, 42);
            this.RegButton.TabIndex = 10;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 482);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.REPasswordTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondnameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegForm";
            this.Text = "Форма регистрации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SecondnameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox REPasswordTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegButton;
    }
}