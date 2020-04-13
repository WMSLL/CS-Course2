namespace ClassWork10_2
{
    class Pet
    {
        public string _kind { get; set; }
        public string _name { get; set; }
        public char _sex { get; set; }
        public int _age { get; set; }

        public string InfoPet => $"Питомец {_kind} Кличка {_name} Возраст {_age} Пол {_sex}";


    }
}
