namespace AnimalInZoo
{
    abstract class Animal
    {
        protected string Name { get; set; }
        protected int Age { get; set; }



        public virtual string GetName()
        {
            return $"{Name}";
        }

        protected abstract string Reproduction();
        public string WantChild()
        {
            return $"want a child from {Reproduction()}";
        }
    }
}
