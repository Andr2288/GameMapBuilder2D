namespace GameMapBuilder2D
{
    partial class NewMapConfigForm
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
            this.createNewMapButton = new System.Windows.Forms.Button();
            this.sizeWidthTextBox = new System.Windows.Forms.TextBox();
            this.sizeHeightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spritesFolderPathLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selectFolderPanel = new System.Windows.Forms.Panel();
            this.enterMapWidthHeightPanel = new System.Windows.Forms.Panel();
            this.selectedFolderTextBox = new System.Windows.Forms.TextBox();
            this.selectFolderPanel.SuspendLayout();
            this.enterMapWidthHeightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createNewMapButton
            // 
            this.createNewMapButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.createNewMapButton.FlatAppearance.BorderSize = 0;
            this.createNewMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewMapButton.ForeColor = System.Drawing.Color.White;
            this.createNewMapButton.Location = new System.Drawing.Point(164, 421);
            this.createNewMapButton.Name = "createNewMapButton";
            this.createNewMapButton.Size = new System.Drawing.Size(775, 56);
            this.createNewMapButton.TabIndex = 0;
            this.createNewMapButton.Text = "Create Map";
            this.createNewMapButton.UseVisualStyleBackColor = false;
            this.createNewMapButton.Click += new System.EventHandler(this.CreateNewMapButton_Click);
            // 
            // sizeWidthTextBox
            // 
            this.sizeWidthTextBox.BackColor = System.Drawing.Color.Black;
            this.sizeWidthTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeWidthTextBox.ForeColor = System.Drawing.Color.White;
            this.sizeWidthTextBox.Location = new System.Drawing.Point(455, 35);
            this.sizeWidthTextBox.Name = "sizeWidthTextBox";
            this.sizeWidthTextBox.Size = new System.Drawing.Size(106, 39);
            this.sizeWidthTextBox.TabIndex = 1;
            this.sizeWidthTextBox.Text = "16";
            this.sizeWidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeWidthTextBox.TextChanged += new System.EventHandler(this.sizeWidthTextBox_TextChanged);
            this.sizeWidthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sizeWidthTextBox_KeyDown);
            this.sizeWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeWidthTextBox_KeyPress);
            // 
            // sizeHeightTextBox
            // 
            this.sizeHeightTextBox.BackColor = System.Drawing.Color.Black;
            this.sizeHeightTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeHeightTextBox.ForeColor = System.Drawing.Color.White;
            this.sizeHeightTextBox.Location = new System.Drawing.Point(455, 90);
            this.sizeHeightTextBox.Name = "sizeHeightTextBox";
            this.sizeHeightTextBox.Size = new System.Drawing.Size(106, 39);
            this.sizeHeightTextBox.TabIndex = 2;
            this.sizeHeightTextBox.Text = "9";
            this.sizeHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeHeightTextBox.TextChanged += new System.EventHandler(this.sizeHeightTextBox_TextChanged);
            this.sizeHeightTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sizeHeightTextBox_KeyDown);
            this.sizeHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeHeightTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter map width";
            // 
            // spritesFolderPathLabel
            // 
            this.spritesFolderPathLabel.AutoSize = true;
            this.spritesFolderPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spritesFolderPathLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.spritesFolderPathLabel.Location = new System.Drawing.Point(21, 18);
            this.spritesFolderPathLabel.Name = "spritesFolderPathLabel";
            this.spritesFolderPathLabel.Size = new System.Drawing.Size(168, 25);
            this.spritesFolderPathLabel.TabIndex = 4;
            this.spritesFolderPathLabel.Text = "No folder selected";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(712, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(232, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter map height";
            // 
            // selectFolderPanel
            // 
            this.selectFolderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectFolderPanel.Controls.Add(this.selectedFolderTextBox);
            this.selectFolderPanel.Controls.Add(this.spritesFolderPathLabel);
            this.selectFolderPanel.Controls.Add(this.button1);
            this.selectFolderPanel.Location = new System.Drawing.Point(164, 72);
            this.selectFolderPanel.Name = "selectFolderPanel";
            this.selectFolderPanel.Size = new System.Drawing.Size(775, 133);
            this.selectFolderPanel.TabIndex = 7;
            // 
            // enterMapWidthHeightPanel
            // 
            this.enterMapWidthHeightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterMapWidthHeightPanel.Controls.Add(this.sizeWidthTextBox);
            this.enterMapWidthHeightPanel.Controls.Add(this.label3);
            this.enterMapWidthHeightPanel.Controls.Add(this.sizeHeightTextBox);
            this.enterMapWidthHeightPanel.Controls.Add(this.label1);
            this.enterMapWidthHeightPanel.Location = new System.Drawing.Point(164, 229);
            this.enterMapWidthHeightPanel.Name = "enterMapWidthHeightPanel";
            this.enterMapWidthHeightPanel.Size = new System.Drawing.Size(775, 166);
            this.enterMapWidthHeightPanel.TabIndex = 8;
            // 
            // selectedFolderTextBox
            // 
            this.selectedFolderTextBox.BackColor = System.Drawing.Color.Black;
            this.selectedFolderTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedFolderTextBox.ForeColor = System.Drawing.Color.White;
            this.selectedFolderTextBox.Location = new System.Drawing.Point(26, 62);
            this.selectedFolderTextBox.Multiline = true;
            this.selectedFolderTextBox.Name = "selectedFolderTextBox";
            this.selectedFolderTextBox.ReadOnly = true;
            this.selectedFolderTextBox.Size = new System.Drawing.Size(664, 41);
            this.selectedFolderTextBox.TabIndex = 6;
            this.selectedFolderTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.selectedFolderTextBox_KeyDown);
            // 
            // NewMapConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1077, 531);
            this.Controls.Add(this.enterMapWidthHeightPanel);
            this.Controls.Add(this.createNewMapButton);
            this.Controls.Add(this.selectFolderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewMapConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMapConfigForm";
            this.selectFolderPanel.ResumeLayout(false);
            this.selectFolderPanel.PerformLayout();
            this.enterMapWidthHeightPanel.ResumeLayout(false);
            this.enterMapWidthHeightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createNewMapButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeHeightTextBox;
        private System.Windows.Forms.TextBox sizeWidthTextBox;
        private System.Windows.Forms.Label spritesFolderPathLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel enterMapWidthHeightPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel selectFolderPanel;
        private System.Windows.Forms.TextBox selectedFolderTextBox;
    }
}