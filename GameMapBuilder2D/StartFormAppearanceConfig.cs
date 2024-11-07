using GameMapBuilder2D;
using Positional;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMapBuilder
{
    public static class StartFormAppearanceConfig
    {
        public static StartForm StartForm;

        public static void InitConfig()
        {
            ColorConfig();
            SizeConfig();
            PositionConfig();
        }

        public static void ColorConfig()
        {
            if (StartForm is null)
            {
                throw new ArgumentNullException(nameof(StartForm));
            }

            StartForm.BackColor = Color.FromArgb(26, 26, 26);
        }

        public static void SizeConfig()
        {
            if (StartForm is null)
            {
                throw new ArgumentNullException(nameof(StartForm));
            }

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            StartForm.Width = (int)(screenWidth * 0.7);
            StartForm.Height = (int)(screenHeight * 0.7);

            StartForm.MainPanel.Width = (int)(StartForm.Width * 0.35);
            StartForm.MainPanel.Height = (int)(StartForm.Height * 0.25);
        }

        public static void PositionConfig()
        {
            if (StartForm is null)
            {
                throw new ArgumentNullException(nameof(StartForm));
            }

            PositionRelative.CenterAlignRelXY(StartForm, StartForm.MainPanel);

            PositionRelative.CenterAlignRelX(StartForm.MainPanel, StartForm.CreateNewMapButton);
            PositionRelative.CenterAlignRelX(StartForm.MainPanel, StartForm.LoadMapButton);

            PositionRelative.PlaceObjectsAlongHeight(
                StartForm.MainPanel,
                new Control[] { StartForm.CreateNewMapButton, StartForm.LoadMapButton}
                );
        }
    }
}
