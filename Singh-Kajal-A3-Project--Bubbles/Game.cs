// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

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



        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("The Amazing Bubble Machine!");

            bubble1.Setup();

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            //Bubble Machine Drawing

            //Carriage
            Draw.LineSize = 0;
            Draw.SetFillColor(Color.DarkGray);
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
            Draw.FillColor = Color.Cyan;
            Draw.Rectangle(120, 350, 80, 25);

            bubble1.Update();

        }
    }

}
