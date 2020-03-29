namespace fractals
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
            this.coordinates = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createPoints = new System.Windows.Forms.Button();
            this.createFractal = new System.Windows.Forms.Button();
            this.dotsAmountTextBox = new System.Windows.Forms.TextBox();
            this.dotsAmountLabel = new System.Windows.Forms.Label();
            this.dotsSizeLabel = new System.Windows.Forms.Label();
            this.dotsSizeTextBox = new System.Windows.Forms.TextBox();
            this.multiplierLabel = new System.Windows.Forms.Label();
            this.multiplierTextBox = new System.Windows.Forms.TextBox();
            this.sleepLabel = new System.Windows.Forms.Label();
            this.sleepTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // coordinates
            // 
            this.coordinates.AutoSize = true;
            this.coordinates.BackColor = System.Drawing.Color.LightCoral;
            this.coordinates.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordinates.Location = new System.Drawing.Point(12, 27);
            this.coordinates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(0, 18);
            this.coordinates.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(7, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 625);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // createPoints
            // 
            this.createPoints.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPoints.Location = new System.Drawing.Point(7, 1);
            this.createPoints.Margin = new System.Windows.Forms.Padding(5);
            this.createPoints.Name = "createPoints";
            this.createPoints.Size = new System.Drawing.Size(147, 25);
            this.createPoints.TabIndex = 2;
            this.createPoints.Text = "Create NEW points";
            this.createPoints.UseVisualStyleBackColor = true;
            this.createPoints.Click += new System.EventHandler(this.createPoints_Click);
            // 
            // createFractal
            // 
            this.createFractal.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFractal.Location = new System.Drawing.Point(164, 1);
            this.createFractal.Margin = new System.Windows.Forms.Padding(5);
            this.createFractal.Name = "createFractal";
            this.createFractal.Size = new System.Drawing.Size(112, 25);
            this.createFractal.TabIndex = 3;
            this.createFractal.Text = "Create fractal";
            this.createFractal.UseVisualStyleBackColor = true;
            this.createFractal.Click += new System.EventHandler(this.createFractal_Click);
            // 
            // dotsAmountTextBox
            // 
            this.dotsAmountTextBox.Location = new System.Drawing.Point(377, 1);
            this.dotsAmountTextBox.Name = "dotsAmountTextBox";
            this.dotsAmountTextBox.Size = new System.Drawing.Size(79, 25);
            this.dotsAmountTextBox.TabIndex = 4;
            this.dotsAmountTextBox.Text = "30000";
            this.dotsAmountTextBox.Leave += new System.EventHandler(this.dotsAmountTextBox_Leave);
            // 
            // dotsAmountLabel
            // 
            this.dotsAmountLabel.AutoSize = true;
            this.dotsAmountLabel.Location = new System.Drawing.Point(284, 4);
            this.dotsAmountLabel.Name = "dotsAmountLabel";
            this.dotsAmountLabel.Size = new System.Drawing.Size(93, 18);
            this.dotsAmountLabel.TabIndex = 5;
            this.dotsAmountLabel.Text = "Dots amount";
            // 
            // dotsSizeLabel
            // 
            this.dotsSizeLabel.AutoSize = true;
            this.dotsSizeLabel.Location = new System.Drawing.Point(462, 4);
            this.dotsSizeLabel.Name = "dotsSizeLabel";
            this.dotsSizeLabel.Size = new System.Drawing.Size(70, 18);
            this.dotsSizeLabel.TabIndex = 6;
            this.dotsSizeLabel.Text = "Dots size";
            // 
            // dotsSizeTextBox
            // 
            this.dotsSizeTextBox.Location = new System.Drawing.Point(538, 1);
            this.dotsSizeTextBox.Name = "dotsSizeTextBox";
            this.dotsSizeTextBox.Size = new System.Drawing.Size(52, 25);
            this.dotsSizeTextBox.TabIndex = 7;
            this.dotsSizeTextBox.Text = "2";
            this.dotsSizeTextBox.Leave += new System.EventHandler(this.dotsSizeTextBox_Leave);
            // 
            // multiplierLabel
            // 
            this.multiplierLabel.AutoSize = true;
            this.multiplierLabel.Location = new System.Drawing.Point(596, 4);
            this.multiplierLabel.Name = "multiplierLabel";
            this.multiplierLabel.Size = new System.Drawing.Size(71, 18);
            this.multiplierLabel.TabIndex = 8;
            this.multiplierLabel.Text = "Multiplier";
            // 
            // multiplierTextBox
            // 
            this.multiplierTextBox.Location = new System.Drawing.Point(673, 1);
            this.multiplierTextBox.Name = "multiplierTextBox";
            this.multiplierTextBox.Size = new System.Drawing.Size(52, 25);
            this.multiplierTextBox.TabIndex = 9;
            this.multiplierTextBox.Text = "0.5";
            this.multiplierTextBox.Leave += new System.EventHandler(this.multiplierTextBox_Leave);
            // 
            // sleepLabel
            // 
            this.sleepLabel.AutoSize = true;
            this.sleepLabel.Location = new System.Drawing.Point(731, 4);
            this.sleepLabel.Name = "sleepLabel";
            this.sleepLabel.Size = new System.Drawing.Size(45, 18);
            this.sleepLabel.TabIndex = 10;
            this.sleepLabel.Text = "Sleep";
            // 
            // sleepTextBox
            // 
            this.sleepTextBox.Location = new System.Drawing.Point(782, 1);
            this.sleepTextBox.Name = "sleepTextBox";
            this.sleepTextBox.Size = new System.Drawing.Size(52, 25);
            this.sleepTextBox.TabIndex = 11;
            this.sleepTextBox.Text = "0";
            this.sleepTextBox.Leave += new System.EventHandler(this.sleepTextBox_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.sleepTextBox);
            this.Controls.Add(this.sleepLabel);
            this.Controls.Add(this.multiplierTextBox);
            this.Controls.Add(this.multiplierLabel);
            this.Controls.Add(this.dotsSizeTextBox);
            this.Controls.Add(this.dotsSizeLabel);
            this.Controls.Add(this.dotsAmountLabel);
            this.Controls.Add(this.dotsAmountTextBox);
            this.Controls.Add(this.createFractal);
            this.Controls.Add(this.createPoints);
            this.Controls.Add(this.coordinates);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label coordinates;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createPoints;
        private System.Windows.Forms.Button createFractal;
        private System.Windows.Forms.TextBox dotsAmountTextBox;
        private System.Windows.Forms.Label dotsAmountLabel;
        private System.Windows.Forms.Label dotsSizeLabel;
        private System.Windows.Forms.TextBox dotsSizeTextBox;
        private System.Windows.Forms.Label multiplierLabel;
        private System.Windows.Forms.TextBox multiplierTextBox;
        private System.Windows.Forms.Label sleepLabel;
        private System.Windows.Forms.TextBox sleepTextBox;
    }
}

