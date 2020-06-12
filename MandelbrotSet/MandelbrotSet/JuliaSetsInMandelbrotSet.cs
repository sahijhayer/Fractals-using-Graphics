using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//To access the "Complex" structure, it is necessary to include the following "using" directive.
//In addition, it is necessary to add a reference to "System.Numerics" through "Project/Add Reference..." (.NET tab)
using System.Numerics;


namespace MandelbrotSetApplication
{

    /**
     * Definition of the class 'MandelbrotSetForm.' This class inherits all the members of the 'Form' class.
     */

    public partial class MandelbrotSetForm : Form
    {
        /**
         * DATA MEMBERS of the class 'MandelbrotSetForm.'
         * 
         * These constants, variables and objects are GLOBAL to the class.
         * 
         * Data members can be declared as 'public,' 'private' or 'protected.' The keywords 'public,' 'private' 
         * and 'protected'are known as "MEMBER ACCESS MODIFIERS" because they define the level of access to the data members.
         * 
         * private   -> The member can only be accessed within the class or structure in which it is declared.
         *              This is the least permissive access level.
         * public    -> The member can be accessed by any class. There are no restrictions on accessing public members.
         *              This is the most permissive access level.
         * protected -> The member is accessible from within the class in which it is declared and and from within any
         *              class derived from the class that declared this member. This level of access is intermediate
         *              between 'public' and 'private.'
         */


        private const int NO_COLOURING = 0, ITERATIONS = 1, MODULUS = 2, TRIG = 3, BINARY_DECOMPOSITION = 4;

        private static int colouringMethod = NO_COLOURING;
        private static double maxModulus = 2.0d;

        private Bitmap mandelbrotSetBitmap = new Bitmap(800, 600); //The size of the bitmap is set initially to 800x600.



        /**
         * Constructor Method for the class 'MandelbrotSetForm.' This method is called as soon as the form object is created.
         * This constructor should include any statements that need to be executed before the user interacts with the program.
         */
        public MandelbrotSetForm()
        {
            InitializeComponent();

            //Add items to the object 'colouringMethodComboBox.'
            colouringMethodComboBox.Text = "None";
            colouringMethodComboBox.Items.Add("None");
            colouringMethodComboBox.Items.Add("Iterations Method");
            colouringMethodComboBox.Items.Add("Modulus Method");
            colouringMethodComboBox.Items.Add("Trigonometric Method");
            colouringMethodComboBox.Items.Add("Binary Decomposition");
        }


        /*
         * EVENT HANDLER METHODS
         */

        private void displayMandelbrotSetButton_Click(object sender, EventArgs e)
        {

            Graphics mandelbrotSetImage = Graphics.FromImage(mandelbrotSetBitmap);

            //Instantiations of the 'Complex' class. Create two complex objects, 'c' and 'z.'
            //For both 'Complex' objects, the real and imaginary parts are initially set to 0.
            Complex z = new Complex(0, 0);
            Complex c = new Complex(0, 0);

            //For efficiency reasons, copy the 'Width' and 'Height' properties to variables.
            //This is called "caching" the values of properties.
            int width = mandelbrotSetBitmap.Width;
            int height = mandelbrotSetBitmap.Height;

            mandelbrotSetImage.Clear(mandelbrotSetPictureBox.BackColor);
            mandelbrotSetPictureBox.Refresh();

            //Traverse the bitmap one pixel at a time, column by column. Screen co-ordinates are (x,y).
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //The real and imaginary parts of the 'c' are determined by the linear transformations that map
                    //the region of the Cartesian plane in which 0<=x<800, 0<=y<600 to the region of the Complex plane
                    //in which -2.5<=Re(z)<1.5 and -1.5<=Im(z)<1.5
                    c = new Complex(4.0d / width * x - 2.5d, -3.0d / height * y + 1.5d);
                    z = 0;
                    int iterations = 0;

                    //For the value of c corresponding to screen co-ordinates (x,y), generate terms of the Mandelbrot sequence. 
                    //The loop terminates as soon as |z| exceeds 'maxModulus' or at the 100th term.
                    do
                    {
                        z = Complex.Add(Complex.Pow(z, 2), Complex.Multiply(c, 2));//z=z^2+c
                        iterations++;
                    } while (Complex.Abs(z) < 2 && iterations <= 100);

                    mandelbrotSetBitmap.SetPixel(x, y, pixelColour(colouringMethod, iterations - 1, z));

                }//end inner for
            }//end outer for

            //Display the Mandelbrot set by firing the 'Paint' event on 'mandelbrotSetPictureBox.'
            mandelbrotSetPictureBox.Refresh();
        }

        private void mandelbrotSetPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mandelbrotSetBitmap, 0, 0);
        }

        private void mandelbrotSetPictureBox_Click(object sender, EventArgs e)
        {
            Graphics juliaSet = Graphics.FromImage(mandelbrotSetBitmap);

            //Instantiations of the 'Complex' class. Create two complex objects, 'c' and 'z.'
            //For both 'Complex' objects, the real and imaginary parts are initially set to 0.
            Complex z = new Complex(0, 0);
            Complex c = new Complex(0, 0);

            //For efficiency reasons, copy the 'Width' and 'Height' properties to variables.
            //This is called "caching" the values of properties.
            int width = mandelbrotSetBitmap.Width;
            int height = mandelbrotSetBitmap.Height;

            juliaSet.Clear(mandelbrotSetPictureBox.BackColor);
            mandelbrotSetPictureBox.Refresh();

            //Traverse the bitmap one pixel at a time, column by column. Screen co-ordinates are (x,y).

             c = new Complex(MousePosition.X * 4 / 800 - 2.5, MousePosition.Y * -3 / 600 + 1.5); //Using the mouse click position's coordinates to decide which julia set to generate.
            //The complex value c is set outside of the loop because otherwise, everytime the user moves the mouse, its value changes, and this isn't wanted for a julia set because the c value must stay constant.

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                { 

                    z = new Complex(4.0d / width * x - 2.0d, -3.0d / height * y + 1.5d);

                    int iterations = 0;

                    //For the value of c corresponding to screen co-ordinates (x,y), terms of the julia set are generated, 
                    //when they are greater than 2, it is determined that the point is not a part of the julia set, and depending on the colouring method, it is coloured (not black)
                    do
                    {
                        z = Complex.Add(Complex.Pow(z, 2), c);

                        iterations++;
                    } while (Complex.Abs(z) < 2 && iterations <= 100);

                    mandelbrotSetBitmap.SetPixel(x, y, pixelColour(colouringMethod, iterations - 1, z));

                }//end inner for
            }//end outer for
            mandelbrotSetPictureBox.Refresh();
          

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void SnowflakeButton_Click(object sender, EventArgs e)
        {
            //Graphics set with white background
            Graphics Snowflake = mandelbrotSetPictureBox.CreateGraphics();
            Snowflake.Clear(Color.White);
            int iterations = System.Convert.ToInt32(depth.Text);

            //Triangle's three points, third point is calculated so the triangle is equilateral.
            PointF p1, p2, p3;
            p1 = new PointF(200, 400);
            p2 = new PointF(600, 400);
            p3 = new PointF(400, 400 - System.Convert.ToSingle(Math.Sqrt(120000)));
            PointF[] pointArray1 = new PointF[2] { p1, p2 };
            PointF[] pointArray2 = new PointF[2] { p2, p3 };
            PointF[] pointArray3 = new PointF[2] { p3, p1 };

            //Each of the triangle point pairs are run through the KochSnowflake method which draws the snowflake.
            KochSnowflake(pointArray1, iterations);
            KochSnowflake(pointArray2, iterations);
            KochSnowflake(pointArray3, iterations);

        }

        private void KochSnowflake(PointF[] PArray, int iterations)
        {
            Graphics Snowflake = mandelbrotSetPictureBox.CreateGraphics();

            //First checks if the iterations have all been gone through because this is when the smallest vector is generated for the desired depth. Then, it draws the line.
            if (iterations == 0)
            {
                Pen myPen = new Pen(Color.Red);
                Snowflake.DrawLine(myPen, PArray[0], PArray[1]);
            }
            else
            {

                //One large vector is created using the two points inputted, and then the 3 vectors of the Snowflake of this vector are calculated by dividing the vector into 3, and rotating two of them 60 degrees.
                Vector2 v = new Vector2(PArray[1].X - PArray[0].X, PArray[1].Y - PArray[0].Y);
                Vector2 v1 = new Vector2(v.X / 3, v.Y / 3);
                Vector2 v2 = new Vector2(v1.rotateDeg(60));
                Vector2 v3 = new Vector2(v1.rotateDeg(-60));

                //The new points are calculated using the vectors.
                PointF p1 = PArray[0];
                PointF p5 = PArray[1];
                PointF p2 = new PointF(p1.X + v1.X, p1.Y + v1.Y);
                PointF p3 = new PointF(p2.X + v2.X, p2.Y + v2.Y);
                PointF p4 = new PointF(p3.X + v3.X, p3.Y + v3.Y);

                PointF[] PList = new PointF[5] { p1, p2, p3, p4, p5 };
                //For loop runs through all of the vectors created between each point (1-5, 4 vectors per vector for each new iteration of depth) 
                //until iterations reaches the depth entered by the user, and then it draws them.

                for (int i = 0; i < PList.Length - 1; i++)
                {
                    PointF[] PArrayInput = new PointF[2] { PList[i], PList[i + 1] };
                    KochSnowflake(PArrayInput, iterations - 1);
                }
            }
        }

        private void colouringMethodComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            colouringMethod = colouringMethodComboBox.SelectedIndex;
            if (colouringMethodComboBox.SelectedIndex == MODULUS)
                maxModulus = 3.0d;
            else
                maxModulus = 2.0d;
        }


        /*
         * OTHER METHODS FOR INTERNAL USE ONLY
         */

        private static Color pixelColour(int colourMethod, int repetitions, Complex c)
        {
            double modulus = Complex.Abs(c);

            if (colourMethod == ITERATIONS)
            {
                if (modulus >= 2.0d)
                {
                    int red = (int)(2.55f * repetitions);
                    int green = red;
                    int blue = (int)(255 - 2.55f * repetitions);
                    return Color.FromArgb(red, green, blue);
                }
                else
                    return Color.Black;
            }
            else if (colourMethod == MODULUS)
            {
                if (modulus >= 2.0d)
                {
                    int red = (int)Math.Round(-23.3d * modulus + 277.0d);
                    int green = (int)Math.Round(10.0d * Math.Pow(modulus, 2) - 136.0d * modulus + 465.0d);
                    int blue = (int)Math.Round(25.3d * modulus - 50.0d);
                    return Color.FromArgb(red, green, blue);
                }
                else
                    return Color.Black;

            }
            else if (colourMethod == TRIG)
            {
                int red = 255 - (int)(255 * Math.Abs(Math.Sin(c.Real)));
                int blue = 255 - (int)(255 * Math.Abs(Math.Cos(c.Imaginary)));
                int green = (red < blue) ? red : blue; //Set green to smaller of red and blue
                return Color.FromArgb(red, green, blue);
            }
            else if (colourMethod == BINARY_DECOMPOSITION)
            {
                if (repetitions == 2000)
                {
                    return Color.Black;
                }
                else
                {
                    if (c.Imaginary > 0)
                        return Color.Black;
                    else
                        return Color.White;
                }
            }
            else if (modulus < 2.0d) //
                return Color.Black;
            else
                return Color.White;
        }

        private void pythagButton_Click(object sender, EventArgs e)
        {
            //Clear the background for the pythagoras tree
            mandelbrotSetPictureBox.CreateGraphics().Clear(Color.White);
            PointF botLeft = new PointF(375, 400);
            PointF botRight = new PointF(425, 400);
            Vector2 leftSide = new Vector2(0, -50);

            //User inputted integer of the left angle
            int a = System.Convert.ToInt32(angle.Text);
            int numIterations = System.Convert.ToInt32(depthPythag.Text);

            //Call both branches, left and right
            LeftTree(botLeft, leftSide, a, numIterations);
            RightTree(botRight, leftSide, a, numIterations);
      
        }

        private void mandelbrotSetPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            mouseCoordinatesLabel.Text = "(" + e.X + ", " + e.Y + ")";
            complexPlaneCoordinatesLabel.Text = "(" + Math.Round(4.0d / mandelbrotSetBitmap.Width * e.X - 2.5d, 2)
                                                    + ", " + Math.Round(-3.0d / mandelbrotSetBitmap.Height * e.Y + 1.5d, 2) + ")";
        }

        private void MandelbrotSetForm_Load(object sender, EventArgs e)
        {

        }

        private void LeftTree(PointF botLeft, Vector2 leftSide, int a, int iterations)
        {
            Graphics g = mandelbrotSetPictureBox.CreateGraphics();
            Pen myPen = new Pen(Color.Black);

            //Colour dependent on number of iterations
            SolidBrush solidBrush = new SolidBrush(
Color.FromArgb(150, 15 * iterations, 255, 0));

            if (iterations == 0)
            {

            }

            else
            {
                //Draw the square
                PointF botRight, topRight, topLeft;
                Vector2 bottomSide = leftSide.rotateDeg(90);
                botRight = new PointF(bottomSide.X + botLeft.X, bottomSide.Y + botLeft.Y);
                topLeft = new PointF(botLeft.X + leftSide.X, botLeft.Y + leftSide.Y);
                topRight = new PointF(topLeft.X + bottomSide.X, topLeft.Y + bottomSide.Y);
                PointF[] Square = new PointF[4] { botLeft, botRight, topRight, topLeft };

                g.DrawPolygon(myPen, Square);
                g.FillPolygon(solidBrush, Square);

                //Find vector for the next method call, and draw the vector.
                Vector2 triangleLeft = leftSide.rotateDeg(90 - a);
                triangleLeft = triangleLeft.timesScalar(System.Convert.ToSingle(Math.Cos(a * Math.PI / 180)));
                PointF triangleTop = new PointF(topLeft.X + triangleLeft.X, topLeft.Y + triangleLeft.Y);

                //New vector
                Vector2 newLeftSide = new Vector2(triangleLeft.rotateDeg(-90));

                //Recursion of left and right branch for each branch generated
                LeftTree(topLeft, newLeftSide, a, iterations - 1);
                RightTree(triangleTop, newLeftSide, a, iterations - 1);

            }


        }

        private void RightTree(PointF botRight, Vector2 rightSide, int a, int iterations)
        {
            Graphics g = mandelbrotSetPictureBox.CreateGraphics();
            Pen myPen = new Pen(Color.Black);

            //Colour dependent on number of iterations
            SolidBrush solidBrush = new SolidBrush(
   Color.FromArgb(150, 15 * iterations, 255, 0));

            if (iterations == 0)
            {

            }

            else
            {
                //Draw the square
                PointF botLeft, topRight, topLeft;
                Vector2 bottomSide = rightSide.rotateDeg(90);
                botLeft = new PointF(botRight.X - bottomSide.X, botRight.Y - bottomSide.Y);
                topLeft = new PointF(botLeft.X + rightSide.X, botLeft.Y + rightSide.Y);
                topRight = new PointF(topLeft.X + bottomSide.X, topLeft.Y + bottomSide.Y);
                PointF[] Square = new PointF[4] { botLeft, botRight, topRight, topLeft };

                g.DrawPolygon(myPen, Square);
                g.FillPolygon(solidBrush, Square);

                //Find vector for the next method call.
                Vector2 triangleRight = rightSide.rotateDeg(-a);
                triangleRight = triangleRight.timesScalar(System.Convert.ToSingle(Math.Cos((90 - a) * Math.PI / 180)));
                PointF triangleTop = new PointF(topRight.X + triangleRight.X, topRight.Y + triangleRight.Y);


                //New vector
                Vector2 newLeftSide = new Vector2(triangleRight.rotateDeg(90));

                //Recursion of left and right branch for each branch generated
                RightTree(topRight, newLeftSide, a, iterations - 1);
                LeftTree(triangleTop, newLeftSide, a, iterations - 1);



            }


        }


    }



}
