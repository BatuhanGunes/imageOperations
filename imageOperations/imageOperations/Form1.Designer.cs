namespace imageOperations
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.labelResolution = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTranslationBottom = new System.Windows.Forms.Button();
            this.buttonTranslationRight = new System.Windows.Forms.Button();
            this.buttonTranslationLeft = new System.Windows.Forms.Button();
            this.buttonTranslationUp = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCoefficientEnlarge = new System.Windows.Forms.Button();
            this.textBoxCoefficient = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonNarrow = new System.Windows.Forms.Button();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.buttonShorten = new System.Windows.Forms.Button();
            this.buttonExtend = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNumberOfRepetitions = new System.Windows.Forms.TextBox();
            this.buttonReduction = new System.Windows.Forms.Button();
            this.buttonEnlargement = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonRotateCounterClockwise = new System.Windows.Forms.Button();
            this.buttonRotateClockwise = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPanel.Controls.Add(this.labelResolution);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.pictureBox);
            this.leftPanel.Location = new System.Drawing.Point(12, 12);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1104, 506);
            this.leftPanel.TabIndex = 0;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(73, 10);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(32, 13);
            this.labelResolution.TabIndex = 2;
            this.labelResolution.Text = "0 X 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Resolution :";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.SizeChanged += new System.EventHandler(this.pictureBox_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxFileName);
            this.panel1.Controls.Add(this.buttonUploadImage);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1122, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 232);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(0, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "File Location :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Enabled = false;
            this.textBoxFileName.Location = new System.Drawing.Point(3, 171);
            this.textBoxFileName.Multiline = true;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(222, 41);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Location = new System.Drawing.Point(47, 78);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(138, 23);
            this.buttonUploadImage.TabIndex = 1;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Image Upload Operations";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonTranslationBottom);
            this.panel2.Controls.Add(this.buttonTranslationRight);
            this.panel2.Controls.Add(this.buttonTranslationLeft);
            this.panel2.Controls.Add(this.buttonTranslationUp);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(1122, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 268);
            this.panel2.TabIndex = 2;
            // 
            // buttonTranslationBottom
            // 
            this.buttonTranslationBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTranslationBottom.Location = new System.Drawing.Point(78, 174);
            this.buttonTranslationBottom.Name = "buttonTranslationBottom";
            this.buttonTranslationBottom.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslationBottom.TabIndex = 5;
            this.buttonTranslationBottom.Text = "v";
            this.buttonTranslationBottom.UseVisualStyleBackColor = true;
            this.buttonTranslationBottom.Click += new System.EventHandler(this.buttonTranslationBottom_Click);
            // 
            // buttonTranslationRight
            // 
            this.buttonTranslationRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTranslationRight.Location = new System.Drawing.Point(140, 124);
            this.buttonTranslationRight.Name = "buttonTranslationRight";
            this.buttonTranslationRight.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslationRight.TabIndex = 4;
            this.buttonTranslationRight.Text = ">";
            this.buttonTranslationRight.UseVisualStyleBackColor = true;
            this.buttonTranslationRight.Click += new System.EventHandler(this.buttonTranslationRight_Click);
            // 
            // buttonTranslationLeft
            // 
            this.buttonTranslationLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTranslationLeft.Location = new System.Drawing.Point(16, 124);
            this.buttonTranslationLeft.Name = "buttonTranslationLeft";
            this.buttonTranslationLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslationLeft.TabIndex = 3;
            this.buttonTranslationLeft.Text = "<";
            this.buttonTranslationLeft.UseVisualStyleBackColor = true;
            this.buttonTranslationLeft.Click += new System.EventHandler(this.buttonTranslationLeft_Click);
            // 
            // buttonTranslationUp
            // 
            this.buttonTranslationUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTranslationUp.Location = new System.Drawing.Point(78, 76);
            this.buttonTranslationUp.Name = "buttonTranslationUp";
            this.buttonTranslationUp.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslationUp.TabIndex = 2;
            this.buttonTranslationUp.Text = "^";
            this.buttonTranslationUp.UseVisualStyleBackColor = true;
            this.buttonTranslationUp.Click += new System.EventHandler(this.buttonTranslationUp_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Translation Operations";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Location = new System.Drawing.Point(1122, 524);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 232);
            this.panel3.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(3, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(222, 20);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "Information";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(16, 108);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(199, 100);
            this.panel8.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number   :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Batuhan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name      :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(96, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Güneş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "201513171055";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(78, 54);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(81, 34);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.buttonCoefficientEnlarge);
            this.panel4.Controls.Add(this.textBoxCoefficient);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Location = new System.Drawing.Point(12, 524);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 232);
            this.panel4.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Coefficient \r\n    Value :";
            // 
            // buttonCoefficientEnlarge
            // 
            this.buttonCoefficientEnlarge.Location = new System.Drawing.Point(61, 144);
            this.buttonCoefficientEnlarge.Name = "buttonCoefficientEnlarge";
            this.buttonCoefficientEnlarge.Size = new System.Drawing.Size(75, 23);
            this.buttonCoefficientEnlarge.TabIndex = 4;
            this.buttonCoefficientEnlarge.Text = "Enlarge";
            this.buttonCoefficientEnlarge.UseVisualStyleBackColor = true;
            this.buttonCoefficientEnlarge.Click += new System.EventHandler(this.buttonCoefficientEnlarge_Click);
            // 
            // textBoxCoefficient
            // 
            this.textBoxCoefficient.Location = new System.Drawing.Point(104, 84);
            this.textBoxCoefficient.Name = "textBoxCoefficient";
            this.textBoxCoefficient.Size = new System.Drawing.Size(70, 20);
            this.textBoxCoefficient.TabIndex = 3;
            this.textBoxCoefficient.Text = "1";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(3, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(222, 20);
            this.textBox6.TabIndex = 2;
            this.textBox6.Text = "Coefficient Operations";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.buttonNarrow);
            this.panel5.Controls.Add(this.buttonExpand);
            this.panel5.Controls.Add(this.buttonShorten);
            this.panel5.Controls.Add(this.buttonExtend);
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Location = new System.Drawing.Point(250, 524);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 232);
            this.panel5.TabIndex = 5;
            // 
            // buttonNarrow
            // 
            this.buttonNarrow.Location = new System.Drawing.Point(172, 144);
            this.buttonNarrow.Name = "buttonNarrow";
            this.buttonNarrow.Size = new System.Drawing.Size(84, 23);
            this.buttonNarrow.TabIndex = 6;
            this.buttonNarrow.Text = "Narrow";
            this.buttonNarrow.UseVisualStyleBackColor = true;
            this.buttonNarrow.Click += new System.EventHandler(this.buttonNarrow_Click);
            // 
            // buttonExpand
            // 
            this.buttonExpand.Location = new System.Drawing.Point(172, 82);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(84, 23);
            this.buttonExpand.TabIndex = 5;
            this.buttonExpand.Text = "Expand";
            this.buttonExpand.UseVisualStyleBackColor = true;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // buttonShorten
            // 
            this.buttonShorten.Location = new System.Drawing.Point(42, 144);
            this.buttonShorten.Name = "buttonShorten";
            this.buttonShorten.Size = new System.Drawing.Size(83, 23);
            this.buttonShorten.TabIndex = 4;
            this.buttonShorten.Text = "Shorten";
            this.buttonShorten.UseVisualStyleBackColor = true;
            this.buttonShorten.Click += new System.EventHandler(this.buttonShorten_Click);
            // 
            // buttonExtend
            // 
            this.buttonExtend.Location = new System.Drawing.Point(42, 82);
            this.buttonExtend.Name = "buttonExtend";
            this.buttonExtend.Size = new System.Drawing.Size(83, 23);
            this.buttonExtend.TabIndex = 3;
            this.buttonExtend.Text = "Extend";
            this.buttonExtend.UseVisualStyleBackColor = true;
            this.buttonExtend.Click += new System.EventHandler(this.buttonExtend_Click);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(290, 20);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "Enlargement / Reduction Operations";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.textBoxNumberOfRepetitions);
            this.panel6.Controls.Add(this.buttonReduction);
            this.panel6.Controls.Add(this.buttonEnlargement);
            this.panel6.Controls.Add(this.textBox4);
            this.panel6.Location = new System.Drawing.Point(556, 524);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 232);
            this.panel6.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "The Number \r\nOf Repetitions :";
            // 
            // textBoxNumberOfRepetitions
            // 
            this.textBoxNumberOfRepetitions.Location = new System.Drawing.Point(144, 85);
            this.textBoxNumberOfRepetitions.Name = "textBoxNumberOfRepetitions";
            this.textBoxNumberOfRepetitions.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfRepetitions.TabIndex = 5;
            this.textBoxNumberOfRepetitions.Text = "1";
            // 
            // buttonReduction
            // 
            this.buttonReduction.Location = new System.Drawing.Point(157, 144);
            this.buttonReduction.Name = "buttonReduction";
            this.buttonReduction.Size = new System.Drawing.Size(87, 23);
            this.buttonReduction.TabIndex = 4;
            this.buttonReduction.Text = "Reduction";
            this.buttonReduction.UseVisualStyleBackColor = true;
            this.buttonReduction.Click += new System.EventHandler(this.buttonReduction_Click);
            // 
            // buttonEnlargement
            // 
            this.buttonEnlargement.Location = new System.Drawing.Point(50, 144);
            this.buttonEnlargement.Name = "buttonEnlargement";
            this.buttonEnlargement.Size = new System.Drawing.Size(89, 23);
            this.buttonEnlargement.TabIndex = 3;
            this.buttonEnlargement.Text = "Enlargement";
            this.buttonEnlargement.UseVisualStyleBackColor = true;
            this.buttonEnlargement.Click += new System.EventHandler(this.buttonEnlargement_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(290, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Enlargement / Reduction with coefficient";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.buttonRotateCounterClockwise);
            this.panel7.Controls.Add(this.buttonRotateClockwise);
            this.panel7.Controls.Add(this.textBox3);
            this.panel7.Location = new System.Drawing.Point(862, 524);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(254, 232);
            this.panel7.TabIndex = 5;
            // 
            // buttonRotateCounterClockwise
            // 
            this.buttonRotateCounterClockwise.Location = new System.Drawing.Point(43, 144);
            this.buttonRotateCounterClockwise.Name = "buttonRotateCounterClockwise";
            this.buttonRotateCounterClockwise.Size = new System.Drawing.Size(167, 23);
            this.buttonRotateCounterClockwise.TabIndex = 4;
            this.buttonRotateCounterClockwise.Text = "Rotate Counter Clockwise";
            this.buttonRotateCounterClockwise.UseVisualStyleBackColor = true;
            this.buttonRotateCounterClockwise.Click += new System.EventHandler(this.buttonRotateCounterClockwise_Click);
            // 
            // buttonRotateClockwise
            // 
            this.buttonRotateClockwise.Location = new System.Drawing.Point(43, 82);
            this.buttonRotateClockwise.Name = "buttonRotateClockwise";
            this.buttonRotateClockwise.Size = new System.Drawing.Size(167, 23);
            this.buttonRotateClockwise.TabIndex = 3;
            this.buttonRotateClockwise.Text = "Rotate Clockwise";
            this.buttonRotateClockwise.UseVisualStyleBackColor = true;
            this.buttonRotateClockwise.Click += new System.EventHandler(this.buttonRotateClockwise_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(244, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Rotation Operations";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.Button buttonTranslationBottom;
        private System.Windows.Forms.Button buttonTranslationRight;
        private System.Windows.Forms.Button buttonTranslationLeft;
        private System.Windows.Forms.Button buttonTranslationUp;
        private System.Windows.Forms.Button buttonCoefficientEnlarge;
        private System.Windows.Forms.TextBox textBoxCoefficient;
        private System.Windows.Forms.Button buttonNarrow;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Button buttonShorten;
        private System.Windows.Forms.Button buttonExtend;
        private System.Windows.Forms.TextBox textBoxNumberOfRepetitions;
        private System.Windows.Forms.Button buttonReduction;
        private System.Windows.Forms.Button buttonEnlargement;
        private System.Windows.Forms.Button buttonRotateCounterClockwise;
        private System.Windows.Forms.Button buttonRotateClockwise;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelResolution;
    }
}

