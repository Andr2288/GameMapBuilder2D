namespace GameMapBuilder2D
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.loadMapButton = new System.Windows.Forms.Button();
            this.createNewMapButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.loadMapButton);
            this.mainPanel.Controls.Add(this.createNewMapButton);
            this.mainPanel.Location = new System.Drawing.Point(263, 88);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(508, 193);
            this.mainPanel.TabIndex = 0;
            // 
            // loadMapButton
            // 
            this.loadMapButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loadMapButton.FlatAppearance.BorderSize = 0;
            this.loadMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadMapButton.ForeColor = System.Drawing.Color.White;
            this.loadMapButton.Location = new System.Drawing.Point(83, 107);
            this.loadMapButton.Name = "loadMapButton";
            this.loadMapButton.Size = new System.Drawing.Size(327, 55);
            this.loadMapButton.TabIndex = 1;
            this.loadMapButton.Text = "Load Map";
            this.loadMapButton.UseVisualStyleBackColor = false;
            this.loadMapButton.Click += new System.EventHandler(this.loadMapButton_Click);
            // 
            // createNewMapButton
            // 
            this.createNewMapButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.createNewMapButton.FlatAppearance.BorderSize = 0;
            this.createNewMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewMapButton.ForeColor = System.Drawing.Color.White;
            this.createNewMapButton.Location = new System.Drawing.Point(83, 29);
            this.createNewMapButton.Name = "createNewMapButton";
            this.createNewMapButton.Size = new System.Drawing.Size(327, 55);
            this.createNewMapButton.TabIndex = 0;
            this.createNewMapButton.Text = "Create New Map";
            this.createNewMapButton.UseVisualStyleBackColor = false;
            this.createNewMapButton.Click += new System.EventHandler(this.createNewMapButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMapBuilder2D";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button createNewMapButton;
        private System.Windows.Forms.Button loadMapButton;
    }
}

