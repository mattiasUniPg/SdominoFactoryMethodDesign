namespace ClassesFactorySdomino
{
    abstract class Pizza
    {
        public abstract string Name { get; }
        public abstract int Price { get; set; }
        public abstract int Aggiunte { get; set; }

    }
}