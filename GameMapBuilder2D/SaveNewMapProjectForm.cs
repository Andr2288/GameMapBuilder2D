using Ookii.Dialogs.WinForms;
using Positional;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameMapBuilder2D
{
    public partial class SaveNewMapProjectForm : Form
    {
        public static string ProjectToSaveFolderPath;

        public SaveNewMapProjectForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.BackColor = Color.FromArgb(28, 28, 28);

            projectNameTextBox.BackColor = projectPathTextBox.BackColor = Color.FromArgb(30, 30, 30);
            ProjectToSaveFolderPath = null;
        }

        private void selectProjectFolderPathButton_Click(object sender, EventArgs e)
        {
            ChooseProjectFolderPath();
        }

        private void createNewMapButton_Click(object sender, EventArgs e)
        {
            if (ProjectToSaveFolderPath != null)
            {
                SaveMapProject();
            }
            else
            {
                MessageBox.Show("Select Folder Path Firstly");
            }
        }

        private void ChooseProjectFolderPath()
        {
            using (var folderDialog = new VistaFolderBrowserDialog())
            {
                folderDialog.Description = "Виберіть папку для збереження даних";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    ProjectToSaveFolderPath = folderDialog.SelectedPath;
                    projectPathTextBox.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void SaveMapProject()
        {
            Cursor = Cursors.WaitCursor;

            string projectFolderName = projectNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(projectFolderName))
            {
                MessageBox.Show("Enter Folder Name");
                Cursor = Cursors.Default;
                return;
            }

            string projectFolderPath = Path.Combine(ProjectToSaveFolderPath, projectFolderName);

            if (CreateFolder(ProjectToSaveFolderPath, projectFolderName))
            {
                MessageBox.Show("Folder Already Exist");
                Cursor = Cursors.Default;
                return;
            }

            CreateFolder(projectFolderPath, "Images");
            SavePicturesToFolder(Path.Combine(projectFolderPath, "Images"));

            DataManager.WriteJsonFileElements(NewMapConstructorForm.mainGameMap, Path.Combine(projectFolderPath, projectFolderName + ".json"));

            Cursor = Cursors.Default;
            this.Close();
        }

        private void SavePicturesToFolder(string destinationFolderPath)
        {
            Image[] images = NewMapConstructorForm.ToolBoxImagesArray;

            for (int i = 0; i < images.Length; i++)
            {
                SaveImageToFile(images[i], destinationFolderPath, i + 1);
            }
        }

        private void SaveImageToFile(Image image, string destinationFolderPath, int index)
        {
            Bitmap bitmap = new Bitmap(image);
            //string fileName = NewMapConstructorForm.mainGameMap.imageNames[index - 1] + ".png";

            //if (NewMapConstructorForm.LoadedMapConfigFilePath == null)
            //{
            //string sourseName = NewMapConstructorForm.mainGameMap.imageNames[index - 1];
            string fileName = $"Photo_{index}.png";
            //}
            
            string destinationFilePath = Path.Combine(destinationFolderPath, fileName);

            try
            {
                bitmap.Save(destinationFilePath, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving {fileName}: {ex.Message}");
            }
            finally
            {
                bitmap.Dispose();
            }
        }

        public static bool CreateFolder(string parentFolderPath, string folderName)
        {
            string folderPath = Path.Combine(parentFolderPath, folderName);

            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating folder: {ex.Message}");
                }
            }

            return true;
        }

        private void projectPathTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                ChooseProjectFolderPath();
            }
        }
    }
}
