namespace Diy_Project.Models
{
    public class Contract
    {
        public Contract(int iD, int customerID, int providerID, int serviceID, string description, DateTime startDate, DateTime endDate, int amount, bool isCountered, int status, DateTime created, DateTime modified)
        {
            ID = iD;
            CustomerID = customerID;
            ProviderID = providerID;
            ServiceID = serviceID;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Amount = amount;
            IsCountered = isCountered;
            Status = status;
            Created = created;
            Modified = modified;
        }

        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ProviderID { get; set; }
        public int ServiceID { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Amount { get; set; }
        public bool IsCountered { get; set; }
        public int Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

    }
}