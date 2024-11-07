namespace GameMapBuilder2D
{
    partial class NewMapConstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMapConstructorForm));
            this.constructorPanel = new System.Windows.Forms.Panel();
            this.toolBoxPanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.buttonPanel2 = new System.Windows.Forms.Panel();
            this.addSpritesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.loadMapButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveMapButton = new System.Windows.Forms.Button();
            this.clearMapButton = new System.Windows.Forms.Button();
            this.mainConstructorPanel = new System.Windows.Forms.Panel();
            this.buttonPanel1 = new System.Windows.Forms.Panel();
            this.buttonPanel.SuspendLayout();
            this.buttonPanel2.SuspendLayout();
            this.mainConstructorPanel.SuspendLayout();
            this.buttonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // constructorPanel
            // 
            this.constructorPanel.AutoScroll = true;
            this.constructorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.constructorPanel.BackColor = System.Drawing.Color.LightGray;
            this.constructorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.constructorPanel.Location = new System.Drawing.Point(37, 32);
            this.constructorPanel.Name = "constructorPanel";
            this.constructorPanel.Size = new System.Drawing.Size(612, 333);
            this.constructorPanel.TabIndex = 0;
            // 
            // toolBoxPanel
            // 
            this.toolBoxPanel.AutoScroll = true;
            this.toolBoxPanel.BackColor = System.Drawing.Color.Yellow;
            this.toolBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolBoxPanel.Location = new System.Drawing.Point(159, 430);
            this.toolBoxPanel.Name = "toolBoxPanel";
            this.toolBoxPanel.Size = new System.Drawing.Size(341, 85);
            this.toolBoxPanel.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonPanel.Controls.Add(this.buttonPanel1);
            this.buttonPanel.Controls.Add(this.buttonPanel2);
            this.buttonPanel.Controls.Add(this.closeButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPanel.Location = new System.Drawing.Point(840, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(444, 977);
            this.buttonPanel.TabIndex = 2;
            // 
            // buttonPanel2
            // 
            this.buttonPanel2.Controls.Add(this.addSpritesButton);
            this.buttonPanel2.Controls.Add(this.exitButton);
            this.buttonPanel2.Location = new System.Drawing.Point(30, 544);
            this.buttonPanel2.Name = "buttonPanel2";
            this.buttonPanel2.Size = new System.Drawing.Size(390, 227);
            this.buttonPanel2.TabIndex = 8;
            // 
            // addSpritesButton
            // 
            this.addSpritesButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addSpritesButton.FlatAppearance.BorderSize = 0;
            this.addSpritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSpritesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSpritesButton.ForeColor = System.Drawing.Color.White;
            this.addSpritesButton.Location = new System.Drawing.Point(14, 30);
            this.addSpritesButton.Name = "addSpritesButton";
            this.addSpritesButton.Size = new System.Drawing.Size(360, 56);
            this.addSpritesButton.TabIndex = 7;
            this.addSpritesButton.Text = "Add Sprites";
            this.addSpritesButton.UseVisualStyleBackColor = false;
            this.addSpritesButton.Click += new System.EventHandler(this.addSpritesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(14, 121);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(360, 56);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Go Back";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loadMapButton
            // 
            this.loadMapButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loadMapButton.FlatAppearance.BorderSize = 0;
            this.loadMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadMapButton.ForeColor = System.Drawing.Color.White;
            this.loadMapButton.Location = new System.Drawing.Point(14, 105);
            this.loadMapButton.Name = "loadMapButton";
            this.loadMapButton.Size = new System.Drawing.Size(360, 56);
            this.loadMapButton.TabIndex = 6;
            this.loadMapButton.Text = "Load Map";
            this.loadMapButton.UseVisualStyleBackColor = false;
            this.loadMapButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(391, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 5;
            this.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // saveMapButton
            // 
            this.saveMapButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveMapButton.FlatAppearance.BorderSize = 0;
            this.saveMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveMapButton.ForeColor = System.Drawing.Color.White;
            this.saveMapButton.Location = new System.Drawing.Point(14, 19);
            this.saveMapButton.Name = "saveMapButton";
            this.saveMapButton.Size = new System.Drawing.Size(360, 56);
            this.saveMapButton.TabIndex = 2;
            this.saveMapButton.Text = "Save Map";
            this.saveMapButton.UseVisualStyleBackColor = false;
            this.saveMapButton.Click += new System.EventHandler(this.saveMapButton_Click);
            // 
            // clearMapButton
            // 
            this.clearMapButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearMapButton.FlatAppearance.BorderSize = 0;
            this.clearMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearMapButton.ForeColor = System.Drawing.Color.White;
            this.clearMapButton.Location = new System.Drawing.Point(14, 197);
            this.clearMapButton.Name = "clearMapButton";
            this.clearMapButton.Size = new System.Drawing.Size(360, 56);
            this.clearMapButton.TabIndex = 1;
            this.clearMapButton.Text = "Clear";
            this.clearMapButton.UseVisualStyleBackColor = false;
            // 
            // mainConstructorPanel
            // 
            this.mainConstructorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainConstructorPanel.Controls.Add(this.constructorPanel);
            this.mainConstructorPanel.Controls.Add(this.toolBoxPanel);
            this.mainConstructorPanel.Location = new System.Drawing.Point(12, 12);
            this.mainConstructorPanel.Name = "mainConstructorPanel";
            this.mainConstructorPanel.Size = new System.Drawing.Size(690, 546);
            this.mainConstructorPanel.TabIndex = 3;
            // 
            // buttonPanel1
            // 
            this.buttonPanel1.Controls.Add(this.clearMapButton);
            this.buttonPanel1.Controls.Add(this.saveMapButton);
            this.buttonPanel1.Controls.Add(this.loadMapButton);
            this.buttonPanel1.Location = new System.Drawing.Point(30, 62);
            this.buttonPanel1.Name = "buttonPanel1";
            this.buttonPanel1.Size = new System.Drawing.Size(390, 274);
            this.buttonPanel1.TabIndex = 9;
            // 
            // NewMapConstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 977);
            this.Controls.Add(this.mainConstructorPanel);
            this.Controls.Add(this.buttonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewMapConstructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMapConstructorForm";
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel2.ResumeLayout(false);
            this.mainConstructorPanel.ResumeLayout(false);
            this.buttonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel constructorPanel;
        private System.Windows.Forms.Panel toolBoxPanel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button saveMapButton;
        private System.Windows.Forms.Button clearMapButton;
        private System.Windows.Forms.Panel mainConstructorPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button loadMapButton;
        private System.Windows.Forms.Panel buttonPanel2;
        private System.Windows.Forms.Button addSpritesButton;
        private System.Windows.Forms.Panel buttonPanel1;
    }
}