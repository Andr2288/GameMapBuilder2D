using GameMapBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ookii.Dialogs.WinForms;


namespace GameMapBuilder2D
{
    public partial class NewMapConfigForm : Form
    {
        public static StartForm StartForm;
        public static TextBox SizeWidthTextBox;
        public static TextBox SizeHeightTextBox;
        public static TextBox SelectedFolderTextBox;

        public static Control SelectFolderPanel;
        public static Control EnterMapWidthHeightPanel;
        public static Control CreateNewMapButton;

        public static bool isSpriteFolderSelected;
        public static string imageFolderPath;

        public TileMapConfig GameMap;

        public NewMapConfigForm()
        {
            InitializeComponent();
            SizeWidthTextBox = sizeWidthTextBox;
            SizeHeightTextBox = sizeHeightTextBox;
            SelectedFolderTextBox = selectedFolderTextBox;

            SelectFolderPanel = selectFolderPanel;
            EnterMapWidthHeightPanel = enterMapWidthHeightPanel;

            CreateNewMapButton = createNewMapButton;

            isSpriteFolderSelected = false;

            GameMap = new TileMapConfig(16, 9);
            NewMapConstructorForm.ToolBoxImagesFolderPath = @"C:\Users\andri\OneDrive\Рабочий стол\Sprites\Tanks\TileSet\Tiles";

            NewMapConfigFormAppearanceConfig.StartForm = this;
            NewMapConfigFormAppearanceConfig.InitConfig();
        }

        private void CreateNewMapButton_Click(object sender, EventArgs e)
        {
            CreateMap();
        }

        public void CreateMap()
        {
            if (isSpriteFolderSelected == true && GameMap.tileMapWidth > 0 && GameMap.tileMapHeight > 0)
            {
                createNewMapButton.Enabled = false;
                Cursor = Cursors.WaitCursor;

                NewMapConstructorForm newMapConstructorForm = new NewMapConstructorForm(GameMap, imageFolderPath);
                newMapConstructorForm.Show();

                StartForm.Hide();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sprite Folder is not Selected");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        public void SelectFolder()
        {
            using (VistaFolderBrowserDialog folderDialog = new VistaFolderBrowserDialog())
            {
                folderDialog.Description = "Select Folder for Sprites";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    UpdateUIForSelectedFolder(folderDialog.SelectedPath);
                }
            }
        }

        private void UpdateUIForSelectedFolder(string selectedFolderPath)
        {
            spritesFolderPathLabel.ForeColor = Color.White;
            selectedFolderTextBox.Text = selectedFolderPath;
            spritesFolderPathLabel.Text = "";

            imageFolderPath = selectedFolderPath;

            isSpriteFolderSelected = true;
        }



        private void sizeWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            int width = 0;
            if (sizeWidthTextBox.Text != "")
            {
                width = Convert.ToInt32(sizeWidthTextBox.Text);

                if (width > 150)
                {
                    sizeWidthTextBox.Text = "150";
                }
                else
                {
                    GameMap.tileMapWidth = Convert.ToInt32(sizeWidthTextBox.Text);
                }
            }
        }

        private void sizeHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            int height = 0;
            if (sizeHeightTextBox.Text != "")
            {
                height = Convert.ToInt32(sizeHeightTextBox.Text);

                if (height > 150)
                {
                    sizeHeightTextBox.Text = "150";
                }
                else
                {
                    GameMap.tileMapHeight = Convert.ToInt32(sizeHeightTextBox.Text);
                }
            }
        }

        private void sizeWidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sizeHeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sizeWidthTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateMap();
            }
        }

        private void sizeHeightTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateMap();
            }
        }

        private void selectedFolderTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectFolder();
            }
        }
    }
}
