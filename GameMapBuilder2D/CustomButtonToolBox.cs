using GameMapBuilder2D;
using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomButtonToolBox : Button
{
    Image currentImage;
    Image currentImageResized;


    public string imgPath;
    public int ToolElemntNumber { get; set; }
    public bool isResized = false;

    public CustomButtonToolBox(Image image, Image imageResized, int width, int height, int toolElementNumber)
    {
        this.currentImage = image;
        this.currentImageResized = imageResized;
        Width = width;
        Height = height;
        ToolElemntNumber = toolElementNumber;

        ConfigElementAppearance();

        this.Click += CustomButton_Click;
    }

    public void ConfigElementAppearance()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 4;
        FlatAppearance.BorderColor = Color.CornflowerBlue;
        BackColor = Color.FromArgb(25, 25, 25);
        BackgroundImageLayout = ImageLayout.Center;
        Image = currentImageResized;
    }
    private void changeBorderColor()
    {
        for (int i = 0; i < NewMapConstructorForm.CustomButtonToolArray.Length; i++)
        {
            NewMapConstructorForm.CustomButtonToolArray[i].FlatAppearance.BorderColor = Color.CornflowerBlue;
        }

        FlatAppearance.BorderColor = Color.Yellow;
    }

    private void CustomButton_Click(object sender, EventArgs e)
    {
        changeBorderColor();

        NewMapConstructorForm.CurrentSelectedToolBoxImage = this.currentImage;
        NewMapConstructorForm.CurrentSelectedToolBoxImagePath = this.imgPath;
        NewMapConstructorForm.CurrentSelectedToolBoxImageNumber = this.ToolElemntNumber;
    }
}