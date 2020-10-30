﻿using System.Diagnostics.CodeAnalysis;

namespace Models
{
    public class User
    {
        [NotNull]
        public string UserName { get; set; }
        [NotNull]
        public string Password { get; set; }

        public void Update(User user)
        {
            if (user.UserName.Equals(UserName))
            {
                Password = user.Password;
            }
        }

        public User Copy()
        {
            return new User
            {
                UserName = UserName,
                Password = Password
            };
        }
    }
}