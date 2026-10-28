using System.Numerics;

namespace MohawkGame2D
{
    public class Bubble
    {
        //Bubble Art

        float x = 0.0f;
        float y = 0.0f;
        float speed = 50.0f;
            
        public void Setup()
        {
            x = Random.Float (370, 560);
            y = Random.Float (370, 560);

            speed = Random.Float (50, 120);

            Color BubbleColor = Random.Color();
        }

        public void Update()
        {
            //Bubble

            float x = 0.0f;
            float y = 0.0f;

            Draw.Circle(400, 260, 30);


            //movement code
            y += speed * Time.DeltaTime;

           

        }
    }
}
