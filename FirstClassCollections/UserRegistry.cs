using System.Collections;
using System.Collections.Generic;

namespace FirstClassCollections
{
    public class UserRegistry 
    {
        private List<User> _users;

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User GetByID(int id)
        {
            return _users.Find(user => user.id == id);
        }

        public void DeleteByID(int id)
        {
            _users.Remove(GetByID(id));
        }

        public List<User>.Enumerator GetEnumerator()
        {
            return _users.GetEnumerator();
        }
    }
}