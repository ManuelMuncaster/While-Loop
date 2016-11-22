using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            enternumberLabel.Visible = false;
            startingTextbox.Visible = false;
            endingTextbox.Visible = false;
            valueButton.Visible = false;
            starButton.Visible = false;
            Random randGen = new Random();

            while (counter < 100000)
            {
               
                Graphics formGraphics = this.CreateGraphics();
                Pen drawPen = new Pen(Color.Black);
                SolidBrush drawFill = new SolidBrush(Color.Black);

                xPosition = randGen.Next(1, 250);
                yPosition = randGen.Next(1, 250);
                redColor = randGen.Next(1, 255);
                greenColor = randGen.Next(1, 255);
                blueColor = randGen.Next(1, 255);
                width = randGen.Next(20, 25);
                height = randGen.Next(20, 25);

                drawFill.Color = Color.FromArgb(redColor, greenColor, blueColor);

                formGraphics.FillEllipse(drawFill, xPosition, yPosition, width, height);

                counter++;
            }
        }

        private void fireworkButton_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = false;
            endingnumberLabel.Visible = false;
            enternumberLabel.Visible = false;
            startingTextbox.Visible = false;
            endingTextbox.Visible = false;
            valueButton.Visible = false;
            starButton.Visible = false;
            fireworkButton.Visible = false;

            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //initialize
            int x = 200;
            int y = 250;

            //test
            while (y >= 100)
            {
                //act
                g.Clear(Color.Black);
                g.FillRectangle(drawBrush, x, y, 10, 10);

                Thread.Sleep(10);

                //change
                y--;


            }
        }
    }
}
