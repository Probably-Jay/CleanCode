using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Naming.Best
{

    internal class UserRegistryBest
    {
        private List<User> userRegistry = new List<User>();
        
        public void AddUser(string firstName, string lastName, DateTime dateOfBirth)
        {
            // create user
            var newUser = CreateUser();

            // generate random id
            var newUserRandomID = GenerateUniqueUserID(new Random());

            TryCreateUser(newUser, firstName, lastName, dateOfBirth, newUserRandomID);
        }

        private static User CreateUser() => new User();

        private int GenerateUniqueUserID(Random randomNumberGenerator)
        {
            var newUserRandomID = GenerateNewRandomNumber(randomNumberGenerator);
            bool newIdIsUnique = false;

            // ensure id is not already being used
            while (!newIdIsUnique)
            {
                newIdIsUnique = CompareIDToAllOtherUsers(newUserRandomID);

                if (!newIdIsUnique)
                {
                    newUserRandomID = GenerateNewRandomNumber(randomNumberGenerator);
                }
            }

            return newUserRandomID;
        }
        private static int GenerateNewRandomNumber(Random randomNumberGenerator) => randomNumberGenerator.Next();

        private bool CompareIDToAllOtherUsers(int newUserRandomID)
        {
            var idIsUnique = true;
            foreach (var userFromRegistry in userRegistry)
            {
                if (userFromRegistry.id == newUserRandomID)
                {
                    idIsUnique = false;
                }
            }

            return idIsUnique;
        }


        private void TryCreateUser(User newUser, 
            string firstName, string lastName, DateTime dateOfBirth, int newUserRandomID)
        {
            // make sure user is old enough to make account
            if (UserIsAboveAgeOfMaturity(dateOfBirth))
            {
                // make sure name is valid
                if (FullNameIsNotNullOrEmpty(firstName, lastName))
                {
                    SetUserDetails(newUser, firstName, lastName, dateOfBirth, newUserRandomID);
                    AddUserToRegistry(newUser);
                }
                else
                    throw new Exception("Name not valid");
            }
            else
            {
                throw new Exception("Too young to make account");
            }
        }
        
        private static bool UserIsAboveAgeOfMaturity(DateTime dateOfBirth)
        {
            var ageOfMaturity = -18;
            return DateTime.Compare(dateOfBirth, DateTime.Today.AddYears(ageOfMaturity)) < 0;
        }

        private static bool FullNameIsNotNullOrEmpty(string firstName, string lastName) 
            => !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName);

        private static void SetUserDetails(User newUser,
            string firstName, string lastName, DateTime dateOfBirth, int newUserRandomID)
        {
            var fullName = CreateFullName(firstName, lastName);
            newUser.id = newUserRandomID;
            newUser.name = fullName;
            newUser.dateOfBirth = dateOfBirth;
            Console.WriteLine("Success");
        }

        private static string CreateFullName(string firstName, string lastName)
        {
            var fullName = firstName + " " + lastName;
            return fullName;
        }

        private void AddUserToRegistry(User newUser) => userRegistry.Add(newUser);


        internal class User
        {
            public int id;
            public string name;
            public DateTime dateOfBirth;
        }
    }

}