using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Naming.Terrible
{
   
    internal class UserRegistryBadNames
    {
        private List<User> r = new List<User>();
        public void AddUser(string fn, string sn, DateTime db)
        {
            // create user
            var u = new User();
            // generate random id
            var rd = new Random();
            var id = rd.Next();
            // ensure id is not already being used
            bool uq = false;
            while (!uq)
            { 
                uq = true;
                foreach (var ittr in r)
                {
                    if (ittr.id == id)
                    {
                        uq = false;
                    }
                }

                if (uq == false)
                {
                    id = rd.Next();
                }
            }
            
            // make sure user is old enough to make account
            if (DateTime.Compare(db, DateTime.Today.AddYears(-18)) < 0)
            {
                // make sure name is valid
                if (!string.IsNullOrEmpty(fn) && !string.IsNullOrEmpty(sn))
                {
                    var n = fn + " " + sn;
                    u.id = id;
                    u.n = n;
                    u.db = db;
                    r.Add(u);
                    Console.WriteLine("Success");
                }
                else
                    throw new Exception("Name not valid");
                
            }
            else
            {
                throw new Exception("Too young to make account");
            }
            

        }

        internal class User
        {
            public int id;
            public string n;
            public DateTime db;
        }
    }
}