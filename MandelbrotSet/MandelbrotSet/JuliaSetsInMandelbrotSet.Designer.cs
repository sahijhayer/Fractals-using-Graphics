namespace MandelbrotSetApplication
{
    partial class MandelbrotSetForm
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
            this.mandelbrotSetPictureBox = new System.Windows.Forms.PictureBox();
            this.displayMandelbrotSetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colouringMethodComboBox = new System.Windows.Forms.ComboBox();
            this.mouseCoordinatesLabel = new System.Windows.Forms.Label();
            this.complexPlaneCoordinatesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SnowflakeButton = new System.Windows.Forms.Button();
            this.depth = new System.Windows.Forms.TextBox();
            this.pythagButton = new System.Windows.Forms.Button();
            this.angle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.depthPythag = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotSetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mandelbrotSetPictureBox
            // 
            this.mandelbrotSetPictureBox.Location = new System.Drawing.Point(0, -1);
            this.mandelbrotSetPictureBox.Name = "mandelbrotSetPictureBox";
            this.mandelbrotSetPictureBox.Size = new System.Drawing.Size(800, 600);
            this.mandelbrotSetPictureBox.TabIndex = 0;
            this.mandelbrotSetPictureBox.TabStop = false;
            this.mandelbrotSetPictureBox.Click += new System.EventHandler(this.mandelbrotSetPictureBox_Click);
            this.mandelbrotSetPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mandelbrotSetPictureBox_Paint);
            this.mandelbrotSetPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mandelbrotSetPictureBox_MouseMove);
            this.mandelbrotSetPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mandelbrotSetPictureBox_MouseMove);
            // 
            // displayMandelbrotSetButton
            // 
            this.displayMandelbrotSetButton.Location = new System.Drawing.Point(12, 618);
            this.displayMandelbrotSetButton.Name = "displayMandelbrotSetButton";
            this.displayMandelbrotSetButton.Size = new System.Drawing.Size(187, 33);
            this.displayMandelbrotSetButton.TabIndex = 1;
            this.displayMandelbrotSetButton.Text = "Display Mandelbrot Set";
            this.displayMandelbrotSetButton.UseVisualStyleBackColor = true;
            this.displayMandelbrotSetButton.Click += new System.EventHandler(this.displayMandelbrotSetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Colouring Method";
            // 
            // colouringMethodComboBox
            // 
            this.colouringMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colouringMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colouringMethodComboBox.FormattingEnabled = true;
            this.colouringMethodComboBox.Location = new System.Drawing.Point(326, 618);
            this.colouringMethodComboBox.Name = "colouringMethodComboBox";
            this.colouringMethodComboBox.Size = new System.Drawing.Size(172, 24);
            this.colouringMethodComboBox.TabIndex = 3;
            this.colouringMethodComboBox.SelectedValueChanged += new System.EventHandler(this.colouringMethodComboBox_SelectedValueChanged);
            // 
            // mouseCoordinatesLabel
            // 
            this.mouseCoordinatesLabel.AutoSize = true;
            this.mouseCoordinatesLabel.Location = new System.Drawing.Point(575, 625);
            this.mouseCoordinatesLabel.Name = "mouseCoordinatesLabel";
            this.mouseCoordinatesLabel.Size = new System.Drawing.Size(0, 13);
            this.mouseCoordinatesLabel.TabIndex = 4;
            // 
            // complexPlaneCoordinatesLabel
            // 
            this.complexPlaneCoordinatesLabel.AutoSize = true;
            this.complexPlaneCoordinatesLabel.Location = new System.Drawing.Point(711, 624);
            this.complexPlaneCoordinatesLabel.Name = "complexPlaneCoordinatesLabel";
            this.complexPlaneCoordinatesLabel.Size = new System.Drawing.Size(0, 13);
            this.complexPlaneCoordinatesLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 602);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mouse Co-ordinates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(659, 602);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Complex Plane Co-ordinates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 602);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(481, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clicking on the Mandelbrot Set will generate the Julia set for that specific poin" +
    "t on the complex plane!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 654);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(621, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Clicking the buttons below will generate either a Koch Snowflake with your depth " +
    "input, or a Pythagoras Tree with your angle input.";
            // 
            // SnowflakeButton
            // 
            this.SnowflakeButton.Location = new System.Drawing.Point(20, 670);
            this.SnowflakeButton.Name = "SnowflakeButton";
            this.SnowflakeButton.Size = new System.Drawing.Size(166, 32);
            this.SnowflakeButton.TabIndex = 10;
            this.SnowflakeButton.Text = "Generate Koch Snowflake";
            this.SnowflakeButton.UseVisualStyleBackColor = true;
            this.SnowflakeButton.Click += new System.EventHandler(this.SnowflakeButton_Click);
            // 
            // depth
            // 
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.depth.Location = new System.Drawing.Point(248, 674);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(30, 23);
            this.depth.TabIndex = 11;
            this.depth.Text = "0";
            // 
            // pythagButton
            // 
            this.pythagButton.Location = new System.Drawing.Point(296, 670);
            this.pythagButton.Name = "pythagButton";
            this.pythagButton.Size = new System.Drawing.Size(166, 32);
            this.pythagButton.TabIndex = 12;
            this.pythagButton.Text = "Generate Pythagoras Tree";
            this.pythagButton.UseVisualStyleBackColor = true;
            this.pythagButton.Click += new System.EventHandler(this.pythagButton_Click);
            // 
            // angle
            // 
            this.angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.angle.Location = new System.Drawing.Point(632, 674);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(30, 23);
            this.angle.TabIndex = 13;
            this.angle.Text = "45";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 676);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Depth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(468, 678);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Depth:";
            // 
            // depthPythag
            // 
            this.depthPythag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.depthPythag.Location = new System.Drawing.Point(524, 674);
            this.depthPythag.Name = "depthPythag";
            this.depthPythag.Size = new System.Drawing.Size(30, 23);
            this.depthPythag.TabIndex = 17;
            this.depthPythag.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(572, 678);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Angle:";
            // 
            // MandelbrotSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 702);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.depthPythag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.pythagButton);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.SnowflakeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.complexPlaneCoordinatesLabel);
            this.Controls.Add(this.mouseCoordinatesLabel);
            this.Controls.Add(this.colouringMethodComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayMandelbrotSetButton);
            this.Controls.Add(this.mandelbrotSetPictureBox);
            this.Name = "MandelbrotSetForm";
            this.Text = "JuliaSetsInMandelbrotSet";
            this.Load += new System.EventHandler(this.MandelbrotSetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotSetPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mandelbrotSetPictureBox;
        private System.Windows.Forms.Button displayMandelbrotSetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox colouringMethodComboBox;
        private System.Windows.Forms.Label mouseCoordinatesLabel;
        private System.Windows.Forms.Label complexPlaneCoordinatesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SnowflakeButton;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.Button pythagButton;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox depthPythag;
        private System.Windows.Forms.Label label9;
    }
}

