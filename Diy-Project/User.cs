namespace Diy_Project
{
    public class User
    {
        public string firstname { get; set; }
        public string surname { get; set; }


        public User()
        {

        }

        public User(string firstname, string surname)
        {
            this.firstname = firstname;
            this.surname = surname;
        }
    }
}
