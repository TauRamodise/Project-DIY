using System;
using System.Collections.Generic;

namespace Diy_Project.Models
{
    public class ContactDetail
    {
        public ContactDetail(int iD, string phoneNumber, string email, string telephone, string afterHours, int userID)
        {
            ID = iD;
            PhoneNumber = phoneNumber;
            Email = email;
            Telephone = telephone;
            AfterHours = afterHours;
            UserID = userID;
        }

        public int ID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string AfterHours { get; set; }
        public int UserID { get; set; }
    }
}