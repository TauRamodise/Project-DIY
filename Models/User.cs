namespace Diy_Project.Models
{
    public class User
    {
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