using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    class List
    {
        public static List<User> Users { get; set; }
        public static List<Reward> Rewards { get; set; }
        public List(List<User> users, List<Reward> rewards)
        {
            Users = users;
            Rewards = rewards;
        }
    }
}
