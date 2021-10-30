using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Validation
    {
        public static void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) throw new Exception("Username cannot be empty.");
            if (username.Contains(" ")) throw new Exception("Username cannot contain spaces.");
            if (username.Length < 6) throw new Exception("Username must be at least 6 characters.");
            if (username.Length > 50) throw new Exception("Username must be below 6 characters.");
        }

        public static void ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password)) throw new Exception("Password cannot be empty.");
            if (password.Length < 6) throw new Exception("Password must be at least 6 characters.");
            if (password.Length > 128) throw new Exception("Password must be below 128 characters.");
        }

        public static void ValidatePassword(string password, string repeatPassword)
        {
            ValidatePassword(password);
            if (password != repeatPassword) throw new Exception("Password does not match.");

        }

        public static void ValidateFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) throw new Exception("Full name cannot be empty.");
        }

        public static void ValidatePhoneNo(string phoneNo)
        {
            if (string.IsNullOrWhiteSpace(phoneNo)) throw new Exception("Phone number cannot be empty");
            foreach(char c in phoneNo)
            {
                if (char.IsDigit(c) || c == '-') continue;
                throw new Exception("Phone number must only contain numbers or dashes");
            }
            
        }

        public static void ValidateEmail(string email)
        {
            if (!email.Contains("@")) throw new Exception("Enter a valid email");
        }
    }
}
