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
    public static class NewMapConfigFormAppearanceConfig
    {
        public static NewMapConfigForm StartForm;

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

            StartForm.BackColor = Color.FromArgb(28, 28, 28);
            NewMapConfigForm.SizeWidthTextBox.BackColor = Color.FromArgb(28, 28, 28);
            NewMapConfigForm.SizeHeightTextBox.BackColor = Color.FromArgb(28, 28, 28);
            NewMapConfigForm.SelectedFolderTextBox.BackColor = Color.FromArgb(28, 28, 28);
        }

        public static void SizeConfig()
        {
            if (StartForm is null)
            {
                throw new ArgumentNullException(nameof(StartForm));
            }
        }

        public static void PositionConfig()
        {
            if (StartForm is null)
            {
                throw new ArgumentNullException(nameof(StartForm));
            }

            PositionRelative.CenterAlignRelX(StartForm,
                new Control[]
                {
                    NewMapConfigForm.SelectFolderPanel,
                    NewMapConfigForm.EnterMapWidthHeightPanel,
                    NewMapConfigForm.CreateNewMapButton
                });
        }
    }
}
