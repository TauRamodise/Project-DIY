namespace Diy_Project.Models
{
    public class User
    {
        public int id { get; }
        public string Name{ get; set; }
        public string Surname { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public int DeliveryLocationID { get; set; }
        public int FavouriteCakeID { get; set; }


        public User()
        {

        }

        public User(int id, string name, string surname, string phoneNumber, string email, int deliveryLocationID, int favouriteCakeID)
        {
            this.id = id;
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
            DeliveryLocationID = deliveryLocationID;
            FavouriteCakeID = favouriteCakeID;
        }
    }
}
