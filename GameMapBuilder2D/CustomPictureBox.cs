using GameMapBuilder2D;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class CustomPictureBox : PictureBox
{
    public static NewMapConstructorForm newMapConstructorForm;

    public int id;
    public TileMapConfigElement GameMapElement;

    public List<Image> imageLayers;
    public List<int> elementNumbers;
    public List<string> imagePaths;

    public Image currentElementImage;
    public Image backgroundImage;

    public string ImgPath { get; set; }

    public bool isReadyToInteract = true;

    public CustomPictureBox(int id, int width, int height)
    {
        this.id = id;
        Width = width;
        Height = height;

        BackColor = Color.FromArgb(26, 26, 26);
        SizeMode = PictureBoxSizeMode.Zoom;
        BorderStyle = BorderStyle.FixedSingle;

        this.Click += CustomPictureBox_Click;
        this.MouseUp += CustomPictureBox_MouseUp;

        imageLayers = new List<Image>();
        elementNumbers = new List<int>();
        imagePaths = new List<string>();

    }

    private void CustomPictureBox_Click(object sender, EventArgs e)
    {
        MouseEventArgs me = e as MouseEventArgs;
        if (me != null && me.Button == MouseButtons.Left && isReadyToInteract)
        {
            isReadyToInteract = false;

            if (NewMapConstructorForm.CurrentSelectedToolBoxImage != null)
            {
                Image currentImage = null;
                Image newImage = NewMapConstructorForm.CurrentSelectedToolBoxImage;

                if (imageLayers.Count > 0)
                {
                    currentImage = imageLayers[imageLayers.Count - 1];
                }

                if (imageLayers.Count > 0 && currentImage != null)
                {
                    Image overlayedImage = ImageManager.OverlayImages(currentImage, newImage); ;
                    Image = overlayedImage;
                    imageLayers.Add(overlayedImage);

                    currentElementImage = overlayedImage;

                    AddElementsToGameMap();
                    //BorderStyle = BorderStyle.None;
                }
                else
                {
                    Image = newImage;
                    imageLayers.Add(newImage);

                    currentElementImage = newImage;

                    AddElementsToGameMap();
                    //BorderStyle = BorderStyle.None;
                }



            }

            isReadyToInteract = true;
        }

        //MessageBox.Show(imageLayers.Count + " ImageLayers Count");
        //MessageBox.Show(NewMapConstructorForm.mainGameMap.GameMapElements[this.id].elementNumbers.Count + " El num Count");
    }


    public void AddElementsToGameMap()
    {
        NewMapConstructorForm.mainGameMap.TileMapElements[this.id].elementNumbers.Add(NewMapConstructorForm.CurrentSelectedToolBoxImageNumber);
        isReadyToInteract = true;
    }

    public void RemoveElementsFromGameMap()
    {
        int lastItemIndex = 0;

        if (NewMapConstructorForm.mainGameMap.TileMapElements[this.id].elementNumbers.Count > 0)
        {
            lastItemIndex = NewMapConstructorForm.mainGameMap.TileMapElements[this.id].elementNumbers.Count - 1;
        }

        NewMapConstructorForm.mainGameMap.TileMapElements[this.id].elementNumbers.RemoveAt(lastItemIndex);
        //MessageBox.Show(NewMapConstructorForm.mainGameMap.GameMapElements[this.id].elementNumbers.Count + "");
        //MessageBox.Show(lastItemIndex + "");
        //MessageBox.Show(imageLayers.Count + "");
    }

    private void CustomPictureBox_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right && isReadyToInteract)
        {
            isReadyToInteract = false;
            
            if (imageLayers.Count >= 2)
            {
                Image previousImage = imageLayers[imageLayers.Count - 2];

                Image = previousImage;
                imageLayers.RemoveAt(imageLayers.Count - 1);

                currentElementImage = previousImage;

                RemoveElementsFromGameMap();
            }
            else if (imageLayers.Count == 1)
            {
                Image = null;
                imageLayers.RemoveAt(imageLayers.Count - 1);

                currentElementImage = null;

                RemoveElementsFromGameMap();
                //BorderStyle = BorderStyle.FixedSingle;
            }

            isReadyToInteract = true;
        }
    }

    public bool AddPictureLayer(Image newImage)
    {
        if (newImage != null)
        {
            try
            {
                Image currentImage = Image;
                Image imageToOverlay = newImage;
                Image overlayedImage = ImageManager.OverlayImages(currentImage, imageToOverlay);

                Image = overlayedImage;
                
                currentImage = overlayedImage;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load image: {ex.Message}");
                return false;
            }

            return true;
        }
        else
        {
            return false;
        }
    }
}