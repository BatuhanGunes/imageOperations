# Image Operations

* image Rotation, Displacement, Dimensioning operations with c#


### Operations that can be done in the application

- Image upload
- Clockwise and anti-clockwise rotation
- Enlarge and reduce
- Translational up, down, right, and left
- Multiple magnifications
- Size adjustment with proportional coefficient
- See picture resolution

### Screenshots

![Screenshot](https://github.com/BatuhanGunes/imageOperations/blob/master/Screenshot.png)

### code

        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //TurnOff Aplication
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                pictureBox.ImageLocation = openFileDialog1.FileName;
                bmp = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                textBoxFileName.Text = openFileDialog1.FileName;
                labelResolution.Text = pictureBox.Height.ToString() + " X " + pictureBox.Width.ToString();
            }
            catch
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                pictureBox.Width += 50;
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonExtend_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                pictureBox.Height += 50;
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonShorten_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                pictureBox.Height -= 50;
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonNarrow_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                pictureBox.Width -= 50;
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonCoefficientEnlarge_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                double coefficient = Convert.ToDouble(textBoxCoefficient.Text);
                pictureBox.Width = (int)(pictureBox.Width * coefficient);
                pictureBox.Height = (int)(pictureBox.Height * coefficient);
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonEnlargement_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                double RepetitionsValue = Convert.ToDouble(textBoxNumberOfRepetitions.Text);
                pictureBox.Height = (int)(Math.Pow(2, RepetitionsValue) * pictureBox.Height);
                pictureBox.Width = (int)(Math.Pow(2, RepetitionsValue) * pictureBox.Width);
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonReduction_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                double RepetitionsValue = Convert.ToDouble(textBoxNumberOfRepetitions.Text);
                pictureBox.Height = (int)(pictureBox.Height / Math.Pow(2.0, RepetitionsValue));
                pictureBox.Width = (int)(pictureBox.Width / Math.Pow(2.0, RepetitionsValue));
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            } 
        }

        private void buttonRotateClockwise_Click(object sender, EventArgs e)
        {
            if (bmp != null) 
            { 
                pictureBox.Image = bmp;
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonRotateCounterClockwise_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                pictureBox.Image = bmp;
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonTranslationBottom_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                pictureBox.Top += 10;
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonTranslationRight_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                pictureBox.Left += 10;
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonTranslationUp_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                pictureBox.Top -= 10;
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void buttonTranslationLeft_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                pictureBox.Left -= 10;
            }
            else
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            labelResolution.Text = pictureBox.Height.ToString() + " X " + pictureBox.Width.ToString();
        }
    }
}
```
