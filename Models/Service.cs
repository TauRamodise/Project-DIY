namespace Diy_Project.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string? ProviderName { get; set; }
        public string? ServiceType{ get; set; }
        public string? Description { get; set; }
        public decimal CallOutFee { get; set; }
        public int UserID { get; set; }
    }
}