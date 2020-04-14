namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numA = new Counter();
            numA.num = 10;

            var numB = new Counter(9);
        }
    }

    class Counter
    {
        public int num { get; set; }

        public Counter()
        {
            num = 0;
        }

        public Counter(int num)
            : this()
        { }
        public void Add()
        {
            num++;
        }

        public void Get()
        {
            num.ToString();
        }

        public void Reset()
        {
            num = 0;
        }
    }
}
