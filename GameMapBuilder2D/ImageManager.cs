using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMapBuilder2D
{
    internal class ImageManager
    {
        public static Image OverlayImages(Image background, Image overlay)
        {
            // Створити новий зображення та отримати Graphics для малювання
            Bitmap resultImage = new Bitmap(overlay.Width, overlay.Height);
            using (Graphics g = Graphics.FromImage(resultImage))
            {
                // Намалювати перше зображення (фон)
                g.DrawImage(background, 0, 0);

                // Накладіть друге зображення (перекривання)
                g.DrawImage(overlay, 0, 0);
            }

            return resultImage;
        }


        public static Image ApplyDesaturationEffect(Image originalImage, float desaturationFactor)
        {
            // Створити новий зображення та отримати Graphics для малювання
            Bitmap desaturatedImage = new Bitmap(originalImage.Width, originalImage.Height);
            using (Graphics g = Graphics.FromImage(desaturatedImage))
            {
                // Застосувати ефект втрати насиченості кожному пікселю
                for (int x = 0; x < originalImage.Width; x++)
                {
                    for (int y = 0; y < originalImage.Height; y++)
                    {
                        // Отримати колір пікселя
                        Color originalColor = ((Bitmap)originalImage).GetPixel(x, y);

                        // Знайти середнє значення кольору
                        int averageColor = (originalColor.R + originalColor.G + originalColor.B) / 3;

                        // Змінити кольори з використанням середнього значення та фактора втрати насиченості
                        int newRed = (int)(averageColor + desaturationFactor * (originalColor.R - averageColor));
                        int newGreen = (int)(averageColor + desaturationFactor * (originalColor.G - averageColor));
                        int newBlue = (int)(averageColor + desaturationFactor * (originalColor.B - averageColor));

                        // Застосувати новий колір до пікселя
                        desaturatedImage.SetPixel(x, y, Color.FromArgb(newRed, newGreen, newBlue));
                    }
                }
            }

            return desaturatedImage;
        }
    }
}
