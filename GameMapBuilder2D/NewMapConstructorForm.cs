using GameMapBuilder;
using Newtonsoft.Json.Linq;
using Positional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using Ookii.Dialogs.WinForms;
using System.Collections;
using System.Text;

namespace GameMapBuilder2D
{
    public partial class NewMapConstructorForm : Form
    {
        public static TileMapConfig mainGameMap;

        public static NewMapConfigForm NewMapConfigForm;
        public static StartForm StartForm;

        public static CustomPictureBox[,] CustomPictureBoxArray;
        public static int PictureBoxWidth = 100;
        public static int PictureBoxHeight = 100;

        public static CustomPictureBox[,] CustomPictureBoxBgArray;
        public static int toolButtonWidth = 100;
        public static int toolButtonHeight = 100;

        public static string ToolBoxImagesFolderPath = null;
        public static CustomButtonToolBox[] CustomButtonToolArray;

        public static Image CurrentSelectedToolBoxImage = null;
        public static string CurrentSelectedToolBoxImagePath = null;
        public static int CurrentSelectedToolBoxImageNumber = 0;
        public static List<string> ToolBoxImagePathsList;
        public static Image[] ToolBoxImagesArray;

        public static string LoadedMapConfigFilePath = null;

        public static Panel ConstructorElementsPanel;
        public static Panel MainConstructorPanel;
        public static Panel ToolBoxPanel;
        public static Panel ButtonPanel;
        public static Panel ButtonPanel1;
        public static Panel ButtonPanel2;

        public static Button SaveMapButton;
        public static Button ClearMapButton;
        public static Button GoBackButton;

        public static Button CloseButton;

        public TileMapConfig MainGameMap
        {
            get { return mainGameMap; }
            set { mainGameMap = value; }
        }

        public NewMapConstructorForm()
        {
            mainGameMap = new TileMapConfig(0, 0);

            InitializeComponent();
            InitAppElements();
            NewMapConstructorFormAppearanceConfig.NewMapConstructorForm = this;
            NewMapConstructorFormAppearanceConfig.InitConfig();
        }

        public NewMapConstructorForm(TileMapConfig gameMap, string imageFolderPath)
        {
            CreateNewGameMap(gameMap.tileMapWidth, gameMap.tileMapHeight);
            ToolBoxImagesFolderPath = imageFolderPath;

            InitializeComponent();
            InitAppElements();
            NewMapConstructorFormAppearanceConfig.NewMapConstructorForm = this;
            NewMapConstructorFormAppearanceConfig.InitConfig();

            InitToolBoxImageList();
            InitMap();
            InitToolBox();
        }

        public void CreateNewGameMap(int mapWidth, int mapHeight)
        {
            mainGameMap = new TileMapConfig(mapWidth, mapHeight);
        }

        public void InitAppElements()
        {
            ConstructorElementsPanel = constructorPanel;
            ToolBoxPanel = toolBoxPanel;

            MainConstructorPanel = mainConstructorPanel;
            ButtonPanel = buttonPanel;
            ButtonPanel1 = buttonPanel1;
            ButtonPanel2 = buttonPanel2;

            SaveMapButton = saveMapButton;
            ClearMapButton = clearMapButton;
            GoBackButton = exitButton;
            CloseButton = closeButton;
        }

        public static void InitMap()
        {
            if (ConstructorElementsPanel != null)  // Додайте перевірку на null
            {
                CustomPictureBoxArray = new CustomPictureBox[mainGameMap.tileMapHeight, mainGameMap.tileMapWidth];

                int idCounter = 0;
                int StepLeft = 0;
                int StepTop = 0;

                for (int i = 0; i < CustomPictureBoxArray.GetLength(0); i++)
                {
                    for (int j = 0; j < CustomPictureBoxArray.GetLength(1); j++)
                    {
                        CustomPictureBoxArray[i, j] = new CustomPictureBox(
                            idCounter,
                            PictureBoxWidth,
                            PictureBoxHeight
                        );

                        if (ConstructorElementsPanel != null)  // Додайте перевірку на null
                        {
                            ConstructorElementsPanel.Controls.Add(CustomPictureBoxArray[i, j]);
                        }

                        CustomPictureBoxArray[i, j].Left = StepLeft;
                        CustomPictureBoxArray[i, j].Top = StepTop;

                        idCounter++;
                        StepLeft += PictureBoxWidth;
                    }

                    StepTop += PictureBoxHeight;
                    StepLeft = 0;
                }

                setMapElements();
            }
        }

        public static void setMapElements()
        {
            List<List<int>> allElementNumbers = new List<List<int>>();
            for (int i = 0; i < mainGameMap.tileMapWidth * mainGameMap.tileMapHeight; i++)
            {
                List<int> loadedElementNumbers = new List<int>();
                for (int j = 0; j < mainGameMap.TileMapElements[i].elementNumbers.Count; j++)
                {
                    loadedElementNumbers.Add(mainGameMap.TileMapElements[i].elementNumbers[j]);
                }
                allElementNumbers.Add(loadedElementNumbers);
            }

            List<List<Image>> allMapElementsImages = new List<List<Image>>();
            for (int i = 0; i < mainGameMap.tileMapWidth * mainGameMap.tileMapHeight; i++)
            {
                List<Image> mapElementsImages = new List<Image>();

                if (allElementNumbers[i].Count > 1)
                {
                    for (int j = 0; j < allElementNumbers[i].Count - 1; j++)
                    {
                        if (j == 0)
                        {
                            mapElementsImages.Add(ToolBoxImagesArray[allElementNumbers[i][0] - 1]);
                        }

                        if (j != allElementNumbers[i].Count - 1)
                        {
                            Image currentImage = mapElementsImages[mapElementsImages.Count - 1];
                            Image imageToOverlay = ToolBoxImagesArray[allElementNumbers[i][j + 1] - 1];

                            Image overlayedImage = ImageManager.OverlayImages(currentImage, imageToOverlay);

                            mapElementsImages.Add(overlayedImage);
                        }
                    }
                }
                else if (allElementNumbers[i].Count == 1)
                {
                    mapElementsImages.Add(ToolBoxImagesArray[allElementNumbers[i][0] - 1]);
                }

                allMapElementsImages.Add(mapElementsImages);
            }

            int c = 0;
            for (int i = 0; i < mainGameMap.tileMapHeight; i++)
            {
                for (int j = 0; j < mainGameMap.tileMapWidth; j++)
                {
                    CustomPictureBoxArray[i, j].elementNumbers = new List<int>();
                    CustomPictureBoxArray[i, j].elementNumbers.AddRange(allElementNumbers[c]);

                    CustomPictureBoxArray[i, j].imageLayers = new List<Image>();
                    CustomPictureBoxArray[i, j].imageLayers.AddRange(allMapElementsImages[c]);

                    if (CustomPictureBoxArray[i, j].imageLayers.Count > 0)
                    {
                        CustomPictureBoxArray[i, j].Image = CustomPictureBoxArray[i, j].imageLayers[CustomPictureBoxArray[i, j].imageLayers.Count - 1];
                        //CustomPictureBoxArray[i, j].BorderStyle = BorderStyle.None;
                    }
                    else
                    {
                        CustomPictureBoxArray[i, j].Image = null;
                    }

                    c++;
                }
            }
        }

        public static List<Image> overlayLoadedImages(List<int> Numberlist)
        {
            Image currentImage = null;
            Image newImage = null;
            List<Image> imageList = new List<Image>();

            if (imageList.Count > 0)
            {
                currentImage = imageList[imageList.Count - 1];
            }

            if (imageList.Count > 0 && currentImage != null)
            {
                Image overlayedImage = ImageManager.OverlayImages(currentImage, newImage); ;
                imageList.Add(overlayedImage);
            }
            else
            {
                imageList.Add(newImage);
            }

            return imageList;
        }

        public static void InitToolBox()
        {
            CustomButtonToolArray = new CustomButtonToolBox[ToolBoxImagePathsList.Count]; // Додано ініціалізацію
            Image[] resizedToolBoxImages = new Image[ToolBoxImagesArray.Length];

            for (int i = 0; i < ToolBoxImagesArray.Length; i++)
            {
                // Використовуйте Bitmap для зміни розмірів зображення
                Bitmap resizedImage = new Bitmap(ToolBoxImagesArray[i], new Size((int)(ToolBoxImagesArray[i].Width * 0.6), (int)(ToolBoxImagesArray[i].Height * 0.6)));
                resizedToolBoxImages[i] = resizedImage;
            }

            int StepLeft = 10;
            for (int i = 0; i < CustomButtonToolArray.GetLength(0); i++)
            {
                CustomButtonToolArray[i] = new CustomButtonToolBox(
                    ToolBoxImagesArray[i],
                    resizedToolBoxImages[i],
                    toolButtonWidth,
                    toolButtonHeight,
                    i + 1
                    );

                ToolBoxPanel.Controls.Add(CustomButtonToolArray[i]);
                CustomButtonToolArray[i].Left = StepLeft;
                CustomButtonToolArray[i].Top = 0;
                PositionRelative.CenterAlignRelY(ToolBoxPanel, CustomButtonToolArray[i]);

                CustomButtonToolArray[i].FlatAppearance.BorderSize = 4;

                StepLeft += toolButtonWidth + 10;
            }
        }

        public static void ReloadToolBox()
        {
            CustomButtonToolArray = new CustomButtonToolBox[ToolBoxImagesArray.Length];
            Image[] resizedToolBoxImages = new Image[ToolBoxImagesArray.Length];

            for (int i = 0; i < ToolBoxImagesArray.Length; i++)
            {
                // Використовуйте Bitmap для зміни розмірів зображення
                Bitmap resizedImage = new Bitmap(ToolBoxImagesArray[i], new Size((int)(ToolBoxImagesArray[i].Width * 0.6), (int)(ToolBoxImagesArray[i].Height * 0.6)));
                resizedToolBoxImages[i] = resizedImage;
            }

            int StepLeft = 10;
            for (int i = 0; i < CustomButtonToolArray.Length; i++)
            {
                CustomButtonToolArray[i] = new CustomButtonToolBox(
                    ToolBoxImagesArray[i],
                    resizedToolBoxImages[i],
                    toolButtonWidth,
                    toolButtonHeight,
                    i + 1
                    );

                ToolBoxPanel.Controls.Add(CustomButtonToolArray[i]);
                CustomButtonToolArray[i].isResized = true;
                CustomButtonToolArray[i].Left = StepLeft;
                CustomButtonToolArray[i].Top = 0;
                PositionRelative.CenterAlignRelY(ToolBoxPanel, CustomButtonToolArray[i]);

                CustomButtonToolArray[i].FlatAppearance.BorderSize = 4;

                StepLeft += toolButtonWidth + 10;
            }
        }

        public static void InitToolBoxImageList()
        {
            ToolBoxImagePathsList = new List<string>();
            ToolBoxImagePathsList = GetImageToolPaths(ToolBoxImagesFolderPath);

            mainGameMap.imageNames = new List<string>();
            ToolBoxImagesArray = new Image[ToolBoxImagePathsList.Count];

            for (int i = 0; i < ToolBoxImagePathsList.Count; i++)
            {
                ToolBoxImagesArray[i] = LoadImage(ToolBoxImagePathsList[i]);
                mainGameMap.imageNames.Add(Path.GetFileNameWithoutExtension(ToolBoxImagePathsList[i]));
            }
        }

        public static List<string> GetImageToolPaths(string path)
        {
            List<string> imagePaths = new List<string>();

            try
            {
                string[] files = Directory.GetFiles(path);

                string[] allowedExtensions = { ".png", ".jpg", ".jpeg" };

                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file).ToLower();
                    if (allowedExtensions.Contains(extension))
                    {
                        imagePaths.Add(file);
                    }
                }

                // Сортуємо шляхи за числовим значенням у іменах файлів
                imagePaths.Sort(new NaturalStringComparer());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return imagePaths;
        }

        // Кастомний компаратор для природного числового сортування рядків
        public class NaturalStringComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return NaturalCompare(x, y);
            }

            private static int NaturalCompare(string x, string y)
            {
                int ix = 0, iy = 0;
                while (ix < x.Length && iy < y.Length)
                {
                    if (char.IsDigit(x[ix]) && char.IsDigit(y[iy]))
                    {
                        int nx = 0;
                        while (ix < x.Length && char.IsDigit(x[ix]))
                        {
                            nx = nx * 10 + (x[ix] - '0');
                            ix++;
                        }

                        int ny = 0;
                        while (iy < y.Length && char.IsDigit(y[iy]))
                        {
                            ny = ny * 10 + (y[iy] - '0');
                            iy++;
                        }

                        int result = nx.CompareTo(ny);
                        if (result != 0)
                        {
                            return result;
                        }
                    }
                    else
                    {
                        int result = x[ix].CompareTo(y[iy]);
                        if (result != 0)
                        {
                            return result;
                        }
                        ix++;
                        iy++;
                    }
                }

                return x.Length - y.Length;
            }
        }

        public static Image LoadImage(string imgPath)
        {
            Image image = null;

            if (!string.IsNullOrEmpty(imgPath))
            {
                try
                {
                    image = Image.FromFile(imgPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to load image: {ex.Message}");
                    return null;
                };

                return image;
            }
            else
            {
                return null;
            }
        }

        public static bool LoadMap()
        {
            bool isLoaded = ShowLoadMapDialog();

            if (isLoaded)
            {
                mainGameMap = new TileMapConfig(0, 0);
                mainGameMap = DataManager.ReadJsonFileElements(LoadedMapConfigFilePath);

                string loadedMapFolderPath = Path.GetDirectoryName(LoadedMapConfigFilePath);
                string imagesFolderPath = Path.Combine(loadedMapFolderPath, "Images");
                LoadedMapConfigFilePath = imagesFolderPath;
                ToolBoxImagesFolderPath = imagesFolderPath;

                ConstructorElementsPanel.Controls.Clear();
                ToolBoxPanel.Controls.Clear();

                InitToolBoxImageList();
                InitMap();
                InitToolBox();

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ShowLoadMapDialog()
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                // Налаштовуємо властивості для зовнішнього вигляду
                fileDialog.Filter = "JSON files (*.json)|*.json";
                fileDialog.Title = "Select JSON File";
                fileDialog.CheckFileExists = true;
                fileDialog.CheckPathExists = true;
                fileDialog.DefaultExt = "json";
                fileDialog.RestoreDirectory = true;

                // Налаштовуємо OpenFileDialog
                fileDialog.AutoUpgradeEnabled = true;
                fileDialog.ShowHelp = false;

                // Встановлюємо власний стиль діалогового вікна
                fileDialog.SupportMultiDottedExtensions = true;
                fileDialog.ValidateNames = true;

                DialogResult result = fileDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fileDialog.FileName))
                {
                    // Отримуємо шлях до файлу та папки
                    LoadedMapConfigFilePath = fileDialog.FileName;
                    ToolBoxImagesFolderPath = fileDialog.FileName;

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void saveMapButton_Click(object sender, EventArgs e)
        {
            SaveNewMapProjectForm saveNewMapProjectForm = new SaveNewMapProjectForm();
            saveNewMapProjectForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want Save Changes?", "Підтвердження", MessageBoxButtons.YesNoCancel);

            // Обробка відповіді користувача
            if (result == DialogResult.Yes)
            {
                SaveNewMapProjectForm saveNewMapProjectForm = new SaveNewMapProjectForm();
                saveNewMapProjectForm.ShowDialog();

                ExitAndRestartProgram();
            }
            else if (result == DialogResult.No)
            {
                ExitAndRestartProgram();
            }
        }

        public void ExitAndRestartProgram()
        {
            Application.Restart();
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want Save Changes?", "Підтвердження", MessageBoxButtons.YesNoCancel);

            // Обробка відповіді користувача
            if (result == DialogResult.Yes)
            {
                SaveNewMapProjectForm saveNewMapProjectForm = new SaveNewMapProjectForm();
                saveNewMapProjectForm.ShowDialog();
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want Save Changes?", "Підтвердження", MessageBoxButtons.YesNoCancel);

            // Обробка відповіді користувача
            if (result == DialogResult.Yes)
            {
                SaveNewMapProjectForm saveNewMapProjectForm = new SaveNewMapProjectForm();
                saveNewMapProjectForm.ShowDialog();

                LoadMap();
            }
            else if (result == DialogResult.No)
            {
                LoadMap();
            }
        }

        private void addSpritesButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select PNG Sprites";
                openFileDialog.Filter = "PNG files (*.png)|*.png";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] selectedFiles = openFileDialog.FileNames;

                    List<Image> imagesList = new List<Image>();

                    foreach (string filePath in selectedFiles)
                    {
                        imagesList.Add(Image.FromFile(filePath));
                        mainGameMap.imageNames.Add(Path.GetFileNameWithoutExtension(filePath));
                    }

                    Image[] images = imagesList.ToArray();

                    ToolBoxImagesArray = ToolBoxImagesArray.Concat(images).ToArray();
                    ToolBoxPanel.Controls.Clear();
                    ReloadToolBox();
                }
            }
        }
    }
}