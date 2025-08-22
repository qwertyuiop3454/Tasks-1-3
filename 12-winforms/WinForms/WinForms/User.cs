using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    class User
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Имя не должно быть пустым");
                }
                _firstName = value;
            }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Фамилия не должна быть пустой");
                }
                if(value.Length > 50)
                {
                    throw new Exception("Длина фамилии не должна быть больше 50 символов");
                }
                _lastName = value;
            }
        }
        private DateTime _birthdate;

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new Exception("Человек должен был родится до текущего времени");
                }
                if (value < new DateTime(1875, 1, 1))
                {
                    throw new Exception("Человеку не может быть больше 150 лет");
                }

                _birthdate = value;
            }
        }
        public List<Reward> ListRewards = new List<Reward>();

        private int _id = 0;
        public int ID
        {
            get
            {
                if (_id == 0)
                {
                    Random random = new Random();
                    _id = random.Next(0, int.MaxValue);
                    return _id;
                }
                return _id;
            }
        }
        public int Age
        {
            get { return (DateTime.Now.Year - Birthdate.Year); }
        }
        public User(string firstname, string lastname, DateTime birthdate)
        {
            FirstName = firstname;
            LastName = lastname;
            Birthdate = birthdate;
        }
    }
}
