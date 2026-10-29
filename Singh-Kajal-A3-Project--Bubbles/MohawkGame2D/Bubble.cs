using System.Numerics;

namespace MohawkGame2D
{
    public class Bubble //This allows us to make the same drawing multiple times!
    {
        float x = 0.0f; // Declared OUTSIDE because it's NOT a frame by frame object! 
        float y = 0.0f; // Declared OUTSIDE because it's NOT a frame by frame object!
        float speed = 50.0f; // Declared OUTSIDE because NOT a frame by frame object!
        Color BubbleColor = Random.Color();

        public void Setup()
        {
            x = Random.Float (370, 560); //This means, it will "spawn" anywhere on the declared X and Y axes!

            speed = Random.Float (70, 150);

            Color BubbleColor = Random.Color();
        }

        public void Update()
        {
            //Bubble Art

            Draw.FillColor = BubbleColor;

            Draw.Circle(x, 260 - y,  30);

            //movement code
            y += speed * Time.DeltaTime; //This is how we get the bubbles to move!

           if (Input.IsMouseButtonPressed(MouseButton.Left) == true) //When the left mouse button is pressed, the bubbles will "spawn" in!
            {
                y = 0; 
            }

        }
    }
}
