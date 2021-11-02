using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Naming.Better
{

    internal class UserRegistryBetterNamed
    {
        private List<User> userRegistry = new List<User>();
        public void AddUser(string firstName, string lastName, DateTime dateOfBirth)
        {
            // create user
            var newUser = new User();
            // generate random id
            var randomNumberGenerator = new Random();
            var newUserRandomID = randomNumberGenerator.Next();
            // ensure id is not already being used
            bool newIdIsUnique = false;
            while (!newIdIsUnique)
            { 
                newIdIsUnique = true;
                foreach (var userFromRegistry in userRegistry)
                {
                    if (userFromRegistry.id == newUserRandomID)
                    {
                        newIdIsUnique = false;
                    }
                }

                if (newIdIsUnique == false)
                {
                    newUserRandomID = randomNumberGenerator.Next();
                }
            }
            
            // make sure user is old enough to make account
            var ageOfMaturity = -18;
            if (DateTime.Compare(dateOfBirth, DateTime.Today.AddYears(ageOfMaturity)) < 0)
            {
                // make sure name is valid
                if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                {
                    var fullName = firstName + " " + lastName;
                    newUser.id = newUserRandomID;
                    newUser.name = fullName;
                    newUser.dateOfBirth = dateOfBirth;
                    userRegistry.Add(newUser);
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
            public string name;
            public DateTime dateOfBirth;
        }
    }

}