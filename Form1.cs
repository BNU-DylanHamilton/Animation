using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form
    {
        const int MAX = 4;              // number of images
        Image[] heli = new Image[MAX];  // create array called heli
        Image[] pigs = new Image[MAX]; //create array called pigs
        int count = 0, background = 0;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void loadForm(object sender, EventArgs e)
        {
            // load image files into the pics array
            for (int i = 0; i < MAX; i++)
            {
                heli[i] = Image.FromFile("copter" + i + ".gif");
            }

            for(int i = 0; i < MAX; i++)
            {
                pigs[i] = Image.FromFile("Pig" + i + ".gif");
            }
        }
        
        /// <summary>
        /// This method animates the pictures, moves the images to the right side of 
        /// the screen and moves the pictures down as they reappear on the left side.
        /// This method also changes the background image as the pictures reappear
        /// on the left side of the screen.
        /// </summary>
        private void animatePicture(object sender, EventArgs e)
        {
            helicopterPictureBox.Image = heli[count];  // show an image from the array
            pigPictureBox.Image = pigs[count];
            count++;                        // move on to next pic
            if (count == MAX) count = 0;    // reset to zero

            helicopterPictureBox.Left = helicopterPictureBox.Left + 10; //add 10 to the left coordinate
            if(helicopterPictureBox.Left >= this.Width) //has picture left side reached edge of this form?
            {
                helicopterPictureBox.Left = 0; //set Left coordinate of picture to zero
                helicopterPictureBox.Top = helicopterPictureBox.Top + 20; //add 20 to the top coordinate
                if(helicopterPictureBox.Top >= this.Height) //has picture top side reached bottom of this form?
                {
                    helicopterPictureBox.Top = 0; //set top coordinate of picture to zero
                }

                if (background == 0)
                {
                    Bitmap bm = new Bitmap("City2.wmf");
                    this.BackgroundImage = bm;
                    background++; 
                }
                else if (background == 1) 
                {
                    Bitmap bm = new Bitmap("City3.wmf");
                    this.BackgroundImage = bm;
                    background++;
                }
                else if(background == 2)
                {
                    Bitmap bm = new Bitmap("City1.wmf");
                    this.BackgroundImage = bm;
                    background = 0;
                }
            }

            pigPictureBox.Left = pigPictureBox.Left + 10;
            if(pigPictureBox.Left >= this.Width)
            {
                pigPictureBox.Left = 0;
                pigPictureBox.Top = helicopterPictureBox.Top + 20;
                if(pigPictureBox.Top >= this.Height)
                {
                    pigPictureBox.Top = 0;
                }
            }
        }

        private void startTimer(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stopTimer(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void setSpeed(object sender, ScrollEventArgs e)
        {
            int amount = speedScrollBar.Value + 1; //get the value and add 1 to avoid zero
            timer1.Interval = amount; //sets the interval value as the amount variable.
        }

        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}