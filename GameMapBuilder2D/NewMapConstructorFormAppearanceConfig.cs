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
    public static class NewMapConstructorFormAppearanceConfig
    {
        public static NewMapConstructorForm NewMapConstructorForm;

        public static void InitConfig()
        {
            ColorConfig();
            SizeConfig();
            PositionConfig();
        }

        public static void ColorConfig()
        {
            if (NewMapConstructorForm is null)
            {
                throw new ArgumentNullException(nameof(NewMapConstructorForm));
            }

            NewMapConstructorForm.BackColor = Color.FromArgb(26, 26, 26);
            NewMapConstructorForm.ConstructorElementsPanel.BackColor = Color.FromArgb(26, 26, 26);
            NewMapConstructorForm.ToolBoxPanel.BackColor = Color.FromArgb(26, 26, 26);

            NewMapConstructorForm.ConstructorElementsPanel.BorderStyle = BorderStyle.FixedSingle;
            NewMapConstructorForm.ToolBoxPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        public static void SizeConfig()
        {
            if (NewMapConstructorForm is null)
            {
                throw new ArgumentNullException(nameof(NewMapConstructorForm));
            }

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            NewMapConstructorForm.Size = new Size(screenWidth, screenHeight);

            NewMapConstructorForm.ConstructorElementsPanel.Width = (int)(screenWidth * 0.75);
            NewMapConstructorForm.ConstructorElementsPanel.Height = (int)(screenHeight * 0.7);

            NewMapConstructorForm.ToolBoxPanel.Width = NewMapConstructorForm.ConstructorElementsPanel.Width;
            NewMapConstructorForm.ToolBoxPanel.Height = (int)(screenHeight * 0.2);

            NewMapConstructorForm.MainConstructorPanel.Width = (int)(screenWidth * 0.77);
            NewMapConstructorForm.MainConstructorPanel.Height = (int)(screenHeight * 1);

            NewMapConstructorForm.ButtonPanel.Width = (int)(screenWidth * 0.23);
            NewMapConstructorForm.ButtonPanel.Height = NewMapConstructorForm.ConstructorElementsPanel.Height;
        }

        public static void PositionConfig()
        {
            if (NewMapConstructorForm is null)
            {
                throw new ArgumentNullException(nameof(NewMapConstructorForm));
            }

            int panelSector = PositionRelative.PlaceObjectsAlongHeight(
                NewMapConstructorForm.MainConstructorPanel,
                new Control[] { NewMapConstructorForm.ConstructorElementsPanel,
                NewMapConstructorForm.ToolBoxPanel},
                false
                );

            NewMapConstructorForm.ConstructorElementsPanel.Top += panelSector / 3;
            NewMapConstructorForm.ToolBoxPanel.Top += (int)(panelSector / 3.8);

            NewMapConstructorForm.ConstructorElementsPanel.Left = 20;
            NewMapConstructorForm.ToolBoxPanel.Left = NewMapConstructorForm.ConstructorElementsPanel.Left;

            NewMapConstructorForm.MainConstructorPanel.Left = 0;
            NewMapConstructorForm.MainConstructorPanel.Top = 0;

            PositionRelative.CenterAlignRelX(
                NewMapConstructorForm.MainConstructorPanel,
                new Control[] { NewMapConstructorForm.ConstructorElementsPanel,
                NewMapConstructorForm.ToolBoxPanel});

            NewMapConstructorForm.CloseButton.Left = NewMapConstructorForm.ButtonPanel.Width - NewMapConstructorForm.CloseButton.Width - 3;

            PositionRelative.CenterAlignRelX(NewMapConstructorForm.ButtonPanel,
                new Control[] {
                NewMapConstructorForm.ButtonPanel1,
                NewMapConstructorForm.ButtonPanel2
                });

            NewMapConstructorForm.ButtonPanel2.Top = NewMapConstructorForm.ConstructorElementsPanel.Top + NewMapConstructorForm.ConstructorElementsPanel.Height - NewMapConstructorForm.ButtonPanel2.Height;
        }
    }
}
