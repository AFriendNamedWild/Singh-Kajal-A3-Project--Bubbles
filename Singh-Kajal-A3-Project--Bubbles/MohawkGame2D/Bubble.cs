using System.Numerics;

namespace MohawkGame2D
{
    public class Bubble
    {
        //Bubble Art

        float x = 0.0f;
        float y = 0.0f;
        float speed = 50.0f;
        Color BubbleColor = Random.Color();

        public void Setup()
        {
            x = Random.Float (370, 560);

            speed = Random.Float (70, 150);

            Color BubbleColor = Random.Color();
        }

        public void Update()
        {
            //Bubble

            Draw.FillColor = BubbleColor;

            Draw.Circle(x, 260 - y,  30);

            //movement code
            y += speed * Time.DeltaTime;

           if (Input.IsMouseButtonPressed(MouseButton.Left) == true)
            {
                y = 0;
            }

        }
    }
}
