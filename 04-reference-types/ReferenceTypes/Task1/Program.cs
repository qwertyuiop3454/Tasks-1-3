internal class Program
{
    class User
    {
        private string _name;
        public string Name { 
            get { return _name; } 
            set {
                if (value.Length < 1) 
                {
                    throw new Exception("Имя не должно быть пустым");
                }
                _name = value;
            } }

        private string _lastname;
        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Фамилия не должна быть пустой");
                }
                _lastname = value;
            }
        }

        
        public string Patronymic { get; set; }
        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new Exception("Человек должен был родится до текущего времени");
                }
                if(value < new DateTime (1900,1,1))
                {
                    throw new Exception("Человеку не может быть больше 125 лет");
                }
                
                _birthday = value;
            }
        }
        public int Age
        {
            get { return (DateTime.Now.Year - Birthday.Year); }
        }
        public User(string name, string lastName, string patronymic, DateTime birthday)
        {
            Name = name;
            LastName = lastName;
            Patronymic = patronymic;
            Birthday = birthday;
        }
    }


    
    private static void Main(string[] args)
    {
        User a = new User("Иван", "Иванов", "Иваныч", new DateTime(2019, 7, 1));
        Console.WriteLine(a.Age);
    }
}