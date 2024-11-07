using System.Linq;
using System.Windows.Forms;


namespace Positional
{
    public static class PositionRelative
    {
        public static void PlaceObjectsRelX(
            Control mainControl,
            Control[] controls,
            int[] ratioPercents,
            bool stretchHeight = false
            )
        {
            int[] controlsSizes = new int[controls.Length];

            for (int i = 0; i < controls.Length; i++)
            {
                controlsSizes[i] = mainControl.Width * ratioPercents[i] / 100;
                controls[i].Width = controlsSizes[i];
            }

            int nextPosition = 0;
            for (int count = 0; count < controls.Length; count++)
            {
                controls[count].Left = 0 + nextPosition;

                if (stretchHeight == true)
                {
                    controls[count].Height = mainControl.Height;
                    controls[count].Top = 0;
                }

                nextPosition += controls[count].Width;
            }

            if (ratioPercents.Sum() == 100)
            {
                int deviation = mainControl.Width - controlsSizes.Sum();

                if (deviation > 0)
                {
                    controls[controls.Length - 1].Width += 1;
                }
            }
        }

        public static void PlaceObjectsRelY(
            Control mainControl,
            Control[] controls,
            int[] ratioPercents,
            bool stretchWidth = false
            )
        {
            int[] controlsSizes = new int[controls.Length];

            for (int i = 0; i < controls.Length; i++)
            {
                controlsSizes[i] = mainControl.Height * ratioPercents[i] / 100;
                controls[i].Height = controlsSizes[i];
            }

            int nextPosition = 0;
            for (int count = 0; count < controls.Length; count++)
            {
                controls[count].Top = 0 + nextPosition;

                if (stretchWidth == true)
                {
                    controls[count].Width = mainControl.Width;
                    controls[count].Left = 0;
                }

                nextPosition += controls[count].Height;
            }

            if (ratioPercents.Sum() == 100)
            {
                int deviation = mainControl.Height - controlsSizes.Sum();

                if (deviation > 0)
                {
                    controls[controls.Length - 1].Height += deviation;
                }
            }
        }

        public static int PlaceObjectsAlongHeight(
            Control mainControl,
            Control[] controls,
            bool stretchWidth = false
            )
        {
            int allHeights = 0;
            int sector = 0;
            int step = 0;

            for (int i = 0; i < controls.Length; i++)
            {
                allHeights += controls[i].Height;
            }

            sector = mainControl.Height / controls.Length;

            step = sector / 2 - controls[0].Height / 2;
            for (int count = 0; count < controls.Length; count++)
            {
                controls[count].Top = 0 + step;

                if (stretchWidth == true)
                {
                    controls[count].Width = mainControl.Width;
                    controls[count].Left = 0;
                }

                if (count != controls.Length - 1)
                {
                    step += controls[count].Height / 2 + sector / 2
                    + sector / 2 - controls[count + 1].Height / 2;
                }
            }

            return sector;
        }

        public static void CenterAlignRelX(Control mainControl, Control controlToAlign)
        {
            controlToAlign.Left = 0 + mainControl.Width / 2 - controlToAlign.Width / 2;
        }

        public static void CenterAlignRelX(Control mainControl, Control[] controlsToAlign)
        {
            for (int i = 0; i < controlsToAlign.Length; i++)
            {
                controlsToAlign[i].Left = 0 + mainControl.Width / 2 - controlsToAlign[i].Width / 2;
            }
        }

        public static void CenterAlignRelY(Control mainControl, Control controlToAlign)
        {
            controlToAlign.Top = 0 + mainControl.Height / 2 - controlToAlign.Height / 2;
        }

        public static void CenterAlignRelY(Control mainControl, Control[] controlsToAlign)
        {
            for (int i = 0; i < controlsToAlign.Length; i++)
            {
                controlsToAlign[i].Top = 0 + mainControl.Height / 2 - controlsToAlign[i].Height / 2;
            }
        }

        public static void CenterAlignRelXY(Control mainControl, Control controlToAlign)
        {
            controlToAlign.Left = 0 + mainControl.Width / 2 - controlToAlign.Width / 2;
            controlToAlign.Top = 0 + mainControl.Height / 2 - controlToAlign.Height / 2;
        }
    }
}