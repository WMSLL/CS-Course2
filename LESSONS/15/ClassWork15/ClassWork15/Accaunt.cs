namespace ClassWork15
{
    class Accaunt<T>
    {
        public T Id { get; private set; }
        public string Name { get; private set; }

        public Accaunt(T id, string name)
        {
            Id = id;
            Name = name;
        }
        public void WriteProperties()
        {
            System.Console.WriteLine($"Id:{Id}  ,   Name:{Name}");
        }

    }
}
