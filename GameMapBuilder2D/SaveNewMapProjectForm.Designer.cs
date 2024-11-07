namespace GameMapBuilder2D
{
    partial class SaveNewMapProjectForm
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
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectPathTextBox = new System.Windows.Forms.TextBox();
            this.selectProjectFolderPathButton = new System.Windows.Forms.Button();
            this.createNewMapButton = new System.Windows.Forms.Button();
            this.elementsPanel = new System.Windows.Forms.Panel();
            this.elementsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectNameTextBox.ForeColor = System.Drawing.Color.White;
            this.projectNameTextBox.Location = new System.Drawing.Point(37, 87);
            this.projectNameTextBox.Multiline = true;
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(640, 43);
            this.projectNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter MapProject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Path to Save";
            // 
            // projectPathTextBox
            // 
            this.projectPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectPathTextBox.ForeColor = System.Drawing.Color.White;
            this.projectPathTextBox.Location = new System.Drawing.Point(37, 214);
            this.projectPathTextBox.Multiline = true;
            this.projectPathTextBox.Name = "projectPathTextBox";
            this.projectPathTextBox.ReadOnly = true;
            this.projectPathTextBox.Size = new System.Drawing.Size(640, 43);
            this.projectPathTextBox.TabIndex = 2;
            this.projectPathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.projectPathTextBox_KeyDown);
            // 
            // selectProjectFolderPathButton
            // 
            this.selectProjectFolderPathButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.selectProjectFolderPathButton.FlatAppearance.BorderSize = 0;
            this.selectProjectFolderPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectProjectFolderPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectProjectFolderPathButton.ForeColor = System.Drawing.Color.White;
            this.selectProjectFolderPathButton.Location = new System.Drawing.Point(693, 214);
            this.selectProjectFolderPathButton.Name = "selectProjectFolderPathButton";
            this.selectProjectFolderPathButton.Size = new System.Drawing.Size(43, 43);
            this.selectProjectFolderPathButton.TabIndex = 4;
            this.selectProjectFolderPathButton.Text = "...";
            this.selectProjectFolderPathButton.UseVisualStyleBackColor = false;
            this.selectProjectFolderPathButton.Click += new System.EventHandler(this.selectProjectFolderPathButton_Click);
            // 
            // createNewMapButton
            // 
            this.createNewMapButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.createNewMapButton.FlatAppearance.BorderSize = 0;
            this.createNewMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewMapButton.ForeColor = System.Drawing.Color.White;
            this.createNewMapButton.Location = new System.Drawing.Point(37, 311);
            this.createNewMapButton.Name = "createNewMapButton";
            this.createNewMapButton.Size = new System.Drawing.Size(699, 56);
            this.createNewMapButton.TabIndex = 5;
            this.createNewMapButton.Text = "Save Map Project";
            this.createNewMapButton.UseVisualStyleBackColor = false;
            this.createNewMapButton.Click += new System.EventHandler(this.createNewMapButton_Click);
            // 
            // elementsPanel
            // 
            this.elementsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementsPanel.Controls.Add(this.label2);
            this.elementsPanel.Controls.Add(this.createNewMapButton);
            this.elementsPanel.Controls.Add(this.projectNameTextBox);
            this.elementsPanel.Controls.Add(this.selectProjectFolderPathButton);
            this.elementsPanel.Controls.Add(this.label1);
            this.elementsPanel.Controls.Add(this.projectPathTextBox);
            this.elementsPanel.Location = new System.Drawing.Point(37, 65);
            this.elementsPanel.Name = "elementsPanel";
            this.elementsPanel.Size = new System.Drawing.Size(775, 404);
            this.elementsPanel.TabIndex = 9;
            // 
            // SaveNewMapProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(851, 519);
            this.Controls.Add(this.elementsPanel);
            this.Name = "SaveNewMapProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveNewMapProjectForm";
            this.elementsPanel.ResumeLayout(false);
            this.elementsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projectPathTextBox;
        private System.Windows.Forms.Button selectProjectFolderPathButton;
        private System.Windows.Forms.Button createNewMapButton;
        private System.Windows.Forms.Panel elementsPanel;
    }
}