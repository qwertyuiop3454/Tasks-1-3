using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    class Reward
    {
        private string _title;
        public string Title { get { return _title; } set
            {
                if (value.Length > 50)
                {
                    throw new Exception("Длина названия не должна быть больше 50 символов");
                }
                if(value.Length < 1)
                {
                    throw new Exception("Название награды не может быть пустым");
                }
                _title = value;
            }
        }
        private string _description;
        public string Description { get { return _description; } set
            {
                if (value.Length > 250)
                {
                    throw new Exception("Длина описания не должна быть больше 250 символов");
                }
                _description = value;
            }
        }
        public Reward(string title, string description)
        {
            Title = title;
            Description = description;
        }
        public Reward(string title)
        {
            Title = title;
            Description = "";
        }

        private int _id = 0;
        public int ID
        {
            get
            {
                if(_id == 0)
                {
                    Random random = new Random();
                    _id = random.Next(0, int.MaxValue);
                    return _id;
                }
                return _id;
            }
        }
    }
}
