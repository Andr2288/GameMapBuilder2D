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

namespace GameMapBuilder2D
{
    public partial class StartForm : Form
    {
        public static Control MainPanel;

        public static Control CreateNewMapButton; 
        public static Control LoadMapButton; 
        public StartForm()
        {
            InitializeComponent();
            InitElements();
            StartFormAppearanceConfig.StartForm = this;
            StartFormAppearanceConfig.InitConfig();
        }

        public void InitElements()
        {
            NewMapConfigForm.StartForm = this;
            MainPanel = mainPanel;

            CreateNewMapButton = createNewMapButton;
            LoadMapButton = loadMapButton;
        }

        private void createNewMapButton_Click(object sender, EventArgs e)
        {
            NewMapConfigForm newMapConfigForm = new NewMapConfigForm();
            newMapConfigForm.ShowDialog();
        }

        private void loadMapButton_Click(object sender, EventArgs e)
        {
            LoadMap();
        }


        public void LoadMap()
        {
            Cursor = Cursors.WaitCursor;
            NewMapConstructorForm newMapConstructorForm = new NewMapConstructorForm();
            bool isLoaded = NewMapConstructorForm.LoadMap();

            Cursor = Cursors.Default;

            if (isLoaded)
            {
                newMapConstructorForm.Show();
            }
        }

        public void CheckFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Folfer didn`t found: " + folderPath);
            }
        }
    }
}
