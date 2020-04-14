namespace SharpieSet
{

    public class Sharpie
    {
        public string Color { get; set; }
        public float Width { get; set; }
        public float InkAmount { get; set; }

        public Sharpie(string Color, float width)
        {
            InkAmount = 100;
        }

        public void Use()
        {
            InkAmount--;
        }

    }
}
