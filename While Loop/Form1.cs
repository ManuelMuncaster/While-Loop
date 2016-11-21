using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Loop
{
    public partial class Form1 : Form
    {
        int startingNum;
        int endingNum;

        int xPosition;
        int yPosition;
        int redColor;
        int greenColor;
        int blueColor;
        int yellowColor;
        int counter;
        int width;
        int height;
        public Form1()
        {
            InitializeComponent();

        }

        private void valueButton_Click(object sender, EventArgs e)
        {
            startingNum = Convert.ToInt32(startingTextbox.Text);
            endingNum = Convert.ToInt32(endingTextbox.Text);

            outputLabel.Text = "";
            while (startingNum <= endingNum)
            {
                outputLabel.Text += startingNum + " ";
                startingNum++;
 

            }

        }

        private void starButton_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = false;
            endingnumberLabel.Visible = false;
            startingTextbox.Visible = false;
            endingTextbox.Visible = false;
            valueButton.Visible = false;
            starButton.Visible = false;

            while (counter < 1000)
            {
                Random randGen = new Random();
                Graphics formGraphics = this.CreateGraphics();
                Pen drawPen = new Pen(Color.Black);
                SolidBrush drawFill = new SolidBrush(Color.Black);

                xPosition = randGen.Next(1, 300);
                yPosition = randGen.Next(1, 300);
                redColor = randGen.Next(1, 300);
                greenColor = randGen.Next(1, 300);
                blueColor = randGen.Next(1, 300);
                width = randGen.Next(1, 300);
                height = randGen.Next(1, 300);

                drawPen.Color = Color.FromArgb(redColor, greenColor, blueColor);
                drawFill.Color = Color.FromArgb(redColor, greenColor, blueColor);

                formGraphics.FillEllipse(drawFill, xPosition, yPosition, width, height);

                counter++;


            }
        }
    }
}
