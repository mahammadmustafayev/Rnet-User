using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTask.Interfaces;

namespace UserTask.Models
{
    internal class User : IAccount
    {
        private static int _id = 1;
        private string _password;
        public int Id { get => _id++; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get => _password; set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }
        public User(string fullName,string email)
        {
            this.FullName = fullName;
            this.Email = email;
        }
        public bool PasswordChecker(string password)
        {
            bool isLower=false;
            bool isDigit=false;
            bool isUpper=false;
            if (password.Length>8)
            {
                foreach (var character in password)
                {
                    if (!char.IsDigit(character)) isDigit = false;
                    else if (!char.IsLower(character)) isLower = false;
                    else if (char.IsUpper(character)) isUpper = false;
                }
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Password null gele bilmez");
                Console.ResetColor();
                return false;
            }
            if (isDigit && isLower && isUpper) 
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Password uqurludur");
                Console.ResetColor();
                return true;
            } 
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{_id} FullName:{FullName} Email:{Email}");
        }
    }
}
