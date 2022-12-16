namespace _08_PhoneBookBindings
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public bool IsMale { get; set; }
        public string FullName => Name + " " + Surname;
        public override string ToString()
        {
            return $"{Name}  {Surname}";
        }
        void Clone()
        {

        }
    }
}
