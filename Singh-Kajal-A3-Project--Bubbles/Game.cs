// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {

        Color BubbleColor = Random.Color();

        Bubble bubble1 = new Bubble();
        Bubble bubble2 = new Bubble();
        Bubble bubble3 = new Bubble();
        Bubble bubble4 = new Bubble();


        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("The Amazing Bubble Machine!");

            bubble1.Setup();
            bubble2.Setup();
            bubble3.Setup();
            bubble4.Setup();

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Cyan);


            //Bubble Machine Drawing

            //Carriage
            Draw.LineSize = 0;
            Draw.SetFillColor(Color.Magenta);
            Draw.Quad(180, 350, 250, 500, 500, 500, 570, 350);

            //Wheels
            Draw.FillColor = Color.Red;
            Draw.Circle(250, 500, 70);
            Draw.Circle(500, 500, 70);

            //Wheel Handle
            Draw.FillColor = Color.Green;
            Draw.LineSize = 0;
            Draw.Circle(260, 370, 40);
            Draw.LineSize = 10;
            Draw.Line(205, 330, 260, 370);
            Draw.LineSize = 0;
            Draw.Circle(205, 330, 20);

            //Chute
            Draw.FillColor = Color.Blue;
            Draw.Quad(370, 300, 420, 350, 520, 350, 560, 300);

            //Carriage Handle
            Draw.FillColor = Color.Yellow;
            Draw.Rectangle(120, 350, 80, 25);

            //Clouds

            //For Loops allows a drawing to 'loop/repeat' for a set amount 

            for (int i = -5; i < 5; i++) // Help from professor, need to relearn For loops
            {
                float x = i * 450 + 10 * Time.SecondsElapsed; //Difference between Seconds and TimeDelta is the smoothness of the movement across the axes!
                DrawClouds(x); // The X means to place it somewhere on the X axis, so it has a consistant location!
            }

          //  DrawClouds(0 + 2 * Time.SecondsElapsed); //This is a Function!

          //  DrawClouds(450 + 2 * Time.SecondsElapsed); // This is a Funtion positioned somewhere else! 


            bubble1.Update();

            bubble2.Update();

            bubble3.Update();

            bubble4.Update();


        }

        public void DrawClouds(float x) //This is a declared Function!
        {
            
            Draw.FillColor = Color.White;
            
            //First Cloud
            Draw.Ellipse(100 + x, 40, 250, 40);
            Draw.Ellipse(150 + x, 75, 160, 40);

            //Second Cloud
            Draw.Ellipse(290 + x, 150, 180, 60);

            //Third Cloud
            Draw.Ellipse(40 + x, 170, 90, 40);

        }
            
          


        


    }


}
