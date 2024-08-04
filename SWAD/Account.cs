using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Account
    {
        private string username;
        private string password;
        private string email;
        private string fullName;
        private string phoneNo;
        private static List<Account> userList = new List<Account>();

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        public List<Account> UserList { get { return userList; } }

        public Account(string username, string password, string email, string fullName, string phoneNo)
        {
            Username = username;
            Password = password;
            Email = email;
            FullName = fullName;
            PhoneNo = phoneNo;
        }

        //Method to check whether username is taken
        public static bool checkUsername(string username)
        {
            foreach (var user in userList)
            {
                if (user.Username == username)
                {
                    return true;
                    Console.WriteLine("Username taken. Please enter another one.");
                }
            }
            return false;
        }

        //Method to add new account created to a list
        public static void AddAccount(Account account)
        {
            userList.Add(account);
        }

        //Method to list all the accounts
        public static void ListUsers()
        {
            foreach (var user in userList)
            {
                Console.WriteLine(user.Username);
            }
        }

    }
}
