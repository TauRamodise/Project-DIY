﻿using System;
using System.Collections.Generic;

namespace Diy_Project.Models
{
    public partial class User
    {
        public User()
        {
  
        }

        public User(int iD, string firstName, string surname, string gender)
        {
            ID = iD;
            FirstName = firstName;
            Surname = surname;
            Gender = gender;
    
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }

    }
}