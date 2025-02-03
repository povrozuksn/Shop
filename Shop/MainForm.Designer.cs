namespace Shop
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.RegButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.FindButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.HideButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AuthPanel.SuspendLayout();
            this.FiltrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AuthPanel.Controls.Add(this.RegButton);
            this.AuthPanel.Controls.Add(this.NameLabel);
            this.AuthPanel.Controls.Add(this.AuthButton);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1076, 47);
            this.AuthPanel.TabIndex = 0;
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(433, 7);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(177, 34);
            this.RegButton.TabIndex = 2;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(135, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(64, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "label1";
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(12, 7);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(106, 34);
            this.AuthButton.TabIndex = 0;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FiltrPanel.Controls.Add(this.FindButton);
            this.FiltrPanel.Controls.Add(this.label2);
            this.FiltrPanel.Controls.Add(this.CategoryComboBox);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Controls.Add(this.NameTextBox);
            this.FiltrPanel.Controls.Add(this.HideButton);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 47);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(1076, 120);
            this.FiltrPanel.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(900, 62);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(142, 32);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Категория";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "",
            "Хлебобулочные изделия",
            "Кисломолочные продукты",
            "Мясные продукты",
            "Фрукты",
            "Овощи"});
            this.CategoryComboBox.Location = new System.Drawing.Point(465, 59);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(301, 33);
            this.CategoryComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(124, 59);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(194, 30);
            this.NameTextBox.TabIndex = 1;
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(12, 0);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(130, 34);
            this.HideButton.TabIndex = 0;
            this.HideButton.Text = "Скрыть";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 167);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1076, 454);
            this.MainPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 621);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.FiltrPanel);
            this.Controls.Add(this.AuthPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}

