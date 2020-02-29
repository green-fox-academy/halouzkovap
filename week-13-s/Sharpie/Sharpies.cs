namespace Sharpies
{
    public class Sharpies
    {

        public string Color { get; set; }
        public float Width { get; set; }
        public float InkAmount { get; set; }
        public Sharpies(string color, float width)
        {
            Color = color;
            Width = width;
            InkAmount = 100;
        }

        public void Use()
        {
            InkAmount--;
        }

    }
}
