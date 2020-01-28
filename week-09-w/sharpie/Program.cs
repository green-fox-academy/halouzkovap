namespace sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharpie1 = new Sharpie("Green", 5.030f);
            sharpie1.Use();
        }
    }
    class Sharpie
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
